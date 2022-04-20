import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContactosListadoComponent } from './contactos-listado.component';

describe('ContactosListadoComponent', () => {
  let component: ContactosListadoComponent;
  let fixture: ComponentFixture<ContactosListadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ContactosListadoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ContactosListadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
