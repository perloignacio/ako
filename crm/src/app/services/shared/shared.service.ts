import { Injectable } from '@angular/core';
import { Contactos } from 'src/app/models/Contactos.model';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  ObjEdit:any;
  Contacto:Contactos;
  constructor() { }
}
