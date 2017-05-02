import { FeatureService } from './../../services/feature.service';
import { MakeService } from './../../services/make.service';
import { VehicleService } from './../../services/vehicle.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vechicle-form',
  templateUrl: './vechicle-form.component.html',
  styleUrls: ['./vechicle-form.component.css']
})
export class VechicleFormComponent implements OnInit {

   //makes;
   makes: any[];
   models: any[]; // This is used to populate the second drop-down list
   features: any[];
   vehicle: any = {};

  // constructor( private vehicleService : VehicleService )
  //{ }

  constructor(
        private makeService : MakeService,
        private featureService : FeatureService)
  {}

  // Because we are working with Javascript
  // When we call makeServer.getMakes the 
  // response the code runs asynchronously. So we need to put the code into a code block
  // at which point the makes array will not be empty
  // This method runs by default after the constructor
  ngOnInit() {
      /*this.vehicleService.getMakes().subscribe(makes => { 
          this.makes = makes;
          console.log("MAKES", this.makes); 
      });  

      this.vehicleService.getFeatures().subscribe(features => this.features = features);
      */
        this.makeService.getMakes().subscribe(makes => {
            this.makes = makes,
            console.log("MAKES", this.makes);
        });

        this.featureService.getFeatures().subscribe(features => this.features = features);

      console.log("MAKES", this.makes);

  }

  onMakeChange() {
      console.log("VEHICLE " + this.vehicle);
      //this.makes.find(m => m.id == this.vehicle.make);
     var selectedMake = this.makes.find(m => m.id == this.vehicle.make);
     //this.models = selectedMake ? selectedMake.models: [];

     // Once you choose a Make from the drop, we get that's make's model and populate the second drop-down

     this.models = selectedMake ? selectedMake.models : [];

  }


  onSubmit(form)
  {
      console.log(form);
  }
  

}
