import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent implements OnInit {
public namePlease=""
  constructor() { }

  ngOnInit() {
  }
  log(value: string){
    console.log(value);
    this.namePlease = value;
}
}
