import {Component} from "@angular/core";
import {employeeComponent} from "../page_employe/page_employee.component";
import {EmployeeInterface} from "../interface/employee.interface";

@Component({
  selector: 'app-roma',
  templateUrl:'./roma.component.html',
  styleUrls: ['./roma.component.css']
})

export class romaComponent {
  dataemployeeroma : EmployeeInterface[]= [
    {name: 'Robert King', location: 'Team leader'},
    {name: 'Michail Suyama', location: 'Developer'},
    {name: 'Margaret Peacock', location: 'Developer'},
  ]
}
