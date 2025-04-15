import { Component } from '@angular/core';
import { EmployeeFormComponent } from "../../components/employee-form/employee-form.component";
import { Employee } from '../../models/Employee';
import { EmployeesService } from '../../services/employees.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  imports: [EmployeeFormComponent],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  constructor(private employeeService: EmployeesService, private router: Router)
  { }

  registerEmployee(employee: Employee)
  {
    this.employeeService.RegisterEmployee(employee).subscribe(() => {
      this.router.navigate(['/']);
    });
  }
}
