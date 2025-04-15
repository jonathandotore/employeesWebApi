import { Component } from '@angular/core';
import { EmployeeFormComponent } from "../../components/employee-form/employee-form.component";
import { Employee } from '../../models/Employee';
import { EmployeesService } from '../../services/employees.service';

@Component({
  selector: 'app-register',
  imports: [EmployeeFormComponent],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

  constructor(private employeeService: EmployeesService)
  { }

  registerEmployee(employee: Employee)
  {
    this.employeeService.RegisterEmployee(employee).subscribe((data) => {
      console.log(data);
    });
  }
}
