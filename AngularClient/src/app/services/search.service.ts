import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  uri = 'http://localhost:5000';

  constructor(private http: HttpClient) { }

  getWeatherForecast() {
    return this.http.get(`${this.uri}/WeatherForecast`)
  }
}
