import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { GenericService } from 'src/app/services/common/generic.service';
import { Producto } from 'src/app/models/producto';
@Injectable({
  providedIn: 'root'
})
export class ProductoService {

  private BASE_URL = 'https://localhost:44388/api/';
  constructor(
    private genericService: GenericService
  ) { }

  CreateProducto(producto: Producto){
      let url = 'Producto';
      return this.genericService.postReques(url,producto)
  }
}
