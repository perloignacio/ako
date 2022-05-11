import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { CalculosComponent } from './components/calculos/calculos.component';
import { FichaComponent } from './components/ficha/ficha.component';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { ProductosComponent } from './components/productos/productos.component';
import { AuthGuardService } from './services/AuthGuard/auth-guard.service';

const routes: Routes = [
  {
    path:'',
    pathMatch:'full',
    component:LoginComponent,
    canLoad: [ AuthGuardService ],
    canActivate:[AuthGuardService],
  },
  {
    path:'home',
    pathMatch:'full',
    component:HomeComponent,
    canLoad: [ AuthGuardService ],
    canActivate:[AuthGuardService],
  },
  
  {
    path:'ingresar',
    pathMatch:'full',
    component:LoginComponent,
    
  },
  {
    path:'calculos',
    pathMatch:'full',
    component:CalculosComponent,
    canLoad: [ AuthGuardService ],
    canActivate:[AuthGuardService],
  },
  {
    path:'productos',
    pathMatch:'full',
    component:ProductosComponent,
    canLoad: [ AuthGuardService ],
    canActivate:[AuthGuardService],
  },
  {
    path:'ficha/:id',
    pathMatch:'full',
    component:FichaComponent,
    canLoad: [ AuthGuardService ],
    canActivate:[AuthGuardService],
  },
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
