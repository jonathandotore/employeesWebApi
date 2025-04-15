import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, FormsModule, Validators } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { Employee } from '../../models/Employee';

@Component({
  selector: 'app-employee-form',
  imports: [FormsModule, ReactiveFormsModule],
  templateUrl: './employee-form.component.html',
  styleUrl: './employee-form.component.css'
})
export class EmployeeFormComponent implements OnInit { 

  @Output() onSubmit = new EventEmitter<Employee>();
  @Input() btnAction! : string;
  @Input() btnTitle! : string;

  employeeForm!: FormGroup;

  constructor() { }
  
  ngOnInit(): void
  {
    this.employeeForm = new FormGroup({
      id: new FormControl(0),
      name: new FormControl('', [Validators.required]),
      lastName: new FormControl('', [Validators.required]),
      dept: new FormControl('', [Validators.required]),
      status: new FormControl(true),
      turn: new FormControl('', [Validators.required]),
      createdAt: new FormControl(new Date()),
      updatedAt: new FormControl(new Date())
    });
  }
  
  submit()
  {
    this.onSubmit.emit(this.employeeForm.value);
  }
}
