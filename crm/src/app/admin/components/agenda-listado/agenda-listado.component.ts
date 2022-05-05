import { Component, OnInit, TemplateRef, ViewChild } from '@angular/core';
import {startOfDay,endOfDay,subDays,addDays,endOfMonth,isSameDay,isSameMonth,addHours,} from 'date-fns';
import { Subject } from 'rxjs';
import {CalendarEvent,CalendarEventAction,CalendarEventTimesChangedEvent,CalendarView,} from 'angular-calendar';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AgendaService } from 'src/app/services/agenda/agenda.service';
import { DatePipe } from '@angular/common';
import * as moment from 'moment';
import { Agenda } from 'src/app/models/Agenda.model';
import { AgendaFormComponent } from '../agenda-form/agenda-form.component';
import { SharedService } from 'src/app/services/shared/shared.service';
import Swal from 'sweetalert2';

const colors: any = {
  red: {
    primary: '#ad2121',
    secondary: '#FAE3E3',
  },
  blue: {
    primary: '#1e90ff',
    secondary: '#D1E8FF',
  },
  yellow: {
    primary: '#e3bc08',
    secondary: '#FDF1BA',
  },
};
@Component({
  selector: 'app-agenda-listado',
  templateUrl: './agenda-listado.component.html',
  styleUrls: ['./agenda-listado.component.scss']
})
export class AgendaListadoComponent implements OnInit {

  
  view: CalendarView = CalendarView.Month;
  CalendarView = CalendarView;
  viewDate: Date = new Date();
  nEvento:Agenda=new Agenda();
  Eventos:Agenda[]=[];
  ngOnInit(): void {

  }
  actions: CalendarEventAction[] = [
    {
      label: '<i class="fas fa-fw fa-pencil-alt"></i>',
      a11yLabel: 'Modificar',
      onClick: ({ event }: { event: CalendarEvent }): void => {
        this.handleEvent('Edited', event);
      },
    },
    {
      label: '<i class="fas fa-fw fa-trash-alt"></i>',
      a11yLabel: 'Borrar',
      onClick: ({ event }: { event: CalendarEvent }): void => {
        
        this.deleteEvent(event);
      },
    },
  ];

  refresh = new Subject<void>();
  events: CalendarEvent[] = []
  activeDayIsOpen: boolean = true;

  constructor(private modal: NgbModal,private srvAgenda:AgendaService,private srvShared:SharedService) {
    this.cargadatos()  
  }

  cargadatos(){
    this.events=[];
    this.srvAgenda.GetEventos().subscribe((el)=>{
      this.Eventos=el;
      el.forEach((ev)=>{
        let desde: moment.Moment = moment(ev.FechaDesde);
        let hasta: moment.Moment = moment(ev.FechaHasta);
        
        let e:CalendarEvent={
          id:ev.IdContactoAgenda,
          
          start: new Date(desde.format("LLLL")),
          end: new Date(hasta.format("LLLL")),
          title: ev.Asunto,
          color: colors.red,
          actions: this.actions,
        }
       
        this.events.push(e);
      })
      
      this.refresh.next();
    })
  }
  dayClicked({ date, events }: { date: Date; events: CalendarEvent[] }): void {
    if (isSameMonth(date, this.viewDate)) {
      if (
        (isSameDay(this.viewDate, date) && this.activeDayIsOpen === true) ||
        events.length === 0
      ) {
        this.activeDayIsOpen = false;
      } else {
        this.activeDayIsOpen = true;
      }
      this.viewDate = date;
    }
  }

  

  nuevo(){
    this.srvShared.objModal=null;
    this.abremodal();
  }
  handleEvent(action: string, event: CalendarEvent): void {
    this.srvShared.objModal=this.Eventos.find((e)=>e.IdContactoAgenda==event.id);
    this.abremodal();
  }
  abremodal(){
    this.modal.open(AgendaFormComponent, { size: 'lg' }).result.then((result) => {
      this.cargadatos()
       /* To subscribe data from Modal */

      }, (reason)=>{ 
      
        /*Leave empty or handle reject*/

      });
   
     
  }
 

  deleteEvent(eventToDelete: CalendarEvent) {
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
        let ev=this.Eventos.find((e)=>e.IdContactoAgenda==eventToDelete.id)
        this.srvAgenda.Borrar(ev.IdContactoAgenda).subscribe((band)=>{
          if(band){
            this.cargadatos();
            Swal.fire("Ok","Se borro el registro",'success');

          }
        },(err)=>{
          this.cargadatos();
          Swal.fire("Upps",err.error.Message,'warning');
        })
      };
    });
    
  }

  setView(view: CalendarView) {
    this.view = view;
  }

  closeOpenMonthViewDay() {
    this.activeDayIsOpen = false;
  }



}
