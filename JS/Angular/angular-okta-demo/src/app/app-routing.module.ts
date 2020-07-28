import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { OktaCallbackComponent, OKTA_CONFIG, } from '@okta/okta-angular';

const config =
{
  onAuthRequired: ({ oktaAuth, router }) => {
    router.navigate(['/']);
  },
  issuer: 'https://dev-638266.okta.com/oauth2/default',
  redirectUri: 'http://localhost:4200/implicit/callback', //'http://localhost:4200/002-PUop-Zi33w850kleFnIUXVvNy2Vpx_4M7XTBBU/callback',
  clientId: '0oan3a2afYLWJgufo4x6',
  pkce: true
};

const routes: Routes = [
  {
    path: 'implicit/callback', //'002-PUop-Zi33w850kleFnIUXVvNy2Vpx_4M7XTBBU/callback',
    component: OktaCallbackComponent
  },
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule],
  providers: [
    { provide: OKTA_CONFIG, useValue: config }
  ]
})
export class AppRoutingModule { }
