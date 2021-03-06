import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule,  } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { CollapseModule } from 'ngx-bootstrap/collapse';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { ModalModule } from 'ngx-bootstrap/modal';

import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CategoryComponent } from './components/category/category.component';
import { TituloComponent } from './shared/titulo/titulo.component';
import { ManufacturerComponent } from './components/manufacturer/manufacturer.component';

import { NavComponent } from './shared/nav/nav.component';

import { CategoryService } from './services/category.service';

import { from } from 'rxjs';

import { DateTimeFormatPipe } from './helpers/DateTimeFormat.pipe';
import { UserComponent } from './components/user/user.component';
import { ProductComponent } from './components/product/product.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { CategoryDetailComponent } from './components/category/category-detail/category-detail.component';
import { CategoryListComponent } from './components/category/category-list/category-list.component';
import { LoginComponent } from './components/user/login/login.component';
import { RegistrationComponent } from './components/user/registration/registration.component';
import { ProfileComponent } from './components/user/profile/profile.component';



@NgModule({
  declarations: [
    AppComponent,
    DateTimeFormatPipe,
    NavComponent,
    ManufacturerComponent,
    UserComponent,
    TituloComponent,
    ProductComponent,
    DashboardComponent,
    CategoryComponent,
    CategoryDetailComponent,
    CategoryListComponent,
    UserComponent,
    LoginComponent,
    ProfileComponent,
    RegistrationComponent
   ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
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
