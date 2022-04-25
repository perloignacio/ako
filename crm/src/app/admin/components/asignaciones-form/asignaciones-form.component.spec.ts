import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AsignacionesFormComponent } from './asignaciones-form.component';

describe('AsignacionesFormComponent', () => {
  let component: AsignacionesFormComponent;
  let fixture: ComponentFixture<AsignacionesFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AsignacionesFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AsignacionesFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
