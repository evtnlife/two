import type { CreateUpdateScheduleDto, ScheduleDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ScheduleService {
  apiName = 'Default';

  create = (input: CreateUpdateScheduleDto) =>
    this.restService.request<any, ScheduleDto>({
      method: 'POST',
      url: '/api/app/schedule',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/schedule/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, ScheduleDto>({
      method: 'GET',
      url: `/api/app/schedule/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ScheduleDto>>({
      method: 'GET',
      url: '/api/app/schedule',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateUpdateScheduleDto) =>
    this.restService.request<any, ScheduleDto>({
      method: 'PUT',
      url: `/api/app/schedule/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
