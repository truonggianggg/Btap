import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import {employeeComponent} from "./page_employe/page_employee.component";
import {RouterModule, Routes} from "@angular/router";
import {romaComponent} from "./employee_roma/roma.component";
import {parisComponent} from "./employee_paris/paris.component";
import {londonComponent} from "./employee_london/london.component";


const appRouters: Routes = [
  {path: '', component: romaComponent},
  {path: 'paris', component: parisComponent},
  {path: 'london', component: londonComponent},
]

@NgModule({
  declarations: [
    AppComponent,
    employeeComponent,
    romaComponent,
    parisComponent,
    londonComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRouters)

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
