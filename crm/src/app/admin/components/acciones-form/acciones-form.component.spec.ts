import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AccionesFormComponent } from './acciones-form.component';

describe('AccionesFormComponent', () => {
  let component: AccionesFormComponent;
  let fixture: ComponentFixture<AccionesFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AccionesFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AccionesFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
