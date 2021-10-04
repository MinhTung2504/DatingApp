import { Component, OnInit } from '@angular/core';
import { UserRegister } from '../_models/user';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {
  isRegisterMode = false;
  user: UserRegister = {
    username: 'minhtung123',
    email: 'minhtung123@gmail.com',
    password: '123456',
  };
  constructor() {}

  ngOnInit(): void {}

  cancelRegisterMode(event: boolean) {
    this.isRegisterMode = event;
  }
}
