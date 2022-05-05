import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { tipoUsuario } from 'src/app/models/tipoUsuario.model';
import { Usuario } from 'src/app/models/Usuario.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UsuariosService {

  endpoint = "";
  constructor(private http: HttpClient) {
    this.endpoint = environment.apiUrl+"usuarios/Admin/";
  }

  activos() {
    return this.http.get<Usuario[]>(this.endpoint+'activos');
  }

  checktoken() {
    return this.http.get<boolean>(this.endpoint+'checktoken');
  }

  todosAdmin() {
    return this.http.get<Usuario[]>(this.endpoint+'todosAdmin');
  }
  
  tipos() {
    return this.http.get<tipoUsuario[]>(this.endpoint+'tipos');
  }
  
  Borrar(id:number) {
    return this.http.get<boolean>(this.endpoint+'Borrar?id='+id);
  }
  Activar(id:number) {
    return this.http.get<boolean>(this.endpoint+'Activar?id='+id);
  }
  AgregarEditar(form:any) {
    return this.http.post<boolean>(this.endpoint+'AgregarEditar',form);
  }

  
}
