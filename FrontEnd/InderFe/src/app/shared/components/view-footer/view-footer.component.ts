import { Component } from '@angular/core';
import { ViewProfileComponent } from '../../../components/view-profile/view-profile.component';

@Component({
  selector: 'app-view-footer',
  providers: [
    ViewProfileComponent
  ],
  templateUrl: './view-footer.component.html',
  styleUrl: './view-footer.component.scss'
})
export class ViewFooterComponent {

}
