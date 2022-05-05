import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgendaListadoComponent } from './agenda-listado.component';

describe('AgendaListadoComponent', () => {
  let component: AgendaListadoComponent;
  let fixture: ComponentFixture<AgendaListadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AgendaListadoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AgendaListadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
