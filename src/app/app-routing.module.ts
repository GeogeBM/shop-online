import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { ManIndexComponent } from './components/man/man-index/man-index.component';
import { WomanIndexComponent } from './components/woman/woman-index/woman-index.component';
import { GirlIndexComponent } from './components/girl/girl-index/girl-index.component';
import { BoyIndexComponent } from './components/boy/boy-index/boy-index.component';
const routes: Routes = [
  {path:'home', component: HomeComponent},
  {
    path: '',
    pathMatch: 'full',
    redirectTo: '/home'
  },
  {path:'mujer',component: WomanIndexComponent},
  {path:'hombre',component: ManIndexComponent},
  {path:'nino', component: BoyIndexComponent},
  {path:'nina',component:GirlIndexComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
