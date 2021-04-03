import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Property } from 'src/app/models/property';
import { PropertiesService } from 'src/app/services/properties.service';

@Component({
  selector: 'app-property-details',
  templateUrl: './property-details.component.html',
  styleUrls: ['./property-details.component.css']
})
export class PropertyDetailsComponent implements OnInit {

  property: Property;

  constructor(
    private activatedRoute: ActivatedRoute,
    private service: PropertiesService
    ) { }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params => {
      this.service.getByPropertyId(params['propertyId'])
      .subscribe(prop => this.property = prop);
    });
  }

}
