import { Component, OnInit } from '@angular/core';
import { Button } from "../button";
import { FormControl, FormGroup, ControlContainer } from '@angular/forms';

@Component({
  selector: 'app-select',
  templateUrl: './select.component.html',
  styleUrls: ['./select.component.scss']
})
export class SelectComponent implements OnInit {

  buttons: Button[] = [
    {
      name: "animals",
      value: true,
      displayValues: [
        "Lion", "Tiger", "Bear"
      ]
    },
    {
      name: "colors",
      value: false,
      displayValues: [
        "Red", "Blue", "Green"
      ]
    },
    {
      name: "days",
      value: false,
      displayValues: [
        "Friday", "Saturday", "Sunday"
      ]
    }
  ];

  form = new FormGroup({
    buttons: new FormControl("animals")
  });

  constructor() {

    this.form.get('buttons').valueChanges.subscribe(val => {

      for (let index in this.buttons) {

        if (this.buttons[index].name === val) {
          this.buttons[index].value = true;
        }

        else {
          this.buttons[index].value = false;
        }
      }
    })
  }

  ngOnInit(): void { }
}
