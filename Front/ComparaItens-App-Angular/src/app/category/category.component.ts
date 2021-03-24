import { Component, OnInit, TemplateRef } from '@angular/core';
import { Category } from '../models/Category';
import { CategoryService } from '../services/category.service';

import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { ToastrService } from 'ngx-toastr';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.scss']
})
export class CategoryComponent implements OnInit {
  modalRef = {} as BsModalRef;
  public categorys: Category[] = [];
  public categorysFiltred: Category[] = [];

  private filterListedCategory = '';


  confim(): void {
    this.modalRef.hide();
  }

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

  constructor(
              private categoryService: CategoryService,
              private modalService: BsModalService,
              private toastr: ToastrService,
              private spinner: NgxSpinnerService
              ) { }

  public ngOnInit(): void {
    this.spinner.show();
    this.getCategorys();
  }

  public getCategorys(): void{

    // tslint:disable-next-line: deprecation
    this.categoryService.getCategorys().subscribe({
      next:       (categoryList: Category[]) => {
        this.categorys = categoryList;
        this.categorysFiltred = this.categorys;
      },
      error: (error: any) => {
        this.spinner.hide();
        this.toastr.error('Erro ao carregar as categorias','Error');
      },
      complete: () => this.spinner.hide()
      });
   }

   openModal(template: TemplateRef<any>) {
      this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
    }

   confirm(): void {
    this.modalRef.hide();
    this.toastr.success('A categoria foi excluida com sucesso.','Excluido!');
  }

  decline(): void {
    this.modalRef.hide();
  }

  }

/*

*/
