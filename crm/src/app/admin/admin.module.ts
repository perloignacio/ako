import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { AdminRoutingModule } from './admin.routing';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import{TopComponent} from './shared/top/top.component'
import{MenuBarComponent} from './shared/menu-bar/menu-bar.component';
import { MainComponent } from './components/main/main.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { ContactosListadoComponent } from './components/contactos-listado/contactos-listado.component';
import { ContactosFormComponent } from './components/contactos-form/contactos-form.component';


@NgModule({
  declarations: [
    TopComponent,
    MenuBarComponent,
    MainComponent,
    DashboardComponent,
    ContactosListadoComponent,
    ContactosFormComponent,
  ],
  exports:[
    MainComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    AdminRoutingModule,
    NgbModule,
    PerfectScrollbarModule,
    FormsModule,
    ReactiveFormsModule,
  ],providers:[
    DatePipe
  ]
})
export class AdminModule { }
