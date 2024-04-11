import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'ContentManager',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44361/',
    redirectUri: baseUrl,
    clientId: 'ContentManager_App',
    responseType: 'code',
    scope: 'offline_access ContentManager',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44361',
      rootNamespace: 'DTT.CMS.ContentManager',
    },
  },
} as Environment;
