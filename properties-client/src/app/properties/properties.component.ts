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

  // Gets properties from external API.
  getProperties(){
    this.propertiesService.getAllPropertiesFromExternal()
        .subscribe(data => this.properties = data);
  }

  // This is a validator to allow / deny the saving.
  onSave(property: Property){

    // Verifies if the property would be duplicated when promise resolves.
    const exist = this.propertiesService.getByPropertyId(property.propertyID).toPromise();
    
    exist
    .then(res => {
      // Notifies if the property already exists and avoids index conflicts.
      alert(`Property with PropertyID: [${property.propertyID}] already exist`)
    })
    .catch(e => { 
      // The API responded that the entity does not exist so it can be inserted.
      if(e.status === 404){ this.saveProperty(property) }
    })
  }

  // Saves property into database.
  saveProperty(property: Property){
    this.propertiesService.saveProperty(property)
        .subscribe(
          (response: Property) => alert(`Property saved locally with ID: [${response.id}]`),
          err => alert(`An error occurred saving Property [${property.propertyID}]`)
        );  
  }

}
