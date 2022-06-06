import { Component, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Asignaciones } from 'src/app/models/Asignaciones.model';
import { Usuario } from 'src/app/models/Usuario.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UsuariosService } from 'src/app/services/usuarios/usuarios.service';

@Component({
  selector: 'app-asignaciones-form',
  templateUrl: './asignaciones-form.component.html',
  styleUrls: ['./asignaciones-form.component.scss']
})
export class AsignacionesFormComponent implements OnInit {
  editar:boolean=false;
  Usuarios:Usuario[]=[];
  obj:Asignaciones=new Asignaciones();
  constructor(private activeModal:NgbActiveModal,private srvUsuarios:UsuariosService,private srvShared:SharedService) {
    this.srvUsuarios.activos().subscribe((l)=>{
      if(this.srvShared.objModal as Asignaciones!=null){
        this.obj=this.srvShared.objModal;
        this.editar=true;
      }
      this.Usuarios=l;
    })
   }

  ngOnInit(): void {
  }
  Guardar(){
    
    if(!this.editar){
      this.obj.Fecha=new Date();
    }
    this.obj.ContactoUsuariosEntity=this.Usuarios.find((u)=>u.IdUsuario==this.obj.IdUsuarioContacto);
    this.activeModal.close(this.obj);
  }

}
