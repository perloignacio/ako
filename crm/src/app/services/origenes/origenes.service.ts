import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Origenes } from 'src/app/models/Origenes.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class OrigenesService {

  endpoint = "";
  constructor(private http: HttpClient) {
    this.endpoint = environment.apiUrl+"origenes/Admin/";
  }

  tipos() {
    return this.http.get<Origenes[]>(this.endpoint+'tipos');
  }

  todosAdmin() {
    return this.http.get<Origenes[]>(this.endpoint+'todosAdmin');
  }
  
  Borrar(id:number) {
    return this.http.get<boolean>(this.endpoint+'Borrar?id='+id);
  }
  Activar(id:number) {
    return this.http.get<boolean>(this.endpoint+'Activar?id='+id);
  }

}
