import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { OverviewComponent } from './components/overview/overview.component';
import { ViewProfileComponent } from './components/view-profile/view-profile.component';
import { ViewErrorpageComponent } from './shared/components/view-errorpage/view-errorpage.component';

const routes: Routes = [
  {
    path: '',
    component: OverviewComponent
  },
  {
    path: 'profile',
    component: ViewProfileComponent
  },
  {
    path: '**',
    component: ViewErrorpageComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
