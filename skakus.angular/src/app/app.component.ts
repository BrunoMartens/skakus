import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { AppService } from './app.service';
import { Game } from './types/game';

@Component({
  selector: 'skakus-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit {
  title = 'skakus';
  games: Game[] = [];
  constructor(private appService: AppService) {

  }

  ngOnInit(): void {
    this.appService.getGames().subscribe(g => this.games = g);
  }
}
