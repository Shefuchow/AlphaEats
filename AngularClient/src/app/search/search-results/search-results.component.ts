import { Component, Input } from '@angular/core';
import { ISearch } from '../../interfaces/i-search';

@Component({
  selector: 'app-search-results',
  templateUrl: './search-results.component.html',
  styleUrls: ['./search-results.component.scss']
})
export class SearchResultsComponent{
  @Input() public searchResult: ISearch;

}
