import { Component } from '@angular/core';
import { correccion } from './models/correcion.model';
import { glifosato } from './models/glifosato.mode';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  glifo:glifosato=new glifosato();
  corre:correccion=new correccion();
  ingrsoglif:boolean=true;
  title = 'app';
  ingrsogcorr:boolean=true;
  totalesta:number=0;
  totalako:number=0;
  resultadofinal=false;
  loading:boolean=true;
  CalularGli(){
    this.glifo.porinactivacion=this.glifo.volumen*this.glifo.dureza*this.glifo.villaseca;
    this.glifo.valinactivacion=this.glifo.costo*(this.glifo.porinactivacion/100);
    this.glifo.perdida=this.glifo.dosis*this.glifo.valinactivacion;
    this.ingrsoglif=false;
    this.CalcularCostos();
  }

  OtroGli(){
    this.ingrsoglif=true;
    this.glifo=new glifosato
  }

  CalularCorr(){
    this.corre.canthec=Number.parseFloat((this.corre.volumen/this.corre.litros).toFixed(2));
    this.corre.costohec=Number.parseFloat((this.corre.costoeco/this.corre.canthec).toFixed(2));
    ;
    this.ingrsogcorr=false;
    this.CalcularCostos();
  }

  CalcularCostos(){
    if(!this.ingrsogcorr && !this.ingrsoglif){
      this.resultadofinal=true;
      setTimeout(()=>{                           //<<<---using ()=> syntax
        
        
        this.loading=false;
        this.totalesta=Number.parseFloat((this.corre.hectareas*this.corre.cantidad*this.glifo.perdida).toFixed(2));
        this.totalako=Number.parseFloat((this.corre.hectareas*this.corre.cantidad*this.corre.costohec).toFixed(2));
      }, 3000);
    }

  }
  OtroCorr(){
    this.ingrsogcorr=true;
    this.corre=new correccion
  }

  nuevo(){
    this.OtroCorr();
    this.OtroGli();
    this.loading=true;
    this.resultadofinal=false;
  }
}
