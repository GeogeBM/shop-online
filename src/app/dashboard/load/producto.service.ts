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

  CargarImagen(file:any){
    let url = 'Producto/Uploadfile'

    const formdata = new FormData();
    formdata.append("Name","Prueba.jpg");
    formdata.append("Emial","");
    formdata.append("Picture",file);
    return this.genericService.postFilesReques(url,formdata);
  }
}
