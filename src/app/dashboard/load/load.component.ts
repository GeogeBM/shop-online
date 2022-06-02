import { Component, OnInit, enableProdMode } from '@angular/core';
import { Departament } from 'src/app/models/departament';
import { SubDepartament } from 'src/app/models/subdepartament';
import { Marca } from 'src/app/models/marca';

import { DepartamentService } from 'src/app/services/carga/departament.service';
import { SubDepartamentService } from 'src/app/services/carga/subdepartament.service';
import { MarcaService } from 'src/app/services/carga/marca.service';

import { Producto } from 'src/app/models/producto';
import { ProductoService } from './producto.service';
@Component({
  selector: 'app-load',
  templateUrl: './load.component.html',
  //styleUrls: ['./load.component.sass']
})
export class LoadComponent implements OnInit {

  departamnets: Departament[] = [];
  subdepartements: SubDepartament[] = [];
  marcasList: Marca[] = [];
  producto: string = '';
  departamento: number = 0;
  subdepartamento: number = 0;
  descripcion: string = '';
  marca: number = 0;
  precioCompra: number = 0; 
  precioVenta: number = 0;
  impuesto: number = 0;
  precioNeto: number = 0;
  cantidad: number = 0;
  imagen: string = "";
  productoModel: Producto =  new Producto();
  constructor(
    private departamentService: DepartamentService, 
    private subdetapatamentsService: SubDepartamentService,
    private marcaService:MarcaService,
    private productoService:ProductoService) { }

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

  //cargar imagen
  onFileChange(event: any){

    const file = event.target.files[0];
    const reader = new FileReader();

    console.log('la imagen que se mandara',file);
    // if(file !== null || file != undefined){
    
    //  // reader.readAsDataURL(file);
    //   reader.readAsText(file)
    //   //this.imagen = reader.toString();
    //   reader.onload = () => {
    //     this.imagen = (reader.result) ? reader.result.toString(): "";
    //   }
    //}
    
  }
  //guardando el producto
  saveProducto(event: any){
    
    this.productoModel.ProductoId = 0;

    this.productoModel.ProductoNombre = this.producto;
    this.productoModel.DepartamentId = this.departamento;
    this.productoModel.SubDepartamentId = this.subdepartamento;
    this.productoModel.ProductoDesc = this.descripcion;
    this.productoModel.MarcaId = this.cantidad;
    this.productoModel.PrecioCompra = this.precioCompra;
    this.productoModel.PrecioBrutoVenta = this.precioVenta;
    this.productoModel.ProductoImpuesto = this.impuesto;
    this.productoModel.PrecioNetoVenta = this.precioNeto;
    this.productoModel.ProductoCantidad = this.cantidad;
    this.productoModel.ArchivoImagen = this.imagen;

    this.productoService.CreateProducto( this.productoModel).subscribe(data => {
      console.log('se guardaton satsfactoriamente los datos');
    }, (error) => {
      console.log('Error: ', error)
    });
    
    
  }
}
