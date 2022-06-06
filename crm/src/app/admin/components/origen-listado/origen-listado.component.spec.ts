import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OrigenListadoComponent } from './origen-listado.component';

describe('OrigenListadoComponent', () => {
  let component: OrigenListadoComponent;
  let fixture: ComponentFixture<OrigenListadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OrigenListadoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OrigenListadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
