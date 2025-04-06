import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.development';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employee } from '../models/Employee';
import { Response } from '../models/Response';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {

  private apiUrl = `${environment.UrlApi}`;

  constructor(private http: HttpClient) { }

  GetEmployees() : Observable<Response<Employee[]>>
  {
    return this.http.get<Response<Employee[]>>(this.apiUrl);
  }
}
