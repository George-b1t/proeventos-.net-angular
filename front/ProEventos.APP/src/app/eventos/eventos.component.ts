import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface Evento {
  eventoId: number
  local: string
  dataEvento: string
  tema: string
  qtdPessoas: number
  lote: string
  imageURL: string
}

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {
  public eventos: Evento[] = []

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos()
  }

  public getEventos(): void {
    this.http.get('https://localhost:7009/api/Eventos').subscribe(
      response => this.eventos = response as Evento[],
      error => console.log(error)
    )
  }
}
