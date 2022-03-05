import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManIndexComponent } from './man-index.component';

describe('ManIndexComponent', () => {
  let component: ManIndexComponent;
  let fixture: ComponentFixture<ManIndexComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManIndexComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
