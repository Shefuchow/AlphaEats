import { Component, OnInit } from '@angular/core';
import { SearchService } from 'src/app/services/search.service';

@Component({
  selector: 'app-search-filters',
  templateUrl: './search-filters.component.html',
  styleUrls: ['./search-filters.component.scss']
})
export class SearchFiltersComponent{
  public buttonClass = "disabled";
  public errorMessage = "";
  //Arrays to populate option tags
  distances: object[] = [
    {value: 2, tag: "~2mi"},
    {value: 4, tag: "~4mi"},
    {value: 6, tag: "~6mi"},
    {value: 8, tag: "~8mi"},
    {value: 10, tag: "~10mi"},
  ];

  ratings: number[] = [1,2,3,4,5];

  prices: object[] = [
    {value: 10, tag: "~ $10"},
    {value: 20, tag: "~ $20"},
    {value: 30, tag: "~ $30"},
    {value: 40, tag: "~ $40"},
    {value: 50, tag: "~ $50"},
  ];


  public search(restaurantInput: string, cuisineInput: string, distanceInput: number, ratingInput: number, priceInput: number){
    const payload = {
      RestaurantInput: restaurantInput,
      CuisineInput: cuisineInput,
      DistanceInput: distanceInput,
      RatingInput: ratingInput,
      PriceInput: priceInput
    };
    this._searchService.GetTopFiveRestaurantsFromSearch(payload).subscribe(e=> console.log(e));
  }

  constructor(private readonly _searchService: SearchService) {}

}
