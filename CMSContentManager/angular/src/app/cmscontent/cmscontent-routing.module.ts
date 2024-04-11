import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CMSContentComponent } from './cmscontent.component';
import { ViewComponent } from './view/view.component';

const routes: Routes = [
  { path: '', component: CMSContentComponent },
  { path: ':id/view', component: ViewComponent },
  

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CMSContentRoutingModule { }
