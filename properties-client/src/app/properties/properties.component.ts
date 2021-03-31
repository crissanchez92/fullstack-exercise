import { PropertiesService } from './../services/properties.service';
import { Component, OnInit } from '@angular/core';
import { Property } from '../models/property';

@Component({
  selector: 'app-properties',
  templateUrl: './properties.component.html',
  styleUrls: ['./properties.component.css']
})
export class PropertiesComponent implements OnInit {

  properties: Property[] = [];
  displayedColumns: string[] = ['propertyID','listPrice','monthlyRent','grossYield', 'yearBuilt','address', 'actions'];

  constructor(private propertiesService: PropertiesService) { }

  ngOnInit(): void {
    this.getProperties();
  }

  getProperties(){
    this.propertiesService.getAllPropertiesFromExternal()
        .subscribe(data => this.properties = data);
  }

  onSave(property: Property){
    const exist = this.propertiesService.getById(property.propertyID).toPromise();
    
    exist
    .then(res => {
      alert(`Property with PropertyID: [${property.propertyID}] already exist`)
    })
    .catch(e => { 
      if(e.status === 404){ this.saveProperty(property) }
    })
  }

  saveProperty(property: Property){
    this.propertiesService.saveProperty(property)
        .subscribe(
          (response: Property) => alert(`Property saved locally with IDg: [${response.id}]`),
          err => alert(`An error occurred saving Property [${property.propertyID}]`)
        );  
  }

}
