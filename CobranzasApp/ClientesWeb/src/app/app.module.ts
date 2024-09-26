import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClienteFormularioComponent } from './cliente-formulario/cliente-formulario.component';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

import { HttpClientModule } from '@angular/common/http'; // Importa HttpClientModule


@NgModule({
  declarations: [
    AppComponent,
    ClienteFormularioComponent
  ],
  imports: [
    FormsModule,
    HttpClientModule ,
    BrowserModule,
    ReactiveFormsModule // Agrega esta línea
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
