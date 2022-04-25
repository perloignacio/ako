import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Acciones } from 'src/app/models/Acciones.model';
import { tipoAccion } from 'src/app/models/TipoAccion.model';
import { AccionesService } from 'src/app/services/acciones/acciones.service';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-acciones-form',
  templateUrl: './acciones-form.component.html',
  styleUrls: ['./acciones-form.component.scss']
})
export class AccionesFormComponent implements OnInit {
  TipoAcciones:tipoAccion[]=[];
  obj:Acciones=new Acciones();
  constructor(private activeModal:NgbActiveModal,private srvAcciones:AccionesService,private srvShared:SharedService) {
    this.srvAcciones.tipos().subscribe((l)=>{
      if(this.srvShared.objModal as Acciones!=null){
        this.obj=this.srvShared.objModal;
      }
      this.TipoAcciones=l;
    })
   }

  ngOnInit(): void {
  }
  Guardar(){
    
    this.obj.ContactosTipoAccionesEntity=this.TipoAcciones.find((t)=>t.IdTipoAccionContacto==this.obj.IdTipoAccion)
    //To-do:Cambiar por el que esta logueado
    this.obj.ContactoUsuariosEntity={"IdUsuario":1,"Nombre":"Ignacio ","Apellido":"Perlo","Email":"Perloignacio@gmail.com","IdTipoUsuario":1,"Usuario":"ignacio","Contra":"perlo","Activo":true,"Token":""}
    this.obj.IdUsuario=this.obj.ContactoUsuariosEntity.IdUsuario;
    this.activeModal.close(this.obj);
  }
}
