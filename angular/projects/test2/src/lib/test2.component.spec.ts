import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';
import { test2Component } from './components/test2.component';
import { test2Service } from '@test2';
import { of } from 'rxjs';

describe('test2Component', () => {
  let component: test2Component;
  let fixture: ComponentFixture<test2Component>;
  const mocktest2Service = jasmine.createSpyObj('test2Service', {
    sample: of([]),
  });
  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [test2Component],
      providers: [
        {
          provide: test2Service,
          useValue: mocktest2Service,
        },
      ],
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(test2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
