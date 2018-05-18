import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MeetingsComponent } from './meetings-overview/meetings-overview.component';
import { extract } from '../../core/services/i18n.service';
import { MeetingNewComponent } from './meeting-new/meeting-new.component';

const routes: Routes = [
  { path: '', component: MeetingsComponent, data: { title: extract('Meetings') } },
  { path: 'new', component: MeetingNewComponent },
  { path: 'edit/:id', component: MeetingNewComponent},
  { path: 'delete/:id', component: MeetingNewComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MeetingsRoutingModule { }
