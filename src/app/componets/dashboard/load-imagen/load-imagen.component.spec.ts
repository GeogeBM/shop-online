import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LoadImagenComponent } from './load-imagen.component';

describe('LoadImagenComponent', () => {
  let component: LoadImagenComponent;
  let fixture: ComponentFixture<LoadImagenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LoadImagenComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoadImagenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
