import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Property } from "./../models/property";
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PropertiesService {

  private url: string = 'https://localhost:5001/property';
  private externalPropertiesUrl: string = 'https://localhost:5001/externalproperty';

  constructor(private httpClient: HttpClient) { }

  getAllPropertiesFromExternal(): Observable<Property[]> {
    return this.httpClient.get<Property[]>(this.externalPropertiesUrl);
  }

  getAllProperties(): Observable<Property[]> {
    return this.httpClient.get<Property[]>(this.url);
  }

  getById(id: number): Observable<Property> {
    return this.httpClient.get<Property>(`${this.url}/${id}`);
  }

  saveProperty(property: Property): Observable<Object> {
    return this.httpClient.post(this.url, property);
  }
}
