import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Property } from "./../models/property";
import { Observable, of } from 'rxjs';
import environment from "./../../environments/environment";

@Injectable({
  providedIn: 'root'
})
export class PropertiesService {

  constructor(private httpClient: HttpClient) { }

  // Gets all properties from external API.
  getAllPropertiesFromExternal(): Observable<Property[]> {
    return this.httpClient.get<Property[]>(environment.externalAPI);
  }

  // Gets all properties from database.
  getAllProperties(): Observable<Property[]> {
    return this.httpClient.get<Property[]>(environment.roofstockAPI);
  }

  // Gets property from database that matches the PropertyID.
  getByPropertyId(id: number): Observable<Property> {
    return this.httpClient.get<Property>(`${environment.roofstockAPI}/${id}`);
  }

  // Saves the property into database.
  saveProperty(property: Property): Observable<Object> {
    return this.httpClient.post(environment.roofstockAPI, property);
  }
}
