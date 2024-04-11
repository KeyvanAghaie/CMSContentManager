import { RoutesService, eLayoutType } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  { provide: APP_INITIALIZER, useFactory: configureRoutes, deps: [RoutesService], multi: true },
];

function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/',
        name: '::Menu:Home',
        iconClass: 'fas fa-home',
        order: 1,
        layout: eLayoutType.application,
      },
      {
        path: '/CMS-Content',
        name: '::CMSContents',
        iconClass: 'fas fa-content',
        order: 2,
        layout: eLayoutType.application,
      },
      {
        path: '/CMSContents',
        name: '::Contents',
        parentName: '::CMSContents',
        layout: eLayoutType.application,
      } 
      
    ]);
  };
}
