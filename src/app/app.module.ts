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
import { FormsModule } from '@angular/forms'
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
    LoadComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClient,
    FormsModule
  ],
  providers: [
    ProductoService

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
