import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Contactos } from 'src/app/models/Contactos.model';
import { ContactosService } from 'src/app/services/contactos/contactos.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { environment } from 'src/environments/environment';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-contactos-listado',
  templateUrl: './contactos-listado.component.html',
  styleUrls: ['./contactos-listado.component.scss']
})
export class ContactosListadoComponent implements OnInit {

  ArrObj:Contactos[]=[];
  base=environment.assets;
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Contactos[]=[];
  strFiltro="";
  constructor(private srvObj:ContactosService,private srvShared:SharedService,private router:Router,private route:ActivatedRoute) {
    this.srvShared.Contacto=null;
    this.cargar()
  }

  cargar(){
    this.route.params.subscribe(val => {
      this.srvShared.ObjEdit=null;
      let mios:string=this.route.snapshot.params["accion"];
      console.log(mios);
      let b:boolean=false;
      if(mios!=undefined){
        b=true;
      }
      this.srvObj.todosAdmin(b).subscribe((lista)=>{
        this.OriginalArr=lista;
        this.collectionSize=this.OriginalArr.length;
        this.refreshData();
      })
    })
  }
  refreshData(){
    this.ArrObj=this.OriginalArr.slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);
  }
  Filtro(){
    
    this.ArrObj=this.OriginalArr.filter(obj => {
      const term = this.strFiltro.toLowerCase();
      return obj.Apellido.toLowerCase().includes(term) 
      || obj.Nombre.toLowerCase().includes(term) 
      || obj.Email.toLowerCase().includes(term)
      || obj.Telefono.toLowerCase().includes(term)
      || obj.Whatsapp.toLowerCase().includes(term)
          
    });
  }
  ngOnInit(): void {
  }
  Borrar(obj:Contactos){
    Swal.fire({
      title: "Atencion",
      text:"Esta seguro que desea borrar?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      /* Read more about isConfirmed, isDenied below */
      if (result.isConfirmed) {
        this.srvObj.Borrar(obj.IdContacto).subscribe((band)=>{
          if(band){
            this.cargar();
            Swal.fire("Ok","Se borro el registro",'success');

          }
        },(err)=>{
          this.cargar();
          Swal.fire("Upps",err.error.Message,'warning');
        })
      };
    });

  }

  Activar(obj:Contactos){
    Swal.fire({
      title: "Atencion",
      text:"Esta seguro que desea activar este registro?",
      icon:'warning',
      showDenyButton: true,
      confirmButtonText: 'Aceptar',
      denyButtonText: `Cancelar`,
    }).then((result) => {
      /* Read more about isConfirmed, isDenied below */
      if (result.isConfirmed) {
        this.srvObj.Activar(obj.IdContacto).subscribe((band)=>{
          if(band){
            this.cargar();
            Swal.fire("Ok","Se activo el registro",'success');

          }
        },(err)=>{
          this.cargar();
          Swal.fire("Upps",err.error.Message,'warning');
        })
      };
    });

  }
  Editar(obj:Contactos){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/contactosForm']);
  }

  

}
