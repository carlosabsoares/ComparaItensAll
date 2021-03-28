import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-category-detail',
  templateUrl: './category-detail.component.html',
  styleUrls: ['./category-detail.component.scss']
})
export class CategoryDetailComponent implements OnInit {

  form!: FormGroup;

  get f(): any{
    return this.form.controls;
  }
  constructor( private fb: FormBuilder ) { }



  ngOnInit(): void {
    this.validation();
  }

  public validation(): void{
    this.form = this.fb.group (
      {
         description : ['', [Validators.required, Validators.minLength(3), Validators.maxLength(20)]]
      });
  }

}
