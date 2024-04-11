import type { AuditedEntityDto } from '@abp/ng.core';

export interface CMSContentDto extends AuditedEntityDto<string> {
  title: string;
  content: string;
}

export interface CreateUpdateCMSContentDto {
  id?: string;
  title: string;
  content: string;
}
