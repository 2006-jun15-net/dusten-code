import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class HighlightColorService {

  getColor() { return 'blue'; }
}
