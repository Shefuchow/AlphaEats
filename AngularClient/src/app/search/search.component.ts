import { Component } from '@angular/core';
import { ISearch } from '../interfaces/i-search';
import { SearchService } from '../services/search.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.scss']
})

export class SearchComponent {
  public searchResults: ISearch[];
  public searchMessage: string = "Here's some choices!";
  public noResults: string = "Couldn't find any reccomendations :( \n Try Again!";

  public recieveSearchResults(searchResults: ISearch[]){
    this.searchResults = searchResults;
  }

  constructor (private readonly _searchService: SearchService) {
  }

}
