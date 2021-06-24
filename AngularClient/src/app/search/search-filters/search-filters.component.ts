import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-search-filters',
  templateUrl: './search-filters.component.html',
  styleUrls: ['./search-filters.component.scss']
})
export class SearchFiltersComponent{
  public buttonClass = "disabled";
  public errorMessage = "";
  //Arrays to populate option tags
  distances: any[] = [
    {value: 2, tag: "~2mi"},
    {value: 4, tag: "~4mi"},
    {value: 6, tag: "~6mi"},
    {value: 8, tag: "~8mi"},
    {value: 10, tag: "~10mi"},
  ];

  ratings = [1,2,3,4,5];

  prices: any[] = [
    {value: 10, tag: "~ $10"},
    {value: 20, tag: "~ $20"},
    {value: 30, tag: "~ $30"},
    {value: 40, tag: "~ $40"},
    {value: 50, tag: "~ $50"},
  ];

}
