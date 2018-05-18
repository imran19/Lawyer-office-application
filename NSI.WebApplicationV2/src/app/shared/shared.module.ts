import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LoaderComponent } from './loader/loader.component';
import { Comp1Component } from './comp1/comp1.component';
import { Comp2Component } from './comp2/comp2.component';
import { NsiCalendarComponent } from './nsi-calendar/nsi-calendar.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [
    LoaderComponent,
    Comp1Component,
    Comp2Component,
    NsiCalendarComponent
  ],
  exports: [
    LoaderComponent,
    Comp1Component,
    Comp2Component,
    NsiCalendarComponent
  ]
})
export class SharedModule { }
