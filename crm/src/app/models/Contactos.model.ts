import { Acciones } from "./Acciones.model";
import { Asignaciones } from "./Asignaciones.model";
import { Direcciones } from "./Direcciones.model";
import { ContactosHistorialEstado } from "./HistorialEstado.model";

export class Contactos{
    IdContacto:number;
    Nombre:string;
    Apellido:string;
    Email:string;
    Telefono:string;
    FechaNacimiento:Date;
    Dni:string;
    Cuit:string;
    EstadoCivil:string;
    Whatsapp:string;
    Activo:boolean;
    Empresa:string;
    Profesion:string;
    Actividad:string;
    Facebook:string;
    Linkedin:string;
    Instagram:string;
    IdOrigen:number;
    Estados:ContactosHistorialEstado[]=[];
    Asignaciones:Asignaciones[]=[];
    Direcciones:Direcciones[]=[];
    Acciones:Acciones[]=[];
    
}