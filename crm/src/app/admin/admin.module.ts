import { NgModule } from '@angular/core';
import { CommonModule, DatePipe } from '@angular/common';
import { AdminRoutingModule } from './admin.routing';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PerfectScrollbarModule } from 'ngx-perfect-scrollbar';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AgmCoreModule } from '@agm/core';
import{TopComponent} from './shared/top/top.component'
import{MenuBarComponent} from './shared/menu-bar/menu-bar.component';
import { MainComponent } from './components/main/main.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { ContactosListadoComponent } from './components/contactos-listado/contactos-listado.component';
import { ContactosFormComponent } from './components/contactos-form/contactos-form.component';
import { DireccionesFormComponent } from './components/direcciones-form/direcciones-form.component';
import { AccionesFormComponent } from './components/acciones-form/acciones-form.component';
import { AsignacionesFormComponent } from './components/asignaciones-form/asignaciones-form.component';
import { EstadosFormComponent } from './components/estados-form/estados-form.component';


@NgModule({
  declarations: [
    TopComponent,
    MenuBarComponent,
    MainComponent,
    DashboardComponent,
    ContactosListadoComponent,
    ContactosFormComponent,
    DireccionesFormComponent,
    AccionesFormComponent,
    AsignacionesFormComponent,
    EstadosFormComponent,
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
    AgmCoreModule.forRoot({
      apiKey: '',
      libraries: ['places']
    })
  ],providers:[
    DatePipe
  ]
})
export class AdminModule { }
