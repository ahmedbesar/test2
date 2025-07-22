import { Component, OnInit } from '@angular/core';
import { test2Service } from '../services/test2.service';

@Component({
  selector: 'lib-test2',
  template: ` <p>test2 works!</p> `,
  styles: [],
})
export class test2Component implements OnInit {
  constructor(private service: test2Service) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
