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

  newPermisoEditor: any = {};

  constructor(httpClient: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.httpClient = httpClient;
    this.baseUrl = baseUrl;
  }

  addPermiso(): void {
    let permiso = {
      id: 0,
      apellidosEmpleado: this.newPermisoEditor.apellidosEmpleado,
      nombreEmpleado: this.newPermisoEditor.nombreEmpleado,
      fechaPermiso: this.newPermisoEditor.fechaPermiso,
    };

    this.httpClient.post<Permiso>(this.baseUrl + 'api/Permisos', permiso).subscribe((result) => {
      this.permisoId = result;
    }, error => {
      console.error(error);

        if (error) {
          if (error.error.NombreEmpleado) {
            this.newPermisoEditor.errornombreEmpleado = error.error.NombreEmpleado[0];
            setTimeout(() => document.getElementById("NombreEmpleado").focus(), 250);
          }
          if (error.error.ApellidosEmpleado) {
            this.newPermisoEditor.errorapellidosEmpleado = error.error.ApellidosEmpleado[0];
            setTimeout(() => document.getElementById("ApellidosEmpleado").focus(), 250);
          }
          if (error.error.FechaPermiso) {
            this.newPermisoEditor.errorFechaPermiso = error.error.FechaPermiso[0];
            setTimeout(() => document.getElementById("FechaPermiso").focus(), 250);
          }
        }
    });
  }
    
  newPermisoCancelled(): void {
    //this.newListModalRef.hide();
    this.newPermisoEditor = {};
  }
}
