
export class Search {
  constructor(
    public restaurantName: string,
    public customerRating: number,
    public distance: number,
    public price: number,
    public cuisineId: number,
    public cuisineName: string
  ) {}
}
