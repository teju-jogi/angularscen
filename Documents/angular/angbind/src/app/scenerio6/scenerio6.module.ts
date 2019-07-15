import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Child1Component } from './child1/child1.component';
import { Child2Component } from './child2/child2.component';
import { Parent1Component } from './parent1/parent1.component';



@NgModule({
  declarations: [Child1Component, Child2Component, Parent1Component],
  imports: [
    CommonModule
  ],
  exports:[
    Parent1Component
  ]
})
export class Scenerio6Module { }
