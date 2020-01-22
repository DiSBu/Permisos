import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Permiso } from '../models/models';
@Component({
  selector: 'app-permisos',
  templateUrl: './permisos.component.html'
})
export class PermisosComponent {
  public permisos: Permiso[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Permiso[]>(baseUrl + 'api/Permisos').subscribe(result => {
      this.permisos = result;
    }, error => console.error(error));
  }
}

