export class Direcciones{
    IdContactoDireccion:number;
    IdContacto:number;
    Nombre:string;
    Calle:string;
    Nro:string;
    Localidad:string;
    Provincia:string;
    Activo:boolean;
    Latitud:string;
    Longitud:string;
    Ubicacion:string;
    IdObjeto:number;
    IdClase:number=Math.floor(Math.random() * (100000 - 0)) + 100000;
}