import { ComponentFixture, TestBed } from '@angular/core/testing';

import { WomanIndexComponent } from './woman-index.component';

describe('WomanIndexComponent', () => {
  let component: WomanIndexComponent;
  let fixture: ComponentFixture<WomanIndexComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WomanIndexComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(WomanIndexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
