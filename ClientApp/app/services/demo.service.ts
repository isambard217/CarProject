import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class DemoService {

  constructor(private http: Http) { }

  getDemos() {

    console.log("Hello-World");

    return this.http.get('/api/demo')
    .map(res => res.json());
  }

}
