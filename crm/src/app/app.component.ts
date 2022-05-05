import { Component } from '@angular/core';
import { AuthenticationService } from './services/authentication/authentication.service';
import { UsuariosService } from './services/usuarios/usuarios.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'crm';
  
}
