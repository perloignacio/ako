import { TestBed } from '@angular/core/testing';

import { OrigenesService } from './origenes.service';

describe('OrigenesService', () => {
  let service: OrigenesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OrigenesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
