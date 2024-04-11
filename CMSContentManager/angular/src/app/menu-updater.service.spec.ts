import { TestBed } from '@angular/core/testing';

import { MenuUpdaterService } from './menu-updater.service';

describe('MenuUpdaterService', () => {
  let service: MenuUpdaterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MenuUpdaterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
