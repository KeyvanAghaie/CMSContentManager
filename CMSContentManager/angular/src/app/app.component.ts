import { Component, OnInit } from '@angular/core';
import { RoutesService, eLayoutType } from '@abp/ng.core';
import { CMSContentService } from '@proxy/cmscontents';
import { MenuUpdaterService } from './menu-updater.service';

@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar></abp-loader-bar>
    <abp-dynamic-layout></abp-dynamic-layout>
    <abp-internet-status></abp-internet-status>
  `,
})
export class AppComponent implements OnInit {

  constructor(private routes: RoutesService,
    private cmsContentService: CMSContentService,
    private updater: MenuUpdaterService
  ) {

  }
  menuUpdater() {
    this.cmsContentService.getAllByCancellationToken(null).subscribe(res => {
      let order = 0;
      res?.items?.filter(Boolean).forEach(it => {
     
        this.routes.add([ 
          {
            name: it.title,
            path: `/CMSContents/${it.id}/view`,
            parentName: '::CMS Content Pages',
            order,
            layout: eLayoutType.application,
          }]
        )
        order++;
      });
    });
  }
  ngOnInit() {
    this.menuUpdater()
    this.updater.updateTrigger.subscribe(() => this.menuUpdater())
  }
}
