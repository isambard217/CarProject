import { DemoService } from './services/demo.service';
import { FeatureService } from './services/feature.service';
import { MakeService } from './services/make.service';
import { VehicleService } from './services/vehicle.service';

import { FormsModule} from '@angular/forms';
import { NgModule, Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { UniversalModule } from 'angular2-universal';

import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { VechicleFormComponent } from './components/vechicle-form/vechicle-form.component';
import { DemoComponentComponent } from './components/demo-component/demo-component.component';
//import { VehicleFormComponent } from './components/vehicle-form/vehicle-form.component';

@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        VechicleFormComponent,
        DemoComponentComponent
       // VehicleFormComponent
    ],
    imports: [
        FormsModule,
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'vehicles/new', component: VechicleFormComponent},
            { path: 'demo/new', component: DemoComponentComponent },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    providers: [

       VehicleService,
       MakeService,
       FeatureService,
       DemoService
       
    ]
})
export class AppModule {
}
