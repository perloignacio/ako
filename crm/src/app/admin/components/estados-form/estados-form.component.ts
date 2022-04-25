import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Estados } from 'src/app/models/Estados.model';
import { ContactosHistorialEstado } from 'src/app/models/HistorialEstado.model';
import { EstadosService } from 'src/app/services/estados/estados.service';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-estados-form',
  templateUrl: './estados-form.component.html',
  styleUrls: ['./estados-form.component.scss']
})
export class EstadosFormComponent implements OnInit {

  Estados:Estados[]=[];
  obj:ContactosHistorialEstado=new ContactosHistorialEstado();
  constructor(private activeModal:NgbActiveModal,private srvEstados:EstadosService,private srvShared:SharedService) { 
    this.srvEstados.tipos().subscribe((l)=>{
      this.Estados=l;
      if(this.srvShared.objModal as ContactosHistorialEstado!=null){
        this.obj=this.srvShared.objModal;
      }
    })
  }

  ngOnInit(): void {
  }
  Guardar(){
    
    this.obj.ContactosEstadosEntity=this.Estados.find((t)=>t.IdEstadoContacto==this.obj.IdEstadoContacto)
    
    //To-do:Cambiar por el que esta logueado
    this.obj.ContactoUsuariosEntity={"IdUsuario":1,"Nombre":"Ignacio ","Apellido":"Perlo","Email":"Perloignacio@gmail.com","IdTipoUsuario":1,"Usuario":"ignacio","Contra":"perlo","Activo":true,"Token":""}
    this.obj.IdUsuarioContacto=this.obj.ContactoUsuariosEntity.IdUsuario;
    this.activeModal.close(this.obj);
  }

}
