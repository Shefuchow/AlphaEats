import { Component, EventEmitter, Output } from '@angular/core';
import { ISearch } from 'src/app/interfaces/i-search';
import { Search } from 'src/app/models/search';
import { SearchService } from 'src/app/services/search.service';

@Component({
  selector: 'app-search-filters',
  templateUrl: './search-filters.component.html',
  styleUrls: ['./search-filters.component.scss']
})
export class SearchFiltersComponent{
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
  @Output() public searchResultsEvent:EventEmitter<ISearch[]> = new EventEmitter<ISearch[]>()
  /* Hello, I was going to implement angular forms with code like this:
  [class.is-danger]="restaurantName.invalid && restaurantName.touched" [(ngModel)]="searchModel.restaurantName"
  instead of the error message below.
  Also was going to implement searchmodel with ngModel passed into the payload, so we dont have all those parameters in search() as that is bad practice
  However, for the interest of time, I had to submit as I have other interviews, and I dont want to keep this interview waiting. Latest Code will be on my github.
  */
  public errorMessage: string = "Hey, please fill out all the fields!";
  public error: boolean = false;
  public searchModel: Search;

  public search(restaurantName: string, cuisineName: string, distance: number, customerRating: number, price: number){
    ((restaurantName == "" || cuisineName == "" || isNaN(distance) || isNaN(customerRating) || isNaN(price)) ? this.error = true : this.error=false);
    const payload: ISearch = {
      restaurantName: restaurantName,
      customerRating: customerRating,
      distance: distance,
      price: price,
      cuisineId: 0,
      cuisineName: cuisineName
    };
    this._searchService.GetTopFiveRestaurantsFromSearch(payload)
      .subscribe(response =>
        this.searchResultsEvent?.emit(response)
      );
  }

  constructor(private readonly _searchService: SearchService) {
  }

}
