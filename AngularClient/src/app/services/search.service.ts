import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IRestaurant } from '../interfaces/i-restaurant';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  uri = 'http://localhost:5000';

  constructor(private _httpClient: HttpClient) { }

  GetTopFiveRestaurantsFromSearch(search: IRestaurant): Observable<IRestaurant[]> {
    const url: string = `${this.uri}/api/Restaurants/restaurant-search`;
    return this._httpClient.post<IRestaurant[]>(url, search);
  }
}
