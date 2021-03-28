import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

//Categorias
import { CategoryComponent } from './components/category/category.component';
import { CategoryDetailComponent } from './components/category/category-detail/category-detail.component';
import { CategoryListComponent } from './components/category/category-list/category-list.component';

//Fabricantes
import { ManufacturerComponent } from './components/manufacturer/manufacturer.component';

//Produtos
import { ProductComponent } from './components/product/product.component';

//Usuários
import { UserComponent } from './components/user/user.component';
import { LoginComponent } from './components/user/login/login.component';
import { RegistrationComponent } from './components/user/registration/registration.component';
import { ProfileComponent } from './components/user/profile/profile.component';

//Dashboard
import { DashboardComponent } from './components/dashboard/dashboard.component';



const routes: Routes = [
  {
    path: 'user', component: UserComponent,
    children:[
        {path: 'login', component: LoginComponent},
        {path: 'registration', component: RegistrationComponent}
    ]
  },
  { path: 'user/profile', component: ProfileComponent },

  {path: 'categorias', redirectTo:'categorias/lista'},
  { path: 'categorias', component: CategoryComponent,
    children: [
        {path: 'detalhe/:id', component: CategoryDetailComponent},
        {path: 'detalhe', component: CategoryDetailComponent},
        {path: 'lista', component: CategoryListComponent},
    ]
  },
  { path: 'fabricantes', component: ManufacturerComponent },
  { path: 'produtos', component: ProductComponent },

  { path: 'dashboard', component: DashboardComponent },
  { path: '', redirectTo:'dashboard', pathMatch:'full' },
  { path: '**', redirectTo:'dashboard', pathMatch:'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
