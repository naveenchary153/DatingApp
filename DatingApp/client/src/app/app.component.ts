import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title:string = 'Hello';
  users:any;

  constructor(private http:HttpClient){

  }
  ngOnInit(): void {
    this.http.get('http://localhost:5001/Api/Users').subscribe({
      next:responce=>this.users=responce,
      error(err) {
        console.log(err)
      },
      complete() {
        console.log('Request Completed...')
      },
      
    });
  }
  
}
