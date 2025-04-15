import { Component } from '@angular/core';
import { EmployeeFormComponent } from "../../components/employee-form/employee-form.component";
import { EmployeesService } from '../../services/employees.service';
import { Employee } from '../../models/Employee';
import { Router } from '@angular/router';

@Component({
  selector: 'app-edit',
  imports: [EmployeeFormComponent],
  templateUrl: './edit.component.html',
  styleUrl: './edit.component.css'
})
export class EditComponent {

  btnAction = "Save";
  btnTitle = "Edit employee";

  constructor(private employeeService: EmployeesService, private router: Router) 
  { }

  updateEmployee(employee: Employee)
    {
      this.employeeService.UpdateEmployee(employee).subscribe((data) => {
        console.log(data);
        this.router.navigate(['/']);
      });
    }
}
