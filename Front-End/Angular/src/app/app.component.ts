import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
   title = 'WelCome to Angular';
   public image="/assets/images/img2.jpg"
   public value = " "

   onClick(){
     alert("Welcome to event Binding")
   }
}