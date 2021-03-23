import { Component, OnInit } from '@angular/core';
import { Category } from '../models/Category';
import { CategoryService } from '../services/category.service';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss']
})
export class CategoryComponent implements OnInit {

  public categorys: Category[] = [];
  public categorysFiltred: Category[] = [];

  private filterListedCategory = '';

  public get filterListCategory(): string {
      return this.filterListedCategory;
  }

  public set filterListCategory(value: string){
    this.filterListedCategory = value;
    this.categorysFiltred = this.filterListCategory ? this.filterCategorys(this.filterListCategory): this.categorys;
  }

  public filterCategorys(filterBy: string): Category[]{
    filterBy = filterBy.toLocaleLowerCase();
    return this.categorys.filter(
      (category: { description: string; }) => category.description.toLocaleLowerCase().indexOf(filterBy) !== -1
    );
  }

  constructor(private categoryService: CategoryService) { }

  public ngOnInit(): void {
    this.getCategorys();
  }

  public getCategorys(): void{

    // tslint:disable-next-line: deprecation
    this.categoryService.getCategorys().subscribe(
      (categoryList: Category[]) => {
        this.categorys = categoryList;
        this.categorysFiltred = this.categorys;
      },
      error => console.log(error)
    );
  }
}
