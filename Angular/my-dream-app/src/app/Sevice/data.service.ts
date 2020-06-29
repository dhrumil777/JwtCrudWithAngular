import { Injectable } from '@angular/core';
import {HttpClient,HttpErrorResponse, HttpHeaders } from '@angular/common/http'
import { IEmployee } from '../crud/employee';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class DataService {
  
  private apiServer = "http://localhost:3000";

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }

  constructor(
  private httpClient:HttpClient
  ) { }

public GetData(){
    return this.httpClient.get("")
  }

  //  create(product): Observable<Product> {
  //   return this.httpClient.post<Product>(this.apiServer + '/products/', JSON.stringify(product), this.httpOptions)
  //   .pipe(
  //     catchError(this.errorHandler)
  //   )
  // } 

  create(employee:IEmployee): Observable<IEmployee> {
    return this.httpClient.post<IEmployee>(this.apiServer + '/products/', JSON.stringify(employee), this.httpOptions)       
  } 

}
