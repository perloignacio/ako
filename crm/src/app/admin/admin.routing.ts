import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactosFormComponent } from './components/contactos-form/contactos-form.component';
import { ContactosListadoComponent } from './components/contactos-listado/contactos-listado.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { MainComponent } from './components/main/main.component';

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
        path: 'contactosForm',
        component: ContactosFormComponent,
      }

    ]
  }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
