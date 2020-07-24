import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CrudComponent } from './crud/crud.component';
import {HttpClient,HttpErrorResponse, HttpHeaders, HttpClientModule } from '@angular/common/http'
import {ReactiveFormsModule} from '@angular/forms'
import { FormsModule } from '@angular/forms';
import {NgbPaginationModule, NgbAlertModule, NgbDatepicker} from '@ng-bootstrap/ng-bootstrap';
import { UiSwitchModule } from 'ngx-toggle-switch';
import { CustomDirective } from './custom.directive';
import {AngularFireModule } from '@angular/fire'
import {AngularFirestoreModule } from '@angular/fire/firestore'
import { from } from 'rxjs';
import { environment } from 'src/environments/environment';

@NgModule({
  declarations: [
    AppComponent,
    CrudComponent,
    CustomDirective
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,  
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule,
    UiSwitchModule,    
    AngularFireModule.initializeApp(environment.FirebaseConfig)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
