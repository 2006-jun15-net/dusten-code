import { TestBed } from '@angular/core/testing';

import { HighlightColorService } from './highlight-color.service';

describe('HighlightColorService', () => {
  let service: HighlightColorService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HighlightColorService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
