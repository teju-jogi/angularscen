import { Component, OnInit ,EventEmitter,Output} from '@angular/core';

@Component({
  selector: 'app-green',
  templateUrl: './green.component.html',
  styleUrls: ['./green.component.css']
})
export class GreenComponent implements OnInit {
  @Output() public sendToParentEvent = new EventEmitter();
  constructor() { }

  ngOnInit() {
  }
  sendMessageToParent(event) {
    this.sendToParentEvent.emit(event);
}
}

