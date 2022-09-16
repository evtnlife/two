import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateScheduleDto {
  description: string;
  scheduleDate: string;
}

export interface ScheduleDto extends AuditedEntityDto<string> {
  description?: string;
  scheduleDate?: string;
}
