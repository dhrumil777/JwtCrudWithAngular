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



  public Emp:Employee = new Employee();
  public Emplst:any;  
  constructor(
    public fb: FormBuilder,
    public crudService: DataService
  ) { }

  ngOnInit(): void {
    this.GetData()
  }

  GetData():void{
    this.crudService.Get("Crud").subscribe(data => {
        this.Emplst = data;        
    });
  }
  
  PostData():void{    
     this.crudService.Post(this.Emp,"Crud").subscribe(data => {
         this.Emplst = data;
         this.GetData();
      });
  }

  Delete(Id:number):void{   
    this.crudService.Delete(Id,"Crud").subscribe(data => {     
      this.GetData();
   });
  }

  Edit(Id:number):void{

    this.crudService.Edit(Id,"Crud").subscribe(data => {     
      console.log(data);
      this.Emp = data;
    });

  }

 

}
