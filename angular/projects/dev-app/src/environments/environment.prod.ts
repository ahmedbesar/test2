import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'test2',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44359/',
    redirectUri: baseUrl,
    clientId: 'test2_App',
    responseType: 'code',
    scope: 'offline_access test2',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44359',
      rootNamespace: 'test2',
    },
    test2: {
      url: 'https://localhost:44379',
      rootNamespace: 'test2',
    },
  },
} as Environment;
