import { Component, OnInit } from '@angular/core';
import { Departament } from 'src/app/models/departament';
import { DepartamentService } from 'src/app/services/carga/departament.service';
@Component({
  selector: 'app-load',
  templateUrl: './load.component.html',
  styleUrls: ['./load.component.sass']
})
export class LoadComponent implements OnInit {

  departamnets: Departament = new Departament();

  constructor(private departamentService: DepartamentService) { }

  ngOnInit(): void {
    this.getDepartaments();
  }

  getDepartaments(){
    console.log('entrando por los departamentos')
    this.departamentService.GetDepartamentsList().subscribe(data => {
      console.log('los departamentos enontrados son: ',data)
    });

  }

}
