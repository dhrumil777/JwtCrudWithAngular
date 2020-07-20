import { Injectable } from '@angular/core';
import {HttpClient,HttpErrorResponse, HttpHeaders } from '@angular/common/http'
import { Employee } from '../crud/employee';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  
  private apiServer = "https://localhost:44331/api/";

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }

  constructor(
  private httpClient:HttpClient
  ) { }

  Post(employee:Employee,controllerName:string): Observable<Employee> {
    return this.httpClient.post<Employee>(this.apiServer + controllerName +'/PostData/', JSON.stringify(employee), this.httpOptions)       
  } 

  Get(controllerName:string): Observable<Employee>{
   return this.httpClient.get<Employee>(this.apiServer + controllerName + '/GetData/',this.httpOptions);
  }

  Delete(Id:number,controllerName:string){    
    return this.httpClient.get(this.apiServer + controllerName +'/DeleteData/?Id='+Id);       
  }

  Edit(Id:number,controllerName:string){
    return this.httpClient.get<Employee>(this.apiServer + controllerName +'/GetDataById/?Id='+Id);       
  }

}
