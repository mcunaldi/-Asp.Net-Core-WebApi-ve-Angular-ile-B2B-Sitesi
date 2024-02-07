import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './admin/home/home.component';
import { LayoutsComponent } from './admin/layouts/layouts.component';
import { LoginComponent } from './admin/login/login.component';
import { AuthGuard } from './admin/login/guard/auth.guard';

const routes: Routes = [
  {
    path: "admin-login",
    component: LoginComponent,
    loadChildren: ()=> import("./admin/login/login.module").then(m=> m.LoginModule)
  },
  {
    path: "admin",
    component: LayoutsComponent,
    canActivateChild: [AuthGuard],
    children: [
      {
        path: "",
        component: HomeComponent,
        loadChildren: ()=> import('./admin/home/home.module').then(m=> m.HomeModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
