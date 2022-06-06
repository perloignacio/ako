import { Component, Input, OnInit } from '@angular/core';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { Agenda } from 'src/app/models/Agenda.model';
import { Contactos } from 'src/app/models/Contactos.model';
import { AgendaService } from 'src/app/services/agenda/agenda.service';
import { ContactosService } from 'src/app/services/contactos/contactos.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-agenda-form',
  templateUrl: './agenda-form.component.html',
  styleUrls: ['./agenda-form.component.scss']
})
export class AgendaFormComponent implements OnInit {
  
  Agregar:boolean=true;
  obj:Agenda=new Agenda;
  Contactos:Contactos[]=[];
  constructor(private srvContacto:ContactosService,private srvObj:AgendaService,private srvShared:SharedService,private activemodal:NgbActiveModal) { 
    this.srvContacto.todoActivos().subscribe((cl)=>{
      this.Contactos=cl;
      if(this.srvShared.objModal as Agenda!=null){
        this.Agregar=false;
        this.obj=this.srvShared.objModal;
        console.log(this.obj);
      }
    })
    

  }
  
  ngOnInit(): void {
  }

  Guardar(){
    const form=new FormData();
    if(!this.Agregar){
      form.append("id",this.obj.IdContactoAgenda.toString());
    }else{
      form.append("id","0");
    }
    

    form.append("obj",this.srvShared.convertToJSON(this.obj).objeto);
    this.srvObj.AgregarEditar(form).subscribe((band)=>{
      if(band){

        Swal.fire("Ok","La operación se realizo con exito",'success');
        this.activemodal.close(true);
      }
    },(err)=>{

      Swal.fire("Upps",err.error.Message,'warning');
    })
  }

  Volver(){

  }

}
