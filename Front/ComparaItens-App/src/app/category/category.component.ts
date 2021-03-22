import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss']
})
export class CategoryComponent implements OnInit {

  public categorys: any = [];
  public categorysFiltred: any = [];

  private _filterListCategory: string = '';

  public get filterListCategory(): string {
      return this._filterListCategory;
  }

  public set filterListCategory(value: string){
    this._filterListCategory = value;
    this.categorysFiltred = this.filterListCategory ? this.filterCategorys(this.filterListCategory): this.categorys;
  }

  filterCategorys(filterBy: string): any{
    filterBy = filterBy.toLocaleLowerCase();
    return this.categorys.filter(
      (category: { description: string; }) => category.description.toLocaleLowerCase().indexOf(filterBy) !== -1
    )
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getCategorys();
  }

  public getCategorys(): void{

    // tslint:disable-next-line: deprecation
    this.http.get('https://localhost:44324/v1/comparaItens/category/findAll').subscribe(
      response => {
        this.categorys = response;
        this.categorysFiltred = this.categorys;
      },
      error => console.log(error)
    );
  }
}
