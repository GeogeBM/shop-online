export class Producto {
   
          ProductoId : number; 
          DepartamentId : number;
          SubDepartamentId : number;
          ProductoNombre : string;
          ProductoDesc : string;
          MarcaId : number;
          PrecioCompra : number;
          PrecioBrutoVenta : number;
          PrecioNetoVenta  : number;
          ProductoImpuesto : number;
          ProductoImpuestoPorc : number;
          ProductoCantidad : number;

          constructor(){
              this.ProductoId = 0; 
                this.DepartamentId = 0;
                this.SubDepartamentId = 0;
                this.ProductoNombre = '';
                this.ProductoDesc = '';
                this.MarcaId = 0;
                this.PrecioCompra = 0;
                this.PrecioBrutoVenta = 0;
                this.PrecioNetoVenta  = 0;
                this.ProductoImpuesto = 0;
                this.ProductoImpuestoPorc = 0;
                this.ProductoCantidad = 0;
          }
}