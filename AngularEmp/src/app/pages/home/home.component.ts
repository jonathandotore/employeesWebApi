import { Component, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { EmployeesService } from '../../services/employees.service';
import { Employee } from '../../models/Employee';


@Component({
  selector: 'app-home',
  imports:[],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})

export class HomeComponent implements OnInit {
  
  allEmployess: Employee[] = [];
  employees: Employee[] = [];

  constructor(private employeeService: EmployeesService) {}

  ngOnInit(): void {

    this.employeeService.GetEmployees().subscribe(response => {
      console.log(response);
    });

  }
}
