import { AuthService, ListResultDto, PagedAndSortedResultRequestDto } from '@abp/ng.core';
import { Component } from '@angular/core';
import { CreateUpdateScheduleDto, ScheduleDto, ScheduleService } from '@proxy/schedules';
import { OAuthService } from 'angular-oauth2-oidc';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent {

  scheduleList: ListResultDto<ScheduleDto>;
  showTab: string;
  itemToEdit: ScheduleDto;
  itemToEditStore: CreateUpdateScheduleDto = {} as CreateUpdateScheduleDto;
  get hasLoggedIn(): boolean {
    return this.oAuthService.hasValidAccessToken();
  }

  constructor(private oAuthService: OAuthService, private authService: AuthService, private scheduleService: ScheduleService)
  {
    this.showTab = "";
    this.scheduleService.getList(new PagedAndSortedResultRequestDto()).subscribe(x => {
      this.scheduleList = x;
      console.log(x);
    })
  }
  edit(schedule:ScheduleDto){
    this.showTab = "edit";
    this.itemToEdit = schedule;
    this.itemToEditStore.description = schedule.description;
    this.itemToEditStore.scheduleDate = schedule.scheduleDate;
    console.log(this.itemToEdit);
  }
  editStore(){
    this.scheduleService.update(this.itemToEdit.id, this.itemToEditStore).subscribe(x => {
      this.scheduleService.getList(new PagedAndSortedResultRequestDto()).subscribe(y => {
        this.scheduleList = y;
        console.log(y);
        this.itemToEdit = {};
        this.itemToEditStore = {} as CreateUpdateScheduleDto;
        this.showTab = "";
      });
    });
  }
  remove(id:string){
    this.scheduleService.delete(id).subscribe(x => {
      this.scheduleService.getList(new PagedAndSortedResultRequestDto()).subscribe(y => {
        this.scheduleList = y;
      });
    });
  }
  add(){
    this.showTab = "add";
    this.scheduleService.create(this.itemToEditStore).subscribe(x => {
      this.scheduleService.getList(new PagedAndSortedResultRequestDto()).subscribe(y => {
        this.scheduleList = y;
        this.showTab = "";
      });
    });
  }
  login() {
    this.authService.navigateToLogin();
  }
}
