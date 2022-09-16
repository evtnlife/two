import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'TWO',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44350',
    redirectUri: baseUrl,
    clientId: 'TWO_App',
    responseType: 'code',
    scope: 'offline_access TWO',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44350',
      rootNamespace: 'TWO',
    },
  },
} as Environment;
