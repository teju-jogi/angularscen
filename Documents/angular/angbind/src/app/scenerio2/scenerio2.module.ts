import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Test1Component } from './test1/test1.component';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    Test1Component
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports:[
    Test1Component
  ]
  
})
export class Scenerio2Module { }
