import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Productos } from 'src/app/models/productos.model';
import productos from 'src/assets/json/productos.json';

@Component({
  selector: 'app-productos',
  templateUrl: './productos.component.html',
  styleUrls: ['./productos.component.scss']
})
export class ProductosComponent implements OnInit {
  Fertilizantes: Productos[] =productos.prods.filter(p=>p.Tipo=='fertilizantes');
  Coadyuvantes: Productos[] =productos.prods.filter(p=>p.Tipo=='coadyuvantes');
  constructor() {
    
   }

  
  ngOnInit(): void {
  }

}
