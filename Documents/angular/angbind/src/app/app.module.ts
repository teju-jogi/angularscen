import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Scenerio1Module } from './scenerio1/scenerio1.module';
import { Scenerio2Module } from './scenerio2/scenerio2.module';
import { FormsModule } from '@angular/forms';
import { Scenerio3Module } from './scenerio3/scenerio3.module';
import { Scenerio4Module } from './scenerio4/scenerio4.module';
import { Scenerio5Module } from './scenerio5/scenerio5.module';
import { Scenerio6Module } from './scenerio6/scenerio6.module';
import { Scenerio7Module } from './scenerio7/scenerio7.module';

@NgModule({
  declarations: [
    AppComponent,
    
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    Scenerio1Module,
    Scenerio2Module,
    Scenerio3Module,
    Scenerio4Module,
    Scenerio5Module,
    Scenerio6Module,
    Scenerio7Module
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
