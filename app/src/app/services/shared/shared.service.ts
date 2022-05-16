import { Injectable } from '@angular/core';
import { JsonResult } from 'src/app/models/jsonResult.model';
import { Usuario } from 'src/app/models/usuario.model';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  usuario?:Usuario=undefined;
  constructor() { }

  convertToJSON(objeto: any): JsonResult {
    var resultado: JsonResult;
    try {
      var objetoJson = JSON.stringify(objeto);
      resultado = {
        resultado: true,
        objeto: objetoJson,
      };
    } catch (error) {
      resultado = {
        resultado: false,
        objeto: 'No se pudo convertir el objeto al formato JSON',
      };
    }
    return resultado;
  }
}
