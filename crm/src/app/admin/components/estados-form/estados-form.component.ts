import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Estados } from 'src/app/models/Estados.model';
import { ContactosHistorialEstado } from 'src/app/models/HistorialEstado.model';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import { EstadosService } from 'src/app/services/estados/estados.service';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-estados-form',
  templateUrl: './estados-form.component.html',
  styleUrls: ['./estados-form.component.scss']
})
export class EstadosFormComponent implements OnInit {
  editar:boolean=false;
  Estados:Estados[]=[];
  obj:ContactosHistorialEstado=new ContactosHistorialEstado();
  constructor(private activeModal:NgbActiveModal,private srvEstados:EstadosService,private srvShared:SharedService,private srvAut:AuthenticationService) { 
    this.srvEstados.tipos().subscribe((l)=>{
      this.Estados=l;
      if(this.srvShared.objModal as ContactosHistorialEstado!=null){
        this.obj=this.srvShared.objModal;
        this.editar=true;
      }
    })
  }

  ngOnInit(): void {
  }
  Guardar(){
    
    this.obj.ContactosEstadosEntity=this.Estados.find((t)=>t.IdEstadoContacto==this.obj.IdEstadoContacto)
    
    //To-do:Cambiar por el que esta logueado
    this.obj.IdUsuarioContacto=this.srvAut.currentUserValue.IdUsuario;
    this.obj.ContactoUsuariosEntity=this.srvAut.currentUserValue;
    if(!this.editar){
      this.obj.Fecha=new Date();
    }
    
    this.activeModal.close(this.obj);
  }

}
