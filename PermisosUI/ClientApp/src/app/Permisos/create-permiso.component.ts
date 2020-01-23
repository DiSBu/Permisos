import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { Permiso } from '../models/models';
import { PermisosClient, CreatePermisoCommand } from '../Permisos-api';

@Component({
  selector: 'app-permisos',
  templateUrl: './create-permiso.component.html'
})
export class CreatePermisoComponent {
  public httpClient: PermisosClient;
  public baseUrl: string;
  public permiso: CreatePermisoCommand;

  public newPermisoEditor: any;

  constructor(httpClient: PermisosClient) {
    this.httpClient = httpClient;
    this.newPermisoEditor = { apellidosEmpleado: null, nombreEmpleado: null, fechaPermiso: null };
    this.permiso = new CreatePermisoCommand();
  }

  addPermiso(): void {

    this.permiso.id = 0;
    this.permiso.apellidosEmpleado = this.newPermisoEditor.apellidosEmpleado;
    this.permiso.nombreEmpleado = this.newPermisoEditor.nombreEmpleado;
    this.permiso.fechaPermiso = this.newPermisoEditor.fechaPermiso;

    this.clear();
    this.httpClient.post(this.permiso).subscribe((result) => {
      this.permiso.id = result;
      this.clear();
    }, error => {
      console.error(error);

        if (error) {
          if (error.response.includes('NombreEmpleado')) {
            this.newPermisoEditor.errornombreEmpleado = 'Debe completar el Nombre';
            setTimeout(() => document.getElementById("NombreEmpleado").focus(), 250);
          }
          if (error.response.includes('ApellidosEmpleado')) {
            this.newPermisoEditor.errorapellidosEmpleado = 'Debe completar el Apellidos';
            setTimeout(() => document.getElementById("ApellidosEmpleado").focus(), 250);
          }
        if (error.response.includes('FechaPermiso')) {
            this.newPermisoEditor.errorfechaPermiso = 'Ingrese la fecha';
            setTimeout(() => document.getElementById("FechaPermiso").focus(), 250);
          }
        }
    });
  }
    
  newPermisoCancelled(): void {
    //this.newListModalRef.hide();
    this.newPermisoEditor = {};
  }

  clear(): void {
    this.newPermisoEditor.errornombreEmpleado = null;
    this.newPermisoEditor.errorapellidosEmpleado = null;
    this.newPermisoEditor.errorfechaPermiso = null;
  }
}
