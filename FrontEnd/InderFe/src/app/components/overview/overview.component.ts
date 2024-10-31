import { Component } from '@angular/core';
import { UserService } from '../../shared/services/user.service';
import { User } from '../../shared/types/models/user';

@Component({
  selector: 'app-overview',
  templateUrl: './overview.component.html',
  styleUrl: './overview.component.scss'
})
export class OverviewComponent {
  constructor(private userService: UserService) {}
  users: User[] = [];
  user: User | undefined = undefined;
  id: number = 0;

  ngOnInit(): void {
      this.userService.getAllUsers().subscribe((data) => {
        this.users = data
      });

      this.LoadNewUser();
  }

  private LoadNewUser(): void{
      this.user = this.users.find((data) => data.id === this.id);
      if (!this.user){
        this.id = 0;
        this.user = this.users.find((data) => data.id === this.id);
      }
      this.id++;
  }

  public like(): void {
      console.log('Liked:', this.user?.name);
      this.LoadNewUser();
  }

  public dislike(): void {
      console.log('Disliked:', this.user?.name);
      this.LoadNewUser();
  }

  public return(): void {
      console.log('Return:', this.user?.name);
      this.id = this.id - 2;
      this.LoadNewUser();
  }
}
