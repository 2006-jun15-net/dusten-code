import { Component, OnInit } from '@angular/core';
import { HighlightColorService } from './highlight-color.service';

@Component({
  selector: 'app-highlight',
  templateUrl: './highlight.component.html',
  styleUrls: ['./highlight.component.scss']
})
export class HighlightComponent implements OnInit {

  text = "Hello, world!";
  highlightColor = 'blue';

  constructor(service: HighlightColorService) {
    document.documentElement.style.setProperty('--highlight-color', service.getColor());
  }

  ngOnInit(): void {
  }

}
