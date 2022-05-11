import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { usuario } from 'src/app/models/usuario.model';
import { SharedService } from 'src/app/services/shared/shared.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  usuario:string="";
  contra:string="";
  constructor(private svcShared:SharedService,private router:Router) { }
  Ingresar(){
    if(this.usuario=="Admin" && this.contra=="ak0w3b"){
      this.svcShared.usuario=new usuario();
      this.router.navigate(['/home']);
    }else{
      alert("Usuario / contraseña incorrecta");
    }
  }
  ngOnInit(): void {
  }

}
