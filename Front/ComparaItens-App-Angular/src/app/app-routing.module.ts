import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CategoryComponent } from './components/category/category.component';
import { ManufacturerComponent } from './components/manufacturer/manufacturer.component';
import { ProductComponent } from './components/product/product.component';
import { UserComponent } from './components/user/user.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';

const routes: Routes = [
  { path: 'categorias', component: CategoryComponent },
  { path: 'fabricantes', component: ManufacturerComponent },
  { path: 'produtos', component: ProductComponent },
  { path: 'usuarios', component: UserComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo:'dashboard', pathMatch:'full' },
  { path: '**', redirectTo:'dashboard', pathMatch:'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
