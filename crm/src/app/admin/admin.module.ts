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
import { AgendaFormComponent } from './components/agenda-form/agenda-form.component';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { AgendaListadoComponent } from './components/agenda-listado/agenda-listado.component';
import { UsuariosListadoComponent } from './components/usuarios-listado/usuarios-listado.component';
import { UsuariosFormComponent } from './components/usuarios-form/usuarios-form.component';
import { ConsultasFormComponent } from './components/consultas-form/consultas-form.component';
import { OrigenListadoComponent } from './components/origen-listado/origen-listado.component';
import { OrigenFormComponent } from './components/origen-form/origen-form.component';


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
    AgendaFormComponent,
    AgendaListadoComponent,
    UsuariosListadoComponent,
    UsuariosFormComponent,
    ConsultasFormComponent,
    OrigenListadoComponent,
    OrigenFormComponent,
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
    
    CalendarModule.forRoot({
      provide: DateAdapter,
      useFactory: adapterFactory,
    }),
    AgmCoreModule.forRoot({
      apiKey: 'AIzaSyCg8BmxqFCCKSEdoT7JQXXM5zDHqrIkx0g',
      libraries: ['places']
    })
  ],providers:[
    DatePipe
  ]
})
export class AdminModule { }
