import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { tipoAccion } from 'src/app/models/TipoAccion.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AccionesService {

  endpoint = "";
  constructor(private http: HttpClient) {
    this.endpoint = environment.apiUrl+"acciones/";
  }

  tipos() {
    return this.http.get<tipoAccion[]>(this.endpoint+'tipos');
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
