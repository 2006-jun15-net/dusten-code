import { Component, OnInit } from '@angular/core';
import { User } from "../user"

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent implements OnInit {

  users: User[] = [
    { id: 1, name: "John Smith", visible: true },
    { id: 2, name: "Thomas Anderson", visible: true }
  ];

  constructor() { }

  ngOnInit(): void { }
}
