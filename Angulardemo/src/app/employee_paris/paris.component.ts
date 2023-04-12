import {Component} from "@angular/core";
import {employeeComponent} from "../page_employe/page_employee.component";
import {EmployeeInterface} from "../interface/employee.interface";

@Component({
  selector: 'app-paris',
  templateUrl:'./paris.component.html',
  styleUrls: ['./paris.component.css']
})

export class parisComponent {
  dataemployeeparis : EmployeeInterface[]= [
    {name: 'Margaret Peacock', location: 'Team leader'},
    {name: 'Michail Suyama', location: 'Developer'},
    {name: 'Robert King', location: 'Developer'},
  ]
}
