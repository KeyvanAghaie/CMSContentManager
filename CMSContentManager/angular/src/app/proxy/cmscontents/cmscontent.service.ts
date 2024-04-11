import type { CMSContentDto, CreateUpdateCMSContentDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import type { PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class CMSContentService {
  apiName = 'Default';
  

  getAllByCancellationToken = (cancellationToken: any, config?: Partial<Rest.Config>) =>
    this.restService.request<any, PagedResultDto<CMSContentDto>>({
      method: 'GET',
      url: '/api/app/c-mSContent',
    },
    { apiName: this.apiName,...config });
  

  getCMSContentByIdAndCancellationToken = (id: string, cancellationToken: any, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CMSContentDto>({
      method: 'GET',
      url: `/api/app/c-mSContent/${id}/c-mSContent`,
    },
    { apiName: this.apiName,...config });
  

  insertOrUpdateCMSContentByInputAndCancellationToken = (input: CreateUpdateCMSContentDto, cancellationToken: any, config?: Partial<Rest.Config>) =>
    this.restService.request<any, CreateUpdateCMSContentDto>({
      method: 'POST',
      url: '/api/app/c-mSContent/or-update-cMSContent',
      body: input,
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
