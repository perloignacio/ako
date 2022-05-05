import { Contactos } from "./Contactos.model";
import { Usuario } from "./Usuario.model";

export class Agenda{
    IdContactoAgenda:number;
    Fecha:Date;
    FechaDesde:Date;
    FechaHasta:Date;
    Desde:number;
    Hasta:number;
    Asunto:string;
    Descripcion:string; 
    Link:string;
    IdContacto:number;
    IdUsuario:number;
    ContactosEntity?:Contactos;
    ContactoUsuariosEntity:Usuario;
    Activo:boolean;
}