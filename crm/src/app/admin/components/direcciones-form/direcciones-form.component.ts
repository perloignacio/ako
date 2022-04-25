import { AfterViewInit, Component, ElementRef, NgZone, OnInit, ViewChild } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Direcciones } from 'src/app/models/Direcciones.model';
import { AgmMap, MapsAPILoader } from '@agm/core';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-direcciones-form',
  templateUrl: './direcciones-form.component.html',
  styleUrls: ['./direcciones-form.component.scss']
})
export class DireccionesFormComponent implements OnInit,AfterViewInit {
  obj:Direcciones=new Direcciones();
  latitude: number=-31.399377;
  longitude: number=-64.3344307;
  zoom: number=11;
  address: string;

  private geoCoder:any;
  @ViewChild('search')
  public searchElementRef: ElementRef;
  constructor(private activeModal:NgbActiveModal,private mapsAPILoader: MapsAPILoader, private ngZone: NgZone,private srvShared:SharedService) {
    
  }
  ngAfterViewInit():void{
    this.mapsAPILoader.load().then(() => {
      //this.setCurrentLocation();
      this.geoCoder = new google.maps.Geocoder;
      if(this.srvShared.objModal as Direcciones!=null){
        this.obj=this.srvShared.objModal;
        this.latitude=Number.parseFloat(this.obj.Latitud);
        this.longitude=Number.parseFloat(this.obj.Longitud);
       
      }
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
      /*let autocomplete = new google.maps.places.Autocomplete(this.searchElementRef.nativeElement);
      autocomplete.addListener("place_changed", () => {
        this.ngZone.run(() => {
          let place: google.maps.places.PlaceResult = autocomplete.getPlace();
  
          if (place.geometry === undefined || place.geometry === null) {
            return;
          }
  
          this.latitude = place.geometry.location.lat();
          this.longitude = place.geometry.location.lng();
          this.zoom = 12;
        });
      });*/
      
    });
  }
  ngOnInit(): void {
    
    
  }
  /*private setCurrentLocation() {
    if ('geolocation' in navigator) {
      navigator.geolocation.getCurrentPosition((position) => {
        this.latitude = position.coords.latitude;
        this.longitude = position.coords.longitude;
        this.zoom = 8;
        this.getAddress(this.latitude, this.longitude);
      });
    }
  }*/

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
  Guardar(){
    this.obj.Latitud=this.latitude.toString();
    this.obj.Longitud=this.longitude.toString();
    this.obj.Ubicacion=this.address;
    
    this.activeModal.close(this.obj);
  }
}
