import { MapsAPILoader } from '@agm/core';
import { Component, ElementRef, NgZone, OnInit, ViewChild } from '@angular/core';
import Stepper from 'bs-stepper';
import { Contactos } from 'src/app/models/Contactos.model';
import { correccion } from 'src/app/models/correcion.model';
import { Direcciones } from 'src/app/models/Direcciones.model';
import { glifosato } from 'src/app/models/glifosato.mode';
import { home } from 'src/app/models/Home.model';
import { Usuario } from 'src/app/models/Usuario.model';
import { HomeService } from 'src/app/services/home/home.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {
  private stepper:Stepper;
  glifo:glifosato=new glifosato();
  corre:correccion=new correccion();
  enviado:boolean=false;
  InformacionCargada:boolean=true;
  home:home=new home();
  usu:Contactos=new Contactos();
  latitude: number=-31.399377;
  longitude: number=-64.3344307;
  zoom: number=11;
  address: string;

  private geoCoder:any;
  @ViewChild('search')
  public searchElementRef: ElementRef;

  constructor(private mapsAPILoader: MapsAPILoader, private ngZone: NgZone,private srvHome:HomeService,private srvShared:SharedService) { }

  ngOnInit(): void {
    this.stepper = new Stepper(document.querySelector('#stepper1'), {
      linear: false,

      animation: true
    })
  }

  ngAfterViewInit():void{
    this.mapsAPILoader.load().then(() => {
      //this.setCurrentLocation();
      this.geoCoder = new google.maps.Geocoder;
      
      this.getAddress(this.latitude, this.longitude);
      this.mapsAPILoader.load().then(() => {
        let autocomplete = new google.maps.places.Autocomplete(this.searchElementRef.nativeElement);
        autocomplete.addListener("place_changed", () => {
          this.ngZone.run(() => {
            // some details
            let place: google.maps.places.PlaceResult = autocomplete.getPlace();
            this.address = place.formatted_address;
            
            //set latitude, longitude and zoom
            this.latitude = place.geometry.location.lat();
            this.longitude = place.geometry.location.lng();
            this.zoom = 12;
          });
        });
      });
      
      
    });
  }

  markerDragEnd($event: any) {
    console.log($event);
    this.latitude = $event.latLng.lat();
    this.longitude = $event.latLng.lng();
    this.getAddress(this.latitude, this.longitude);
  }

  getAddress(latitude:any, longitude:any) {
    this.geoCoder.geocode({ 'location': { lat: latitude, lng: longitude } }, (results:any, status:any) => {
      if (status === 'OK') {
        if (results[0]) {
          this.zoom = 12;
          this.address = results[0].formatted_address;
        } else {
          window.alert('No results found');
        }
      } else {
        window.alert('Geocoder failed due to: ' + status);
      }
  
    });
  }
  

  paso1() {
    if(this.glifo.volumen==0 || this.glifo.dureza==0 || this.glifo.costo==0 || this.glifo.dosis==0 || this.corre.volumen==0 || this.corre.litros==0  || this.corre.costoeco==0 || this.corre.hectareas==0 ){
      Swal.fire("Upps","Todos los datos son obligatorios",'warning');
    }else{
      this.glifo.porinactivacion=this.glifo.volumen*this.glifo.dureza*this.glifo.villaseca;
      this.glifo.valinactivacion=this.glifo.costo*(this.glifo.porinactivacion/100);
      this.glifo.perdida=this.glifo.dosis*this.glifo.valinactivacion;
      this.corre.canthec=Number.parseFloat((this.corre.volumen/this.corre.litros).toFixed(2));
      this.corre.costohec=Number.parseFloat((this.corre.costoeco/this.corre.canthec).toFixed(2));
      this.home.totalesta=Number.parseFloat((this.corre.hectareas*this.corre.cantidad*this.glifo.perdida).toFixed(2));
      this.home.totalako=Number.parseFloat((this.corre.hectareas*this.corre.cantidad*this.corre.costohec).toFixed(2));
      this.home.glifosato=this.glifo;
      this.home.correccion=this.corre;
      this.stepper.next();
    }
    
  }

  paso2(){
    if(this.usu.Nombre=="" || this.usu.Apellido=="" || this.usu.Email=="" || this.usu.Nombre.length<2 || this.usu.Apellido.length<2 || this.usu.Email.length<5 || !this.usu.Email.includes("@") ){
      Swal.fire("Upps","Por favor complete el Nombre, Apellido y Email",'warning');
    }else{
      this.usu.Direcciones=[];
      if(this.address!=""){
        let d=new Direcciones();
        d.Ubicacion=this.address;
        d.Latitud=this.latitude.toString();
        d.Longitud=this.longitude.toString();
        d.Nombre="DirWeb";
        this.usu.IdOrigen=2;
        this.usu.Activo=true;
        this.usu.Direcciones.push(d);
      }
      this.home.contacto=this.usu;
      let form:FormData=new FormData();
      form.append("obj",this.srvShared.convertToJSON(this.home).objeto);
      this.srvHome.enviar(form).subscribe((b)=>{
        if(b){
          this.enviado=true;
          this.stepper.next();
        }
      },(err)=>{

        Swal.fire("Upps",err.error.Message,'warning');
      })
     
    }
  }
  onSubmit() {
    return false;
  }


}
