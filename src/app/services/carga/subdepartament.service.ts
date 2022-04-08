import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../common/generic.service';

@Injectable({
    providedIn: 'root'
  })

export class SubDepartamentService{

 private _url = "";
 headers: HttpHeaders = new HttpHeaders();
 httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
 }

 constructor(private genericService: GenericService){

 }

 GetSubDepartamentsList(): Observable<any>{
  
     console.log('entrando a obtener los Subdepartamentos')
    return  this.genericService.getRequest('SubDepartaments',0)
 }

}

