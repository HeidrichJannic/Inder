import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ViewHeaderComponent } from './shared/components/view-header/view-header.component';
import { ViewFooterComponent } from './shared/components/view-footer/view-footer.component';

@NgModule({
  declarations: [
    AppComponent,
    ViewHeaderComponent,
    ViewFooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
