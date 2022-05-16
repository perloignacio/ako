import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Usuario } from 'src/app/models/usuario.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UsuariosService {

  endpoint = "";
  constructor(private http: HttpClient) {
    this.endpoint = environment.apiUrl+"usuarios/";
  }
  login(usuario:string,contra:string) {
    return this.http.get<Usuario>(this.endpoint+'login?usuario='+usuario+'&contra='+contra);
  }

  registrar(form:any) {
    return this.http.post<boolean>(this.endpoint+'registrar',form);
  }
}
