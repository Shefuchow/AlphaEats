import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ISearch } from '../interfaces/i-search';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  uri = 'http://localhost:5000';

  constructor(private _httpClient: HttpClient) { }

  GetTopFiveRestaurantsFromSearch(search: ISearch): Observable<ISearch[]> {
    const url: string = `${this.uri}/api/Restaurants/restaurant-search`;
    return this._httpClient.post<ISearch[]>(url, search);
  }
}
