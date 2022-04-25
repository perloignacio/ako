import { Contactos } from "./Contactos.model";
import { Estados } from "./Estados.model";
import { Usuario } from "./Usuario.model";

export class ContactosHistorialEstado{
    IdHistorialEstadoContacto:number;
    IdEstadoContacto:number;
    IdContacto:number;
    IdUsuarioContacto:number;
    Fecha:Date;
    ContactosEntity:Contactos;
    ContactosEstadosEntity:Estados;
    ContactoUsuariosEntity:Usuario;
    IdObjeto:number;
    IdClase:number=Math.floor(Math.random() * (100000 - 0)) + 100000;
}