import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class HomeService {

  endpoint = "";
  constructor(private http: HttpClient) {
    this.endpoint = environment.apiUrl+"Home/";
  }

  enviar(obj:any) {
    return this.http.post<boolean>(this.endpoint+'Enviar',obj);
  }
}
