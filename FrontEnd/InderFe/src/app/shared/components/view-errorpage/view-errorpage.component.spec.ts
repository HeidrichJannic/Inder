import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewErrorpageComponent } from './view-errorpage.component';

describe('ViewErrorpageComponent', () => {
  let component: ViewErrorpageComponent;
  let fixture: ComponentFixture<ViewErrorpageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ViewErrorpageComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ViewErrorpageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
