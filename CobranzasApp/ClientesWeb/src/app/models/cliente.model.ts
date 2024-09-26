
// src/app/models/cliente.model.ts

export interface Cliente {
    id: number;            // ID del cliente
        nombre: string;
        banco: string;
        numeroCuenta: string;
        telefono: string;
        correo: string;
        valorDeuda: number,
        propuestaPago: string,
        fechaRegistro: Date
}
