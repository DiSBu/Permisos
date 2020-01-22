import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Permiso } from '../models/models';

@Component({
  selector: 'app-permisos',
  templateUrl: './create-permiso.component.html'
})
export class CreatePermisoComponent {
  public httpClient: HttpClient;
  public baseUrl: string;
  public permisoId: Permiso;

  constructor(httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.httpClient = httpClient;
    this.baseUrl = baseUrl;
  }

  createPermiso(permiso: Permiso ) {
    this.httpClient.post<Permiso>(this.baseUrl + 'api/Permisos', permiso).subscribe((result) => {
      this.permisoId = result;
    }, error => console.error(error));
  }
}
