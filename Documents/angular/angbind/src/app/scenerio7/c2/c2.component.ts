import { Component, OnInit } from '@angular/core';
import { NewService } from 'src/app/new.service';

@Component({
  selector: 'app-c2',
  templateUrl: './c2.component.html',
  styleUrls: ['./c2.component.css']
})
export class C2Component implements OnInit {
public employees=[];
  constructor(private newService:NewService) { }
child1Message:any;
  ngOnInit() {
    this.newService.message.subscribe(data => {this.child1Message = data;});
  }

}
