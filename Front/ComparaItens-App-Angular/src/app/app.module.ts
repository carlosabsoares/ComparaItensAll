import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { CollapseModule } from 'ngx-bootstrap/collapse';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ModalModule } from 'ngx-bootstrap/modal';

import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CategoryComponent } from './category/category.component';

import { ManufacturerComponent } from './manufacturer/manufacturer.component';
import { NavComponent } from './nav/nav.component';


import { CategoryService } from './services/category.service';

import { DateTimeFormatPipe } from './helpers/DateTimeFormat.pipe';
import { UserComponent } from './user/user.component';
import { ProductComponent } from './product/product.component';
import { from } from 'rxjs';


@NgModule({
  declarations: [
    AppComponent,
    CategoryComponent,
    ManufacturerComponent,
    NavComponent,
    DateTimeFormatPipe,
    UserComponent,
    ProductComponent
   ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    CollapseModule.forRoot(),
    TooltipModule.forRoot(),
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    ToastrModule.forRoot({
                          timeOut: 3000,
                          positionClass: 'toast-bottom-right',
                          preventDuplicates: true,
                          progressBar: true
                        }),
    NgxSpinnerModule
  ],
  providers: [CategoryService],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }
