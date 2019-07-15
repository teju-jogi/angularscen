import { Component, OnInit,Output,EventEmitter } from '@angular/core';

@Component({
  selector: 'app-sub',
  templateUrl: './sub.component.html',
  styleUrls: ['./sub.component.css']
})
export class SubComponent implements OnInit {
 @Output() public childEvent = new EventEmitter();
  constructor() { }

  ngOnInit() {
  }
 fireEvent(){
   this.childEvent.emit('im teja');
 }
}
