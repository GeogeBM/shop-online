import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './components/home/home.component';
import { HomeIndexComponent } from './dashboard/home/home-index/home-index.component';
import { NavbarComponent } from './dashboard/layout/navbar/navbar.component';
import { WomanIndexComponent } from './components/woman/woman-index/woman-index.component';
import { ManIndexComponent } from './components/man/man-index/man-index.component';
import { BoyIndexComponent } from './components/boy/boy-index/boy-index.component';
import { GirlIndexComponent } from './components/girl/girl-index/girl-index.component';
import { CardComponent } from './common/card/card.component';
import { LoadComponent } from './dashboard/load/load.component';

import { ProductoService } from './services/producto/producto.service';

import { HttpClient, HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { LoadImagenComponent } from './componets/dashboard/load-imagen/load-imagen.component';
import { LoadFileComponent } from './dashboard/load/load-file/load-file.component';
import { FilesListComponent } from './dashboard/load/files-list/files-list.component';
import { ArticulosListComponent } from './dashboard/load/articulos-list/articulos-list.component'
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HomeIndexComponent,
    NavbarComponent,
    WomanIndexComponent,
    ManIndexComponent,
    BoyIndexComponent,
    GirlIndexComponent,
    CardComponent,
    LoadComponent,
    LoadImagenComponent,
    LoadFileComponent,
    FilesListComponent,
    ArticulosListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    ProductoService

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
