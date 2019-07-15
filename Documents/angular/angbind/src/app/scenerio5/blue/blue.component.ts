import { Component, OnInit ,Output,EventEmitter} from '@angular/core';

@Component({
  selector: 'app-blue',
  templateUrl: './blue.component.html',
  styleUrls: ['./blue.component.css']
})
export class BlueComponent implements OnInit {
@Output() public sendToParentEvent=new EventEmitter();
  constructor() { }

  ngOnInit() {
  }
sendMessageToParentEvent(message:string){
  this.sendToParentEvent.emit(message);
}
}
