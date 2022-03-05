import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OtherStyleComponent } from './other-style.component';

describe('OtherStyleComponent', () => {
  let component: OtherStyleComponent;
  let fixture: ComponentFixture<OtherStyleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OtherStyleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OtherStyleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
