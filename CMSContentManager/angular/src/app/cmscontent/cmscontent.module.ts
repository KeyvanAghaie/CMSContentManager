import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CMSContentRoutingModule } from './cmscontent-routing.module';
import { CMSContentComponent } from './cmscontent.component';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    CMSContentComponent,
  ],
  imports: [
    CommonModule,
    ThemeSharedModule,
    CMSContentRoutingModule,
    ReactiveFormsModule
  ]
})
export class CMSContentModule { }
