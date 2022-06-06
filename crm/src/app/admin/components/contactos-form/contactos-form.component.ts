import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ModalDismissReasons, NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { Acciones } from 'src/app/models/Acciones.model';
import { Asignaciones } from 'src/app/models/Asignaciones.model';
import { Contactos } from 'src/app/models/Contactos.model';
import { correccion } from 'src/app/models/correcion.model';
import { Direcciones } from 'src/app/models/Direcciones.model';
import { Estados } from 'src/app/models/Estados.model';
import { glifosato } from 'src/app/models/glifosato.mode';
import { ContactosHistorialEstado } from 'src/app/models/HistorialEstado.model';
import { home } from 'src/app/models/Home.model';
import { Origenes } from 'src/app/models/Origenes.model';
import { ContactosService } from 'src/app/services/contactos/contactos.service';
import { OrigenesService } from 'src/app/services/origenes/origenes.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { environment } from 'src/environments/environment';
import Swal from 'sweetalert2';
import { AccionesFormComponent } from '../acciones-form/acciones-form.component';
import { AsignacionesFormComponent } from '../asignaciones-form/asignaciones-form.component';
import { ConsultasFormComponent } from '../consultas-form/consultas-form.component';
import { DireccionesFormComponent } from '../direcciones-form/direcciones-form.component';
import { EstadosFormComponent } from '../estados-form/estados-form.component';

@Component({
  selector: 'app-contactos-form',
  templateUrl: './contactos-form.component.html',
  styleUrls: ['./contactos-form.component.scss']
})
export class ContactosFormComponent implements OnInit {
  Direcciones:Direcciones[]=[]
  Acciones:Acciones[]=[];
  Origenes:Origenes[]=[];
  Estados:ContactosHistorialEstado[]=[];
  Asignaciones:Asignaciones[]=[];
  obj:Contactos=new Contactos();
  Agregar:boolean=true;
  base=environment.assets;
  constructor(private srvShared:SharedService,private srvObj:ContactosService,private route:Router,private modalService:NgbModal,private srvOrigenes:OrigenesService) {
    this.srvOrigenes.tipos().subscribe((ol)=>{
      this.Origenes=ol;
      this.obj=this.srvShared.ObjEdit as Contactos;
      if(this.obj!=null){
        this.Agregar=false;
        this.Direcciones=this.obj.Direcciones;
        this.Acciones=this.obj.Acciones;
        this.Asignaciones=this.obj.Asignaciones;
        this.Estados=this.obj.Estados;
        this.obj.Home=[];
        this.obj.Consultas.forEach((c)=>{
          let h=new home();
          
          h.fecha=c.Fecha;
          h.glifosato=new glifosato();
          h.glifosato.volumen=c.Gli_volumen
          h.glifosato.dureza=c.Gli_dureza
          h.glifosato.costo=c.Gli_costo
          h.glifosato.dosis=c.Gli_dosis
          h.glifosato.porinactivacion=c.Gli_porinactivacion
          h.glifosato.valinactivacion=c.Gli_valinactivacion
          h.glifosato.perdida=c.Gli_perdida
          h.glifosato.villaseca=c.Gli_villaseca
          h.correccion=new correccion();
          h.correccion.volumen=c.Corr_volumen
          h.correccion.litros=c.Corr_litros
          h.correccion.cantidad=c.Corr_cantidad
          h.correccion.costoeco=c.Corr_costoeco
          h.correccion.hectareas=c.Corr_hectareas
          h.correccion.canthec=c.Corr_canthec
          h.correccion.costohec=c.Corr_costohec
          h.totalesta=c.totalesta
          h.totalako=c.totalako
          this.obj.Home.push(h);
        })
      }else{
        this.obj=new Contactos();
      }
    })
      


  }

  BorrarDir(objParam:Direcciones){

  }
  
  
  BorrarAccion(objParam:Acciones){

  }
  
  AbrirDireccion(objParam:Direcciones){
    this.srvShared.objModal=null;
    if(objParam!=null){
      this.srvShared.objModal=objParam;
    }
    this.modalService.open(DireccionesFormComponent, {size:'lg'}).result.then((result) => {
     if(result!=null){
      let objAux=result as Direcciones;
      if(objParam!=null){
        this.Direcciones[this.Direcciones.findIndex(o=>o.IdContactoDireccion==objAux.IdContactoDireccion)]=objAux;
      }else{
        this.Direcciones.push(objAux)
      }
      
     } 
    });
  }

  AbrirAccion(objParam:Acciones){
    this.srvShared.objModal=null;
    if(objParam!=null){
      this.srvShared.objModal=objParam;
    }
    this.modalService.open(AccionesFormComponent, {size:'lg'}).result.then((result) => {
     if(result!=null){
      let objAux=result as Acciones;
      if(objParam!=null){
        this.Acciones[this.Acciones.findIndex(o=>o.IdHistorialAcciones==objAux.IdHistorialAcciones)]=objAux;
      }else{
        this.Acciones.push(objAux)
      }
      
     } 
    });
  }

  AbrirConsulta(objHome:home){
    this.srvShared.objModal=null;
    if(objHome!=null){
      this.srvShared.objModal=objHome;
    }
    this.modalService.open(ConsultasFormComponent, {size:'lg'}).result.then((result) => {
     
    });
  }

  AbrirAsignacion(objParam:Asignaciones){
    this.srvShared.objModal=null;
    if(objParam!=null){
      this.srvShared.objModal=objParam;
    }
    this.modalService.open(AsignacionesFormComponent, {size:'lg'}).result.then((result) => {
     if(result!=null){
      let objAux=result as Asignaciones;
      if(objParam!=null){
        this.Asignaciones[this.Asignaciones.findIndex(o=>o.IdHistorialAsignacionesContacto==objAux.IdHistorialAsignacionesContacto)]=objAux;
      }else{
        this.Asignaciones.push(objAux)
      }
      
     } 
    });
  }

  AbrirEstados(objParam:ContactosHistorialEstado){
    this.srvShared.objModal=null;
    if(objParam!=null){
      this.srvShared.objModal=objParam;
    }
    this.modalService.open(EstadosFormComponent, {size:'lg'}).result.then((result) => {
     if(result!=null){
      let objAux=result as ContactosHistorialEstado;
      if(objParam!=null){
        this.Estados[this.Estados.findIndex(o=>o.IdClase==objAux.IdClase)]=objAux;
      }else{
        this.Estados.push(objAux)
      }
      
      
     } 
    });
  }
  
  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }

  Guardar(){
    const form=new FormData();
    if(!this.Agregar){
      form.append("id",this.obj.IdContacto.toString());
    }else{
      form.append("id","0");
    }
    this.Estados.forEach((e)=>e.IdObjeto=e.IdHistorialEstadoContacto);
    this.Direcciones.forEach((e)=>e.IdObjeto=e.IdContactoDireccion);
    this.Asignaciones.forEach((e)=>e.IdObjeto=e.IdHistorialAsignacionesContacto);
    this.Acciones.forEach((e)=>e.IdObjeto=e.IdHistorialAcciones);

    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    form.append("estados",this.srvShared.convertToJSON(this.Estados).objeto);
    form.append("direcciones",this.srvShared.convertToJSON(this.Direcciones).objeto);
    form.append("asignaciones",this.srvShared.convertToJSON(this.Asignaciones).objeto);
    form.append("acciones",this.srvShared.convertToJSON(this.Acciones).objeto);
    this.srvObj.AgregarEditar(form).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizo con exito",'success');
        this.route.navigate(['admin/clientes'])
      }
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
  }
  ngOnInit(): void {
  }
  Volver(){
    history.back();
  }

}
