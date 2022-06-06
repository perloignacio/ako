import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationService } from 'src/app/services/authentication/authentication.service';

@Component({
  selector: 'app-top',
  templateUrl: './top.component.html',
  styleUrls: ['./top.component.css']
})
export class TopComponent implements OnInit {
  public isActive: any;
  constructor(private srvAut:AuthenticationService,private route:Router) { }
  Salir(){
    this.srvAut.logout();
    this.route.navigate(["/login"])
  }
  ngOnInit(): void {
  }

}
