import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductoService {

  private BASE_URL = 'https://localhost:44388/api/';
  constructor(
    //private http:HttpClient
  ) { }
}
