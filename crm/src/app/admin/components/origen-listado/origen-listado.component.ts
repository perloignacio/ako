import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Origenes } from 'src/app/models/Origenes.model';
import { OrigenesService } from 'src/app/services/origenes/origenes.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-origen-listado',
  templateUrl: './origen-listado.component.html',
  styleUrls: ['./origen-listado.component.scss']
})
export class OrigenListadoComponent implements OnInit {

  ArrObj:Origenes[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Origenes[]=[];
  strFiltro="";
  constructor(private srvObj:OrigenesService,private srvShared:SharedService,private router:Router) {
    this.srvShared.Contacto=null;
    this.cargar()
  }

  cargar(){
    this.srvShared.ObjEdit=null;
    this.srvObj.todosAdmin().subscribe((lista)=>{
      this.OriginalArr=lista;
      this.collectionSize=this.OriginalArr.length;
      this.refreshData();
    })
  }
  refreshData(){
    this.ArrObj=this.OriginalArr.slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);
  }
  Filtro(){
    
    this.ArrObj=this.OriginalArr.filter(obj => {
      const term = this.strFiltro.toLowerCase();
      return obj.Nombre.toLowerCase().includes(term)     
    });
  }
  ngOnInit(): void {
  }
  Borrar(obj:Origenes){
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
        this.srvObj.Borrar(obj.IdOrigen).subscribe((band)=>{
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

  Activar(obj:Origenes){
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
        this.srvObj.Activar(obj.IdOrigen).subscribe((band)=>{
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
  Editar(obj:Origenes){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/origenesForm']);
  }

}
