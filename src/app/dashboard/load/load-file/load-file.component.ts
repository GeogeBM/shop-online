import { Component, OnInit } from '@angular/core';
import { ProductoService } from '../producto.service';
@Component({
  selector: 'app-load-file',
  templateUrl: './load-file.component.html',
  //styleUrls: ['./load-file.component.sass']
})
export class LoadFileComponent implements OnInit {

  archivo:any;
  constructor(private productoSevice: ProductoService) { }

  ngOnInit(): void {
  }

  onFileChange(event:any){
    const file = event.target.files[0];
    this.archivo = file;
  }

  onSubmit(){

  }
  savefile(event:any){
    
    this.productoSevice.CargarImagen(this.archivo).subscribe(res => {
      
    })
  }
}
