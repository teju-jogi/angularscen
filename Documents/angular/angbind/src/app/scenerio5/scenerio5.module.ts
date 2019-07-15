import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BlueComponent } from './blue/blue.component';
import { GreenComponent } from './green/green.component';
import { RedComponent } from './red/red.component';



@NgModule({
  declarations: [BlueComponent, GreenComponent, RedComponent],
  imports: [
    CommonModule
  ],
  exports:[
    RedComponent
  ]
})
export class Scenerio5Module { }
