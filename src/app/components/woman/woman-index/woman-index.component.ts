import { Component, OnInit } from '@angular/core';
import { People } from 'src/app/models/people';
@Component({
  selector: 'app-woman-index',
  templateUrl: './woman-index.component.html',
  styleUrls: ['./woman-index.component.sass']
})
export class WomanIndexComponent implements OnInit {

  persons: People[] =[
    {nombre:'nombre 1',detalle: 'detalle 1'},
    {nombre:'nombre 2',detalle: 'detalle 2'},
    {nombre:'nombre 3',detalle: 'detalle 3'},
    {nombre:'nombre 4',detalle: 'detalle 4'},
    {nombre:'nombre 5',detalle: 'detalle 5'},
    {nombre:'nombre 6',detalle: 'detalle 6'},
    {nombre:'nombre 7',detalle: 'detalle 7'},
    {nombre:'nombre 8',detalle: 'detalle 8'},
    {nombre:'nombre 9',detalle: 'detalle 9'},
    {nombre:'nombre 10',detalle: 'detalle 10'},
  ];
  constructor() { 

    
  }

  ngOnInit(): void {
  }

}
