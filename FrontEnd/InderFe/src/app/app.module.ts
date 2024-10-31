import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ViewHeaderComponent } from './shared/components/view-header/view-header.component';
import { ViewFooterComponent } from './shared/components/view-footer/view-footer.component';
import { OverviewComponent } from './components/overview/overview.component';
import { UserService } from './shared/services/user.service';
import { HttpClientModule } from '@angular/common/http';
import { ViewProfileComponent } from './components/view-profile/view-profile.component';

@NgModule({
  declarations: [
    AppComponent,
    OverviewComponent,
    ViewHeaderComponent,
    ViewFooterComponent,
    ViewProfileComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [UserService],
  bootstrap: [AppComponent]
})
export class AppModule { }
