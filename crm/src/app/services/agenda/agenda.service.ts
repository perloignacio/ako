import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Agenda } from 'src/app/models/Agenda.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AgendaService {
  endpoint: string;

  constructor(private http: HttpClient) {
    this.endpoint = environment.apiUrl+"agenda/Admin/";
  }

  GetEventos() {
    return this.http.get<Agenda[]>(this.endpoint+'eventos');
  }

  Borrar(id:number) {
    return this.http.get<boolean>(this.endpoint+'Borrar?id='+id);
  }
  
  AgregarEditar(form:any) {
    return this.http.post<boolean>(this.endpoint+'AgregarEditar',form);
  }
}
