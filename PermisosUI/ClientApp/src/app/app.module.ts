import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { PermisosComponent } from './Permisos/permisos.component';
import { CreatePermisoComponent } from './Permisos/create-permiso.component';
import { PermisosClient } from './Permisos-api';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    PermisosComponent,
    CreatePermisoComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'permisos', component: PermisosComponent },
      { path: 'create-permiso', component: CreatePermisoComponent },
    ])
  ],
  providers: [PermisosClient],
  bootstrap: [AppComponent]
})
export class AppModule { }
