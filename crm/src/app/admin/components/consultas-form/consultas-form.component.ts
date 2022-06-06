import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { correccion } from 'src/app/models/correcion.model';
import { glifosato } from 'src/app/models/glifosato.mode';
import { home } from 'src/app/models/Home.model';
import { AgendaService } from 'src/app/services/agenda/agenda.service';
import { ContactosService } from 'src/app/services/contactos/contactos.service';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-consultas-form',
  templateUrl: './consultas-form.component.html',
  styleUrls: ['./consultas-form.component.scss']
})
export class ConsultasFormComponent implements OnInit {
  glifo:glifosato=new glifosato();
  totalesta:number;
  totalako:number;
  corre:correccion=new correccion();
  constructor(private srvShared:SharedService,private activemodal:NgbActiveModal) { 
    if(this.srvShared.objModal as home!=null){
      let obj= this.srvShared.objModal as home;
      this.glifo=obj.glifosato;
      this.corre=obj.correccion;
      this.totalako=obj.totalako;
      this.totalesta=obj.totalesta;
    }
  }

  ngOnInit(): void {
  }

}
