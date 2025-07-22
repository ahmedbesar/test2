import { TestBed } from '@angular/core/testing';
import { test2Service } from './services/test2.service';
import { RestService } from '@abp/ng.core';

describe('test2Service', () => {
  let service: test2Service;
  const mockRestService = jasmine.createSpyObj('RestService', ['request']);
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: RestService,
          useValue: mockRestService,
        },
      ],
    });
    service = TestBed.inject(test2Service);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
