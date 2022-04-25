import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Usuario } from 'src/app/models/Usuario.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UsuariosService {

  endpoint = "";
  constructor(private http: HttpClient) {
    this.endpoint = environment.apiUrl+"usuarios/";
  }

  activos() {
    return this.http.get<Usuario[]>(this.endpoint+'activos');
  }
  

  
}
