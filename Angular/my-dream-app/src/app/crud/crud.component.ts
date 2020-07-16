import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { DataService } from '../Sevice/data.service';
import { Employee } from './employee';
@Component({
  selector: 'app-crud',
  templateUrl: './crud.component.html',
  styleUrls: ['./crud.component.css']
})
export class CrudComponent implements OnInit {


  CrudForm : FormGroup;
  public Emp:Employee = new Employee()
  public Employees:any;
  public enable:boolean=true;
  constructor(
    public fb: FormBuilder,
    public crudService: DataService
  ) { }

  ngOnInit(): void {
    // this.CrudForm = this.fb.group({
    //   EmployeeName: [''],
    //   DeparmentName: [''],
    //   hobbies:['']
    // })

    
    //this.setDefault();
  }

  // https://stackoverflow.com/questions/49997765/reactive-forms-correctly-convert-form-value-to-model-object
  submitForm(){
    debugger;
    // this.Emp = new Employee(this.CrudForm.value);
    debugger;
  }

  setDefault() {
    // this.Emp.EmployeeName="dhrumil";
    // this.Emp.DeparmentName="Computer Eng";
    // this.CrudForm.setValue(this.Emp);
  }

}
