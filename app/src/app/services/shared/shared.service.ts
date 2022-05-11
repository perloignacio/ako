import { Injectable } from '@angular/core';
import { usuario } from 'src/app/models/usuario.model';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  usuario?:usuario=undefined;
  constructor() { }
}
