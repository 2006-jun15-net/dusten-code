import { Component, OnInit } from '@angular/core';
import { OktaAuthService } from '@okta/okta-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.scss']
})
export class StudentsComponent implements OnInit {

  response: string;

  constructor(public oktaAuth: OktaAuthService, private http: HttpClient) {
    this.response = "";
  }

  ngOnInit(): void { }

  async click() {

    const accessToken = await this.oktaAuth.getAccessToken();

    this.http.get("http://localhost:47144/api/student/1", {
      headers: {
        Authorization: 'Bearer ' + accessToken
      },
      withCredentials: true
    }).toPromise().then(response =>
      this.response = JSON.stringify(response)
    ).catch(error => {
      this.oktaAuth.loginRedirect('/');
      // this.response = JSON.stringify(error);
    });

    /*
    fetch("http://localhost:47144/api/student/1",
      {
        method: "GET",
        headers: {
          Authorization: 'Bearer ' + accessToken
        },
        credentials: "include"
      })
      .then(response => 
        this.response = JSON.stringify(response)
      )
      .catch(error => 
        this.response = JSON.stringify(error)
      );*/
  }
}
