import { Component, OnInit } from '@angular/core';
import { EmployeesService } from '../../services/employees.service';
import { Employee } from '../../models/Employee';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-home',
  imports:[CommonModule, RouterModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})

export class HomeComponent implements OnInit {
  
  allEmployess: Employee[] = [];
  employees: Employee[] = [];

  constructor(private employeeService: EmployeesService) {}

  ngOnInit(): void
  {

    this.employeeService.GetEmployees().subscribe(response => {
      const dados = response.data;

      dados.map((item) => {
        item.createdAt = new Date(item.createdAt!).toLocaleDateString();
        item.updatedAt = new Date(item.updatedAt!).toLocaleDateString();
      });

      this.employees = dados;
      this.allEmployess = dados;
       
    });

  }

  search(event: Event)
  {
    console.log(event);

    const target = event.target as HTMLInputElement;
    const value = target.value.toLocaleLowerCase();

    this.employees = this.allEmployess.filter(user => {
      return user.name.toLocaleLowerCase().includes(value);
    });
  }
}
