import { Component } from '@angular/core';
import { User } from '../../shared/types/models/user';
import { UserService } from '../../shared/services/user.service';
import { Gender } from '../../shared/types/models/gender';

@Component({
  selector: 'app-view-profile',
  templateUrl: './view-profile.component.html',
  styleUrl: './view-profile.component.scss'
})
export class ViewProfileComponent {
  user!: User;
  imageRef = '';

  constructor(
    private readonly userService: UserService
  ){
  }

  ngOnInit(): void {
    this.userService.getUserById(1).subscribe((user: User) => {
      this.user = user;

      if (this.user.profilePic){
        this.imageRef = this.user.profilePic
      }
    })
  };
}
