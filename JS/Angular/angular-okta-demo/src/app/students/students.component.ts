import { Component, OnInit } from '@angular/core';
import { OktaAuthService } from '@okta/okta-angular';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { API_ORIGIN, API_OPTIONS } from '../config';

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

    this.http.get(`${API_ORIGIN}/api/student/1`, API_OPTIONS(accessToken))
      .subscribe(

        value => this.response = JSON.stringify(value),

        (error: HttpErrorResponse) => {

          if (error.status == 401) {

            // Unauthorized, redirect to login screen
            this.oktaAuth.loginRedirect('/');
          }
          this.response = JSON.stringify(error);
        }
      )
  }
}
