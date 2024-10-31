import { Component } from '@angular/core';
import { ViewHeaderComponent } from './shared/components/view-header/view-header.component';
import { ViewFooterComponent } from './shared/components/view-footer/view-footer.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'InderFe';
}
