import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { DataService } from '../Sevice/data.service';
@Component({
  selector: 'app-crud',
  templateUrl: './crud.component.html',
  styleUrls: ['./crud.component.css']
})
export class CrudComponent implements OnInit {


  CrudForm : FormGroup;

  constructor(
    public fb: FormBuilder,
    public crudService: DataService
  ) { }

  ngOnInit(): void {
    this.CrudForm = this.fb.group({
      EmployeeName: [''],
      DeparmentName: [''],
    })
  }

  submitForm(){
    debugger
    this.CrudForm.value;
    debugger;
  }
}
