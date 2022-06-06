import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Contactos } from 'src/app/models/Contactos.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ContactosService {

  endpoint = "";
  constructor(private http: HttpClient) {
    this.endpoint = environment.apiUrl+"contactos/Admin/";
  }

  todosAdmin(b:boolean) {
    return this.http.get<Contactos[]>(this.endpoint+'todosAdmin?mios='+b);
  }
  todoActivos() {
    return this.http.get<Contactos[]>(this.endpoint+'todosActivos');
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
