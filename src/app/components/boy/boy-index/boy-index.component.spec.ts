import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BoyIndexComponent } from './boy-index.component';

describe('BoyIndexComponent', () => {
  let component: BoyIndexComponent;
  let fixture: ComponentFixture<BoyIndexComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BoyIndexComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BoyIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
