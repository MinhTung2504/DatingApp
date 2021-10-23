import { Component, OnInit } from '@angular/core';
import { AccountsService } from './_services/accounts.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  constructor(private accountsService: AccountsService) {}

  ngOnInit(): void {
    this.accountsService.refreshToken();
  }
}
