import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Estados } from 'src/app/models/Estados.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class EstadosService {

  endpoint = "";
  constructor(private http: HttpClient) {
    this.endpoint = environment.apiUrl+"estados/Admin/";
  }

  tipos() {
    return this.http.get<Estados[]>(this.endpoint+'tipos');
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
