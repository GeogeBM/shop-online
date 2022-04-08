


import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../common/generic.service';

@Injectable({
    providedIn: 'root'
  })

export class MarcaService{

 private _url = "";
 headers: HttpHeaders = new HttpHeaders();
 httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
 }

 constructor(private genericService: GenericService){

 }

 GetMarcasList(): Observable<any>{
  
     console.log('entrando a obtener los Subdepartamentos')
    return  this.genericService.getRequest('Marcas',0)
 }

}

