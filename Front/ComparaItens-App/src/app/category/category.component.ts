import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss']
})
export class CategoryComponent implements OnInit {

public categorys: any;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getCategorys();
  }

  public getCategorys(): void{

    // tslint:disable-next-line: deprecation
    this.http.get('https://localhost:44324/v1/comparaItens/category/findAll').subscribe(
      response => this.categorys = response,
      error => console.log(error)
    );
  }
}
