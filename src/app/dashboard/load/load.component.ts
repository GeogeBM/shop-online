import { Component, OnInit } from '@angular/core';
import { Departament } from 'src/app/models/departament';
import { SubDepartament } from 'src/app/models/subdepartament';
import { Marca } from 'src/app/models/marca';

import { DepartamentService } from 'src/app/services/carga/departament.service';
import { SubDepartamentService } from 'src/app/services/carga/subdepartament.service';
import { MarcaService } from 'src/app/services/carga/marca.service';
@Component({
  selector: 'app-load',
  templateUrl: './load.component.html',
  styleUrls: ['./load.component.sass']
})
export class LoadComponent implements OnInit {

  departamnets: Departament[] = [];
  subdepartements: SubDepartament[] = [];
  marcasList: Marca[] = [];
  
  constructor(private departamentService: DepartamentService, private subdetapatamentsService: SubDepartamentService,private marcaService:MarcaService) { }

  ngOnInit(): void {
    this.getDepartaments();
    this.getSubdepartaments();
    this.getMarcas();
  }

  getDepartaments(){
    this.departamentService.GetDepartamentsList().subscribe(data => {
      this.departamnets = data;
      console.log('los departamentos enontrados son: ',data)
    });
  }

  getSubdepartaments(){
    this.subdetapatamentsService.GetSubDepartamentsList().subscribe(data => {
      this.subdepartements = data;
      console.log('los subdepartamentos encontrados son: ',data)
    })
  }
  getMarcas(){

    this.marcaService.GetMarcasList().subscribe(data => {
      this.marcasList = data;
      console.log('las marcas encontradas son: ',data)
    })
  }

  changeDepartament(e:any){

    console.log('el evento mandado es: ', e.target.value);
  }

}
