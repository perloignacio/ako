import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, Route, Router, RouterStateSnapshot } from '@angular/router';
import { SharedService } from '../shared/shared.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardService {

  constructor(private svcShared:SharedService,private router:Router) { }
  canLoad(route: Route): boolean {
    

    if (this.svcShared.usuario!=undefined) {
	    return true;
    }else{
      this.router.navigate([ '/ingresar']);
      return false;
    }

  }

  canActivate(route: ActivatedRouteSnapshot,state: RouterStateSnapshot): boolean {
    let url: string = state.url;

    if (this.svcShared.usuario!=undefined) {
	    return true;
    }else{
      this.router.navigate([ '/ingresar']);
      return false;
    }

  }
}
