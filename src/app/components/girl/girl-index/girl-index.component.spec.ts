import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GirlIndexComponent } from './girl-index.component';

describe('GirlIndexComponent', () => {
  let component: GirlIndexComponent;
  let fixture: ComponentFixture<GirlIndexComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GirlIndexComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GirlIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
