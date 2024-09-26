import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ClientesService } from '../servicios/clientes.service';
import { Cliente } from '../models/cliente.model';


@Component({
  selector: 'app-cliente-formulario',
  templateUrl: './cliente-formulario.component.html',
  styleUrls: ['./cliente-formulario.component.css']
})
export class ClienteFormularioComponent implements OnInit {
  cliente: Cliente = {
    id: 0, nombre: "",
    banco: "",
    numeroCuenta: "",
    telefono: "",
    correo: "",
    valorDeuda: 0,
    propuestaPago: "",
    fechaRegistro: new Date()
  };
  clientes: Cliente[] = [];

  constructor(private clientesService: ClientesService) { }

  ngOnInit(): void {
    this.obtenerClientes();
  }

  obtenerClientes(): void {
    this.clientesService.getClientes().subscribe({
      next: (data) => {
        this.clientes = data;
      },
      error: (error) => {
        console.error('Error al obtener clientes:', error);
      }
    });



  }
  onSubmit() {
    this.clientesService.agregarCliente(this.cliente).subscribe({
      next: (data) => {
        console.log('Cliente creado:', data);
        this.obtenerClientes();
      },
      error: (error) => {
        console.error('Error al crear cliente:', error);
      }
    });
  }
}