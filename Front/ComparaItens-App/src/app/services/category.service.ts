import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../models/Category';

@Injectable(
  //{providedIn: 'root'}
  )
export class CategoryService {
  baseURL = 'https://localhost:44324/v1/comparaItens/category/findAll';

  constructor(private http: HttpClient) { }

  getCategorys(): Observable<Category[]> {
    return this.http.get<Category[]>(this.baseURL);
  }

  // getCategorysById(id: number ): Observable<Category> {
  //   return this.http.get<Category>(`${this.baseURL}/${id}/id`);
  // }

}
