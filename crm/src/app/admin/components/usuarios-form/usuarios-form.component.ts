import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { tipoUsuario } from 'src/app/models/tipoUsuario.model';
import { Usuario } from 'src/app/models/Usuario.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UsuariosService } from 'src/app/services/usuarios/usuarios.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-usuarios-form',
  templateUrl: './usuarios-form.component.html',
  styleUrls: ['./usuarios-form.component.scss']
})
export class UsuariosFormComponent implements OnInit {
  TipoUsuarios:tipoUsuario[]=[];
  contra:string;
  obj:Usuario=new Usuario();
  Agregar:boolean=true;
  
  constructor(private srvShared:SharedService,private srvObj:UsuariosService,private route:Router,) {
    this.srvObj.tipos().subscribe((t)=>{
      this.TipoUsuarios=t;
      this.obj=this.srvShared.ObjEdit as Usuario;
      if(this.obj!=null){
        this.Agregar=false;
      }else{
        this.obj=new Usuario();
      }
    })  
  }

  Guardar(){
    const form=new FormData();
    if(!this.Agregar){
      form.append("id",this.obj.IdUsuario.toString());
    }else{
      form.append("id","0");
    }
   if(this.contra!=""){
    this.obj.Contra=this.contra;
   }
    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
 
    this.srvObj.AgregarEditar(form).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizo con exito",'success');
        this.route.navigate(['admin/usuarios'])
      }
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
  
  Volver(){
    history.back();
  }

  ngOnInit(): void {
  }

}
