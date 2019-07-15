import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChildComponent } from './child/child.component';
import { ParentComponent } from './parent/parent.component';



@NgModule({
  declarations: [
    ParentComponent,
    ChildComponent
    ],
  imports: [
    CommonModule
  ],
  exports:[
    ParentComponent
  ]
})
export class Scenerio3Module { }
