import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../common/generic.service';

@Injectable({
    providedIn: 'root'
  })

export class DepartamentService{

 private _url = "";
 headers: HttpHeaders = new HttpHeaders();
 httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
 }

 constructor(private genericService: GenericService){

 }

 GetDepartamentsList(): Observable<any>{
  
     console.log('entrando a obtener los departamentos')
    return  this.genericService.getRequest('Departements',0)
 }

}

