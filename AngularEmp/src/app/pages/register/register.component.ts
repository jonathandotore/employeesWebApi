import { Component } from '@angular/core';
import { EmployeeFormComponent } from "../../components/employee-form/employee-form.component";

@Component({
  selector: 'app-register',
  imports: [EmployeeFormComponent],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

}
