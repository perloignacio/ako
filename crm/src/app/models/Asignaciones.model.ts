import { Usuario } from "./Usuario.model";

export class Asignaciones{
    IdHistorialAsignacionesContacto:number;
    IdContacto:number;
    IdUsuarioContacto:number;
    Fecha:Date;
    ContactoUsuariosEntity:Usuario;
    IdObjeto:number;
    IdClase:number=Math.floor(Math.random() * (100000 - 0)) + 100000;
}