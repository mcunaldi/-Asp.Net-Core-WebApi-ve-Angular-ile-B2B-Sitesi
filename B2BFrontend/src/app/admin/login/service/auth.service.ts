import { HttpClient } from '@angular/common/http';
import { Inject, Injectable, inject } from '@angular/core';
import { Router } from '@angular/router';
import { AdminLoginModel } from '../models/admin-login-model';
import { AdminTokenModel } from '../models/admin-token-model';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  adminTokenModel : AdminTokenModel = new AdminTokenModel();

  constructor(
    @Inject("apiUrl") private apiUrl:string,
    private httpClient: HttpClient,
    private router: Router
  ) { }

  isAuthenticate(){
    if (localStorage.getItem("adminToken")) {
      return true;
    }
    return false;
  }

  loign(adminLoginModel: AdminLoginModel){
    let api = this.apiUrl + "auth/UserLogin";
    this.httpClient.post(api, adminLoginModel).subscribe((res:any)=>{
      this.adminTokenModel = res.data;
      localStorage.setItem("adminToken", this.adminTokenModel.adminAccessToken);
      this.router.navigate(["admin"])
    },(err)=>{

    })
  }
}
