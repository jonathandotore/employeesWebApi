import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-employee-form',
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './employee-form.component.html',
  styleUrl: './employee-form.component.css'
})
export class EmployeeFormComponent implements OnInit { 

  employeeForm!: FormGroup;

  constructor() { }
  
  ngOnInit(): void
  {
    this.employeeForm = new FormGroup({
      id: new FormControl(0),
      name: new FormControl(''),
      lastName: new FormControl(''),
      dept: new FormControl(''),
      status: new FormControl(true),
      turn: new FormControl(''),
      createdAt: new FormControl(new Date()),
      updatedAt: new FormControl(new Date())
    });
  }
  
  submit()
  {
    console.log(this.employeeForm.value);
  }
}
