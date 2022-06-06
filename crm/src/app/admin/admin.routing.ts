import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AgendaListadoComponent } from './components/agenda-listado/agenda-listado.component';
import { ContactosFormComponent } from './components/contactos-form/contactos-form.component';
import { ContactosListadoComponent } from './components/contactos-listado/contactos-listado.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { MainComponent } from './components/main/main.component';
import { OrigenListadoComponent } from './components/origen-listado/origen-listado.component';
import { UsuariosFormComponent } from './components/usuarios-form/usuarios-form.component';
import { UsuariosListadoComponent } from './components/usuarios-listado/usuarios-listado.component';

const routes: Routes = [
  {
    path: '',
    component: MainComponent,
    children:[
      {
        path: 'dashboard',
        component: DashboardComponent,
      },
      {
        path: 'contactos',
        component: ContactosListadoComponent,
      },
      {
        path: 'contactos/:accion',
        component: ContactosListadoComponent,
      },
      {
        path: 'contactosForm',
        component: ContactosFormComponent,
      },
      {
        path: 'Agenda',
        component: AgendaListadoComponent,
      },
      {
        path: 'usuarios',
        component: UsuariosListadoComponent,
      },
      {
        path: 'usuariosForm',
        component: UsuariosFormComponent,
      },
      {
        path: 'origenes',
        component: OrigenListadoComponent,
      },
      {
        path: 'origenesForm',
        component: OrigenListadoComponent,
      },

    ]
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
