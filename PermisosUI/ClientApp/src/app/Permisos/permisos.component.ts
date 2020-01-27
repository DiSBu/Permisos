import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Permiso } from '../models/models';
import { PermisosClient, PermisosVm, DeletePermisoCommand} from '../Permisos-api';
@Component({
  selector: 'app-permisos',
  templateUrl: './permisos.component.html'
})
export class PermisosComponent {
  public permisos: PermisosVm = new PermisosVm();
  public httpClient: PermisosClient;
  public permiso: DeletePermisoCommand;
  constructor(httpClient: PermisosClient) {
    this.httpClient = httpClient;
    this.httpClient.get().subscribe(result => {
      this.permisos = result;
      console.log(result.lists);
    }, error => console.error(error));
  }

  delPermiso(permiso: DeletePermisoCommand): void {
    this.httpClient.delete(permiso).subscribe(result => {
      var index = this.permisos.lists.indexOf(permiso);
      this.permisos.lists.splice(index, 1);

      console.log('Permiso borrado' + permiso.id);
    }, error => console.error(error));
  }
}

