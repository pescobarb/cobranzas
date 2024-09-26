import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from '../models/cliente.model'; // Asegúrate de que tienes un modelo de Cliente

@Injectable({
  providedIn: 'root'
})
export class ClientesService {
  private apiUrl = 'http://localhost:5098/api/clientes'; // Cambia esta URL según tu API

  constructor(private http: HttpClient) {}

  // Método para obtener la lista de clientes
  getClientes(): Observable<Cliente[]> {
    return this.http.get<Cliente[]>(this.apiUrl);
  }

  // Método para agregar un nuevo cliente
  agregarCliente(cliente: Cliente): Observable<Cliente> {
    return this.http.post<Cliente>(this.apiUrl, cliente, {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    });
  }

  // Método para actualizar un cliente
 /* actualizarCliente(cliente: Cliente): Observable<Cliente> {
    return this.http.put<Cliente>(`${this.apiUrl}/${cliente.id}`, cliente, {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    });
  }

  // Método para eliminar un cliente
  eliminarCliente(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }*/
}
