import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  usuario:string;
  contra:string;
  constructor(private svcAuthentication:AuthenticationService,private router:Router) { }

  ngOnInit(): void {
  }
  Ingresar(){
    this.svcAuthentication.login(this.usuario,this.contra).subscribe((u)=>{
      if(u!=null){
        if(u.IdTipoUsuario==1 || u.IdTipoUsuario==2){
          this.router.navigate(['/admin/dashboard']);
        }else{
          u=null;
          Swal.fire("Upps","Usuario / contraseña incorrectos",'warning');
        }

      }
    },(err)=>{
      console.log(err);
      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
}
