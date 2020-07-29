import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { StudentsComponent } from './students/students.component';
import { OktaCallbackComponent, OKTA_CONFIG, OktaAuthModule, } from '@okta/okta-angular';
import { Routes, RouterModule } from '@angular/router';
import { AUTH } from './config';

const routes: Routes = [
  {
    path: 'implicit/callback',
    component: OktaCallbackComponent
  },
];

@NgModule({
  declarations: [
    AppComponent,
    StudentsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    OktaAuthModule
  ],
  providers: [
    { provide: OKTA_CONFIG, useValue: AUTH }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
