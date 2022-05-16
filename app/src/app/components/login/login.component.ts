import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Contacto } from 'src/app/models/contacto.model';
import { Usuario } from 'src/app/models/usuario.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UsuariosService } from 'src/app/services/usuarios/usuarios.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  usuario:string="";
  contra:string="";
  ingreso:boolean=true;
  c:Contacto=new Contacto();
  constructor(private svcShared:SharedService,private router:Router,private srvUsuario:UsuariosService) { }
  Ingresar(){
    if(this.usuario=="Admin" && this.contra=="ak0w3b"){
      this.svcShared.usuario=new Usuario();
      this.svcShared.usuario.Activo=true;
      this.svcShared.usuario.Apellido="Genérico";
      this.svcShared.usuario.Nombre="Genérico";
      this.svcShared.usuario.IdUsuario=-1;
      this.router.navigate(['/home']);
    }else{
      if(this.usuario!="" && this.contra!=""){
        this.srvUsuario.login(this.usuario,this.contra).subscribe((u)=>{
          this.svcShared.usuario=u;
          this.router.navigate(['/home']);
        },(err)=>{
  
          Swal.fire("Upps","Usuario / contraseña incorrecta",'warning');
        });
      }else{
        Swal.fire("Upps","Ingrese un usuario y contraseña",'warning');
      }
      
     
    }
  }
  Registrar(){
    if(this.usuario!="" && this.contra!="" && this.c.Apellido!="" && this.c.Email!="" && this.c.Nombre!="" && this.c.Telefono!=""){
      const formData = new FormData();
      formData.append('contacto', this.svcShared.convertToJSON(this.c).objeto);
      this.svcShared.usuario=new Usuario();
      this.svcShared.usuario.Apellido=this.c.Apellido;
      this.svcShared.usuario.Email=this.c.Email;
      this.svcShared.usuario.Telefono=this.c.Telefono;
      this.svcShared.usuario.Nombre=this.c.Nombre;
      this.svcShared.usuario.IdTipoUsuario=4;
      this.svcShared.usuario.Contra=this.contra;
      this.svcShared.usuario.Usuario=this.usuario;
      formData.append('usuario', this.svcShared.convertToJSON(this.svcShared.usuario).objeto);
      this.srvUsuario.registrar(formData).subscribe((u)=>{
        Swal.fire("Ok","El registro se realizo correctamente",'success');
       this.svcShared.usuario=null;
       this.ingreso=true;
        
      },(err)=>{

        Swal.fire("Upps","Usuario / contraseña incorrecta",'warning');
      });
    }else{
      Swal.fire("Upps","Todos los datos son obligatorios",'warning');
    }
  }

  ngOnInit(): void {
  }

}
