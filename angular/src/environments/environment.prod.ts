import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AngularDotNetCore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44337',
    redirectUri: baseUrl,
    clientId: 'AngularDotNetCore_App',
    responseType: 'code',
    scope: 'offline_access AngularDotNetCore',
  },
  apis: {
    default: {
      url: 'https://localhost:44337',
      rootNamespace: 'AngularDotNetCore',
    },
  },
} as Environment;
