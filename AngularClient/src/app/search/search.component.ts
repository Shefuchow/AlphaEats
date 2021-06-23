import { Component } from '@angular/core';
import { IRestaurant } from '../interfaces/i-restaurant';
import { ICuisine } from '../interfaces/i-cuisine';
import { SearchService } from '../services/search.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})
export class SearchComponent {
  public restaurant: IRestaurant = {
    name: "mcdonalds",
    distance: 10,
    rating: 5,
    price: 10,
    cuisineId: 2,
    cuisineName: "italian"
  };

  constructor (private readonly _searchService: SearchService) {
    _searchService.getWeatherForecast().subscribe(e => {
      console.log(e);
    });
  }

}
