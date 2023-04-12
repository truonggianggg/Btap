import {Component} from "@angular/core";
import {employeeComponent} from "../page_employe/page_employee.component";
import {EmployeeInterface} from "../interface/employee.interface";

@Component({
  selector: 'app-london',
  templateUrl:'./london.component.html',
  styleUrls: ['./london.component.css']
})

export class londonComponent {
  dataemployeelondon : EmployeeInterface[]= [
    {name: 'Michail Suyama', location: 'Team leader'},
    {name: 'Margaret Peacock', location: 'Developer'},
    {name: 'Robert King', location: 'Developer'},
  ]
}
