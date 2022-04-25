import { tipoAccion } from "./TipoAccion.model";
import { Usuario } from "./Usuario.model";

export class Acciones{
    IdHistorialAcciones:number;
    IdTipoAccion:number;
    Accion:string;
    IdContacto:number;
    IdUsuario:number;
    Fecha:Date;
    Activo:boolean;
    ContactosTipoAccionesEntity:tipoAccion;
    ContactoUsuariosEntity:Usuario;
    IdObjeto:number;
    IdClase:number=Math.floor(Math.random() * (100000 - 0)) + 100000;
}