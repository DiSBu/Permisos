import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Permiso } from '../models/models';
import { PermisosClient, PermisosVm } from '../Permisos-api';
@Component({
  selector: 'app-permisos',
  templateUrl: './permisos.component.html'
})
export class PermisosComponent {
  public permisos: PermisosVm = new PermisosVm();

  constructor(httpClient: PermisosClient) {
    httpClient.get().subscribe(result => {
      this.permisos = result;
      console.log(result.lists);
    }, error => console.error(error));
  }
}

