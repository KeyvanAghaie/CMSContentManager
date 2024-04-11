import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CMSContentComponent } from './cmscontent.component';

describe('CMSContentComponent', () => {
  let component: CMSContentComponent;
  let fixture: ComponentFixture<CMSContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CMSContentComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CMSContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
