import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuario } from 'src/app/models/Usuario.model';
import { SharedService } from 'src/app/services/shared/shared.service';
import { UsuariosService } from 'src/app/services/usuarios/usuarios.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-usuarios-listado',
  templateUrl: './usuarios-listado.component.html',
  styleUrls: ['./usuarios-listado.component.scss']
})
export class UsuariosListadoComponent implements OnInit {

  ArrObj:Usuario[]=[];
  page = 1;
  pageSize = 10;
  collectionSize = 0
  OriginalArr:Usuario[]=[];
  strFiltro="";
  constructor(private srvObj:UsuariosService,private srvShared:SharedService,private router:Router) {
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
      return obj.Apellido.toLowerCase().includes(term) 
      || obj.Nombre.toLowerCase().includes(term) 
      || obj.Email.toLowerCase().includes(term)
      || obj.Telefono.toLowerCase().includes(term)
      || obj.ContactosTipoUsuarioEntity.Nombre.toLowerCase().includes(term)
          
    });
  }
  ngOnInit(): void {
  }
  Borrar(obj:Usuario){
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
        this.srvObj.Borrar(obj.IdUsuario).subscribe((band)=>{
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

  Activar(obj:Usuario){
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
        this.srvObj.Activar(obj.IdUsuario).subscribe((band)=>{
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
  Editar(obj:Usuario){
    this.srvShared.ObjEdit=obj;
    this.router.navigate(['admin/usuariosForm']);
  }

}
