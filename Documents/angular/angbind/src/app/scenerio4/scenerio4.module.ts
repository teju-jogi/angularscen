import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SubComponent } from './sub/sub.component';
import { SuperComponent } from './super/super.component';



@NgModule({
  declarations: [SubComponent, SuperComponent],
  imports: [
    CommonModule
  ],
  exports:[
    SuperComponent
  ]
})
export class Scenerio4Module { }
