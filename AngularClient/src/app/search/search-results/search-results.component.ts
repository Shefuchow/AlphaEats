import { Component, Input } from '@angular/core';
import { IRestaurant } from '../../interfaces/i-restaurant';

@Component({
  selector: 'app-search-results',
  templateUrl: './search-results.component.html',
  styleUrls: ['./search-results.component.scss']
})
export class SearchResultsComponent{
  @Input() public restaurant?: IRestaurant;

}
