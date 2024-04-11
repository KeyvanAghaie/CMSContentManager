import {
  ListService, PagedResultDto,   ABP, RouteGroup
} from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CMSContentDto, CMSContentService } from '@proxy/cmscontents';
import { Observable } from 'rxjs';
import { MenuUpdaterService } from '../menu-updater.service';

@Component({
  selector: 'app-cmscontent',
  templateUrl: './cmscontent.component.html',
  styleUrl: './cmscontent.component.scss',
  providers: [ListService],
})

export class CMSContentComponent implements OnInit {


  response = { items: [], totalCount: 0 } as PagedResultDto<CMSContentDto>;
  isModalOpen = false;
  form: FormGroup;
  
  columns = [{ prop: 'title' }];
  constructor(public readonly list: ListService,
    private cmsContentService: CMSContentService,
    private fb: FormBuilder,
    private menuUpdater: MenuUpdaterService
  ) { }
  ngOnInit(): void {
    const contentStreamCreator = (query) => this.cmsContentService.getAllByCancellationToken(query);
    this.list.hookToQuery(contentStreamCreator).subscribe((response) => {
      this.response = response;
    });
    //   this.updateMenu();
  }

  createContent() {
    this.buildForm();
    this.isModalOpen = true;
  }

  buildForm() {
    this.form = this.fb.group({
      title: ['', Validators.required],
      content: ['', [Validators.required, Validators.maxLength(1000)]],
    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    this.cmsContentService.insertOrUpdateCMSContentByInputAndCancellationToken(this.form.value, null).subscribe(res => {
      this.menuUpdater.updateTrigger.emit();
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }



}
