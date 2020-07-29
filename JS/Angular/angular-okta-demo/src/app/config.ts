// Change this to the base URL of your API
export const API_ORIGIN = "https://ar-dk-ps-project2.azurewebsites.net";

// This should be passed to every request that requires authorization
// (for the [Authorize] annotation in ASP.NET Core)
export function API_OPTIONS(accessToken) {

	return {
		headers: {
			Authorization: 'Bearer ' + accessToken
		},
		withCredentials: true
	}
}

// Okta configurations:
export const AUTH = {

	// This should be changed to match your Okta domain
	issuer: 'https://dev-638266.okta.com/oauth2/default',
	redirectUri: location.origin + '/implicit/callback',
	// Change this to your application's Client ID
	clientId: '0oan3a2afYLWJgufo4x6',
	pkce: true
}