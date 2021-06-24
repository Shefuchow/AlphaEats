using System;
using System.Linq;
using AlphaEats;
using AlphaEats.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AlphaEats.Api
{
    public class ApplicationDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())

            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                // seed the database with given data


                Console.WriteLine("Seeding data to Cuisine table");

                if (!context.Cuisines.Any())
                {
                    context.Cuisines.AddRange(
                    
        
                            new Cuisine
                            {
                                Id = 1,
                                Name = "American"
                            },
                            new Cuisine
                            {
                                Id = 2,
                                Name = "Chinese"
                            },
                            new Cuisine
                            {
                                Id = 3,
                                Name = "Thai"
                            },
                            new Cuisine
                            {
                                Id = 4,
                                Name = "Italian"
                            },
                            new Cuisine
                            {
                                Id = 5,
                                Name = "French"
                            },
                            new Cuisine
                            {
                                Id = 6,
                                Name = "Japanese"
                            },
                            new Cuisine
                            {
                                Id = 7,
                                Name = "Turkish"
                            },
                            new Cuisine
                            {
                                Id = 8,
                                Name = "Korean"
                            },
                            new Cuisine
                            {
                                Id = 9,
                                Name = "Vietnamese"
                            },
                            new Cuisine
                            {
                                Id = 10,
                                Name = "Indian"
                            },
                            new Cuisine
                            {
                                Id = 11,
                                Name = "Spanish"
                            },
                            new Cuisine
                            {
                                Id = 12,
                                Name = "Greek"
                            },
                            new Cuisine
                            {
                                Id = 13,
                                Name = "Mexican"
                            },
                            new Cuisine
                            {
                                Id = 14,
                                Name = "Malaysian"
                            },
                            new Cuisine
                            {
                                Id = 15,
                                Name = "African"
                            },
                            new Cuisine
                            {
                                Id = 16,
                                Name = "German"
                            },
                            new Cuisine
                            {
                                Id = 17,
                                Name = "Indonesian"
                            },
                            new Cuisine
                            {
                                Id = 18,
                                Name = "Russian"
                            },
                            new Cuisine
                            {
                                Id = 19,
                                Name = "Other"
                            }    
                    );

                    Console.WriteLine("Seeding data to Restaurant table");

                    if (!context.Restaurants.Any())
                    {
                        context.Restaurants.AddRange(

                        new Restaurant
                        {
                            Name = "Deliciousgenix",
                            CustomerRating = 4,
                            Distance = 1,
                            Price = 10,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Herbed Delicious",
                            CustomerRating = 4,
                            Distance = 7,
                            Price = 20,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Deliciousscape",
                            CustomerRating = 3,
                            Distance = 7,
                            Price = 50,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Hideaway Delicious",
                            CustomerRating = 2,
                            Distance = 5,
                            Price = 40,
                            CuisineId = 12
                        },
                        new Restaurant
                        {
                            Name = "Cuts Delicious",
                            CustomerRating = 3,
                            Distance = 9,
                            Price = 25,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Lord Delicious",
                            CustomerRating = 1,
                            Distance = 7,
                            Price = 35,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Hilltop Delicious",
                            CustomerRating = 3,
                            Distance = 3,
                            Price = 45,
                            CuisineId = 6
                        },
                        new Restaurant
                        {
                            Name = "Fine Delicious",
                            CustomerRating = 4,
                            Distance = 5,
                            Price = 45,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Deliciousish",
                            CustomerRating = 1,
                            Distance = 3,
                            Price = 50,
                            CuisineId = 12
                        },
                        new Restaurant
                        {
                            Name = "Havana Delicious",
                            CustomerRating = 3,
                            Distance = 1,
                            Price = 35,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Deliciouspad",
                            CustomerRating = 3,
                            Distance = 10,
                            Price = 40,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Deliciousbea",
                            CustomerRating = 5,
                            Distance = 6,
                            Price = 50,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Deliciousquipo",
                            CustomerRating = 2,
                            Distance = 2,
                            Price = 10,
                            CuisineId = 19
                        },
                        new Restaurant
                        {
                            Name = "Fed Delicious",
                            CustomerRating = 2,
                            Distance = 9,
                            Price = 35,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Hotspot Delicious",
                            CustomerRating = 4,
                            Distance = 10,
                            Price = 25,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Gusto Delicious",
                            CustomerRating = 5,
                            Distance = 3,
                            Price = 50,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Deliciouszen",
                            CustomerRating = 2,
                            Distance = 6,
                            Price = 30,
                            CuisineId = 5
                        },
                        new Restaurant
                        {
                            Name = "Deliciouszilla",
                            CustomerRating = 4,
                            Distance = 1,
                            Price = 15,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Deliciousio",
                            CustomerRating = 5,
                            Distance = 9,
                            Price = 40,
                            CuisineId = 19
                        },
                        new Restaurant
                        {
                            Name = "Local Delicious",
                            CustomerRating = 5,
                            Distance = 4,
                            Price = 20,
                            CuisineId = 12
                        },
                        new Restaurant
                        {
                            Name = "Crisp Delicious",
                            CustomerRating = 5,
                            Distance = 2,
                            Price = 45,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Deliciousoryx",
                            CustomerRating = 1,
                            Distance = 5,
                            Price = 25,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Bang Delicious",
                            CustomerRating = 5,
                            Distance = 2,
                            Price = 15,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Deliciouszoid",
                            CustomerRating = 3,
                            Distance = 2,
                            Price = 30,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Hearty ChowClick",
                            CustomerRating = 2,
                            Distance = 6,
                            Price = 25,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Traditional Chow",
                            CustomerRating = 5,
                            Distance = 2,
                            Price = 15,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Bash Chow",
                            CustomerRating = 2,
                            Distance = 6,
                            Price = 45,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Minty Chow",
                            CustomerRating = 4,
                            Distance = 8,
                            Price = 35,
                            CuisineId = 5
                        },
                        new Restaurant
                        {
                            Name = "Chowaza",
                            CustomerRating = 3,
                            Distance = 9,
                            Price = 20,
                            CuisineId = 12
                        },
                        new Restaurant
                        {
                            Name = "Lucha Chow",
                            CustomerRating = 3,
                            Distance = 4,
                            Price = 25,
                            CuisineId = 14
                        },
                        new Restaurant
                        {
                            Name = "Hut Chow",
                            CustomerRating = 2,
                            Distance = 2,
                            Price = 10,
                            CuisineId = 3
                        },
                        new Restaurant
                        {
                            Name = "Wish Chow",
                            CustomerRating = 3,
                            Distance = 1,
                            Price = 40,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Chowish",
                            CustomerRating = 3,
                            Distance = 8,
                            Price = 10,
                            CuisineId = 19
                        },
                        new Restaurant
                        {
                            Name = "Bazaar Chow",
                            CustomerRating = 4,
                            Distance = 4,
                            Price = 40,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Story Chow",
                            CustomerRating = 2,
                            Distance = 10,
                            Price = 30,
                            CuisineId = 19
                        },
                        new Restaurant
                        {
                            Name = "Hideout Chow",
                            CustomerRating = 2,
                            Distance = 7,
                            Price = 10,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Strip Chow",
                            CustomerRating = 5,
                            Distance = 9,
                            Price = 35,
                            CuisineId = 19
                        },
                        new Restaurant
                        {
                            Name = "Aroma Chow",
                            CustomerRating = 5,
                            Distance = 10,
                            Price = 10,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Chowology",
                            CustomerRating = 5,
                            Distance = 9,
                            Price = 30,
                            CuisineId = 6
                        },
                        new Restaurant
                        {
                            Name = "Chowify",
                            CustomerRating = 4,
                            Distance = 4,
                            Price = 45,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Piece Chow",
                            CustomerRating = 4,
                            Distance = 9,
                            Price = 10,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Cave Chow",
                            CustomerRating = 3,
                            Distance = 4,
                            Price = 40,
                            CuisineId = 6
                        },
                        new Restaurant
                        {
                            Name = "Wagon Chow",
                            CustomerRating = 3,
                            Distance = 9,
                            Price = 10,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Choworyx",
                            CustomerRating = 2,
                            Distance = 3,
                            Price = 40,
                            CuisineId = 7
                        },
                        new Restaurant
                        {
                            Name = "Whole Chow",
                            CustomerRating = 2,
                            Distance = 7,
                            Price = 15,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Central Chow",
                            CustomerRating = 3,
                            Distance = 7,
                            Price = 45,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Ambrosial Chow",
                            CustomerRating = 4,
                            Distance = 5,
                            Price = 50,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Place Chow",
                            CustomerRating = 2,
                            Distance = 2,
                            Price = 15,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Reservation Table",
                            CustomerRating = 4,
                            Distance = 3,
                            Price = 20,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Chopped Table",
                            CustomerRating = 1,
                            Distance = 5,
                            Price = 40,
                            CuisineId = 3
                        },
                        new Restaurant
                        {
                            Name = "Herbed Table",
                            CustomerRating = 1,
                            Distance = 1,
                            Price = 15,
                            CuisineId = 12
                        },
                        new Restaurant
                        {
                            Name = "Palate Table",
                            CustomerRating = 1,
                            Distance = 1,
                            Price = 15,
                            CuisineId = 14
                        },
                        new Restaurant
                        {
                            Name = "Grove Table",
                            CustomerRating = 5,
                            Distance = 2,
                            Price = 10,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Fodder Table",
                            CustomerRating = 4,
                            Distance = 1,
                            Price = 20,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Tablebes",
                            CustomerRating = 4,
                            Distance = 2,
                            Price = 40,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Chow Table",
                            CustomerRating = 1,
                            Distance = 1,
                            Price = 10,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Bay Table",
                            CustomerRating = 3,
                            Distance = 7,
                            Price = 50,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Tablebea",
                            CustomerRating = 1,
                            Distance = 7,
                            Price = 25,
                            CuisineId = 10
                        },
                        new Restaurant
                        {
                            Name = "Fine Table",
                            CustomerRating = 2,
                            Distance = 5,
                            Price = 15,
                            CuisineId = 12
                        },
                        new Restaurant
                        {
                            Name = "Cellar Table",
                            CustomerRating = 4,
                            Distance = 8,
                            Price = 25,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Boy Table",
                            CustomerRating = 3,
                            Distance = 9,
                            Price = 30,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Tableomatic",
                            CustomerRating = 1,
                            Distance = 5,
                            Price = 20,
                            CuisineId = 16
                        },
                        new Restaurant
                        {
                            Name = "Tableque",
                            CustomerRating = 4,
                            Distance = 3,
                            Price = 10,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Tableio",
                            CustomerRating = 3,
                            Distance = 3,
                            Price = 40,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Tableoont",
                            CustomerRating = 5,
                            Distance = 10,
                            Price = 20,
                            CuisineId = 12
                        },
                        new Restaurant
                        {
                            Name = "Tableadora",
                            CustomerRating = 5,
                            Distance = 2,
                            Price = 25,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Tableooze",
                            CustomerRating = 3,
                            Distance = 1,
                            Price = 50,
                            CuisineId = 16
                        },
                        new Restaurant
                        {
                            Name = "Garnish Table",
                            CustomerRating = 4,
                            Distance = 9,
                            Price = 40,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Brew Table",
                            CustomerRating = 2,
                            Distance = 10,
                            Price = 15,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Hotspot Table",
                            CustomerRating = 3,
                            Distance = 7,
                            Price = 40,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Fresh Table",
                            CustomerRating = 3,
                            Distance = 2,
                            Price = 30,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Appetite Table",
                            CustomerRating = 1,
                            Distance = 10,
                            Price = 40,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Cave Tasty",
                            CustomerRating = 5,
                            Distance = 10,
                            Price = 15,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Whole Tasty",
                            CustomerRating = 1,
                            Distance = 1,
                            Price = 30,
                            CuisineId = 5
                        },
                        new Restaurant
                        {
                            Name = "Tastyio",
                            CustomerRating = 3,
                            Distance = 10,
                            Price = 30,
                            CuisineId = 14
                        },
                        new Restaurant
                        {
                            Name = "Lane Tasty",
                            CustomerRating = 5,
                            Distance = 5,
                            Price = 35,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Nouveau Tasty",
                            CustomerRating = 1,
                            Distance = 9,
                            Price = 50,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Relish Tasty",
                            CustomerRating = 3,
                            Distance = 8,
                            Price = 50,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Tastyooze",
                            CustomerRating = 3,
                            Distance = 6,
                            Price = 20,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Binge Tasty",
                            CustomerRating = 1,
                            Distance = 8,
                            Price = 10,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Fed Tasty",
                            CustomerRating = 3,
                            Distance = 5,
                            Price = 25,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Diced Tasty",
                            CustomerRating = 5,
                            Distance = 4,
                            Price = 40,
                            CuisineId = 7
                        },
                        new Restaurant
                        {
                            Name = "Tastylux",
                            CustomerRating = 5,
                            Distance = 8,
                            Price = 35,
                            CuisineId = 14
                        },
                        new Restaurant
                        {
                            Name = "Tastyaza",
                            CustomerRating = 3,
                            Distance = 7,
                            Price = 45,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Grill Tasty",
                            CustomerRating = 2,
                            Distance = 2,
                            Price = 30,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Tastyopolis",
                            CustomerRating = 1,
                            Distance = 6,
                            Price = 20,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Stand Tasty",
                            CustomerRating = 4,
                            Distance = 3,
                            Price = 40,
                            CuisineId = 16
                        },
                        new Restaurant
                        {
                            Name = "Feast Tasty",
                            CustomerRating = 2,
                            Distance = 8,
                            Price = 20,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Baby Tasty",
                            CustomerRating = 3,
                            Distance = 1,
                            Price = 20,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Fodder Tasty",
                            CustomerRating = 4,
                            Distance = 4,
                            Price = 30,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Takeout Tasty",
                            CustomerRating = 5,
                            Distance = 5,
                            Price = 20,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Wrap Tasty",
                            CustomerRating = 1,
                            Distance = 10,
                            Price = 30,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Tastylia",
                            CustomerRating = 3,
                            Distance = 4,
                            Price = 50,
                            CuisineId = 3
                        },
                        new Restaurant
                        {
                            Name = "Havana Tasty",
                            CustomerRating = 4,
                            Distance = 10,
                            Price = 15,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Crumb Tasty",
                            CustomerRating = 2,
                            Distance = 5,
                            Price = 25,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Dished Tasty",
                            CustomerRating = 1,
                            Distance = 7,
                            Price = 25,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Chop Grill",
                            CustomerRating = 5,
                            Distance = 8,
                            Price = 10,
                            CuisineId = 17
                        },
                        new Restaurant
                        {
                            Name = "Festive Grill",
                            CustomerRating = 2,
                            Distance = 4,
                            Price = 35,
                            CuisineId = 6
                        },
                        new Restaurant
                        {
                            Name = "Me Grill",
                            CustomerRating = 5,
                            Distance = 5,
                            Price = 25,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Lounge Grill",
                            CustomerRating = 3,
                            Distance = 10,
                            Price = 40,
                            CuisineId = 5
                        },
                        new Restaurant
                        {
                            Name = "Coastal Grill",
                            CustomerRating = 2,
                            Distance = 7,
                            Price = 10,
                            CuisineId = 17
                        },
                        new Restaurant
                        {
                            Name = "Perfection Grill",
                            CustomerRating = 3,
                            Distance = 3,
                            Price = 50,
                            CuisineId = 7
                        },
                        new Restaurant
                        {
                            Name = "Hungry Grill",
                            CustomerRating = 3,
                            Distance = 4,
                            Price = 50,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Cater Grill",
                            CustomerRating = 4,
                            Distance = 3,
                            Price = 50,
                            CuisineId = 5
                        },
                        new Restaurant
                        {
                            Name = "Presto Grill",
                            CustomerRating = 5,
                            Distance = 2,
                            Price = 40,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Crispy Grill",
                            CustomerRating = 1,
                            Distance = 7,
                            Price = 45,
                            CuisineId = 19
                        },
                        new Restaurant
                        {
                            Name = "Grilltastic",
                            CustomerRating = 3,
                            Distance = 3,
                            Price = 30,
                            CuisineId = 14
                        },
                        new Restaurant
                        {
                            Name = "Grillsio",
                            CustomerRating = 3,
                            Distance = 4,
                            Price = 15,
                            CuisineId = 19
                        },
                        new Restaurant
                        {
                            Name = "Tasteful Grill",
                            CustomerRating = 5,
                            Distance = 9,
                            Price = 10,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Yummy Grill",
                            CustomerRating = 1,
                            Distance = 8,
                            Price = 50,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Crisp Grill",
                            CustomerRating = 2,
                            Distance = 6,
                            Price = 50,
                            CuisineId = 19
                        },
                        new Restaurant
                        {
                            Name = "Grillya",
                            CustomerRating = 2,
                            Distance = 7,
                            Price = 40,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Cuts Grill",
                            CustomerRating = 1,
                            Distance = 7,
                            Price = 30,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Grillarc",
                            CustomerRating = 2,
                            Distance = 3,
                            Price = 25,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Wish Grill",
                            CustomerRating = 1,
                            Distance = 8,
                            Price = 30,
                            CuisineId = 3
                        },
                        new Restaurant
                        {
                            Name = "Dished Grill",
                            CustomerRating = 3,
                            Distance = 1,
                            Price = 10,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Divine Grill",
                            CustomerRating = 1,
                            Distance = 9,
                            Price = 25,
                            CuisineId = 7
                        },
                        new Restaurant
                        {
                            Name = "Wedge Grill",
                            CustomerRating = 2,
                            Distance = 4,
                            Price = 35,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Gusto Grill",
                            CustomerRating = 3,
                            Distance = 10,
                            Price = 10,
                            CuisineId = 3
                        },
                        new Restaurant
                        {
                            Name = "Chef Grill",
                            CustomerRating = 5,
                            Distance = 4,
                            Price = 35,
                            CuisineId = 19
                        },
                        new Restaurant
                        {
                            Name = "Grove Palace",
                            CustomerRating = 2,
                            Distance = 4,
                            Price = 20,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Tasteful Palace",
                            CustomerRating = 2,
                            Distance = 3,
                            Price = 20,
                            CuisineId = 12
                        },
                        new Restaurant
                        {
                            Name = "Perfection Palace",
                            CustomerRating = 3,
                            Distance = 1,
                            Price = 20,
                            CuisineId = 3
                        },
                        new Restaurant
                        {
                            Name = "Palaceio",
                            CustomerRating = 4,
                            Distance = 7,
                            Price = 45,
                            CuisineId = 14
                        },
                        new Restaurant
                        {
                            Name = "Palaceado",
                            CustomerRating = 3,
                            Distance = 6,
                            Price = 25,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Flavor Palace",
                            CustomerRating = 2,
                            Distance = 2,
                            Price = 20,
                            CuisineId = 14
                        },
                        new Restaurant
                        {
                            Name = "Palaceadri",
                            CustomerRating = 4,
                            Distance = 8,
                            Price = 50,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Hotspot Palace",
                            CustomerRating = 1,
                            Distance = 3,
                            Price = 35,
                            CuisineId = 3
                        },
                        new Restaurant
                        {
                            Name = "Palaceopedia",
                            CustomerRating = 5,
                            Distance = 10,
                            Price = 25,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Gusto Palace",
                            CustomerRating = 5,
                            Distance = 10,
                            Price = 30,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Feed Palace",
                            CustomerRating = 2,
                            Distance = 5,
                            Price = 20,
                            CuisineId = 7
                        },
                        new Restaurant
                        {
                            Name = "Smash Palace",
                            CustomerRating = 1,
                            Distance = 9,
                            Price = 10,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Gnaw Palace",
                            CustomerRating = 1,
                            Distance = 3,
                            Price = 50,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Dished Palace",
                            CustomerRating = 5,
                            Distance = 7,
                            Price = 25,
                            CuisineId = 5
                        },
                        new Restaurant
                        {
                            Name = "Spicy PalaceClick to check domain availability.",
                            CustomerRating = 2,
                            Distance = 6,
                            Price = 10,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Nouveau Palace",
                            CustomerRating = 3,
                            Distance = 8,
                            Price = 15,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Relish Palace",
                            CustomerRating = 2,
                            Distance = 3,
                            Price = 40,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Palaceistic",
                            CustomerRating = 2,
                            Distance = 10,
                            Price = 45,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Palacearo",
                            CustomerRating = 1,
                            Distance = 4,
                            Price = 50,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Place Palace",
                            CustomerRating = 5,
                            Distance = 2,
                            Price = 40,
                            CuisineId = 17
                        },
                        new Restaurant
                        {
                            Name = "Aroma Palace",
                            CustomerRating = 2,
                            Distance = 5,
                            Price = 40,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Fury Palace",
                            CustomerRating = 5,
                            Distance = 3,
                            Price = 30,
                            CuisineId = 17
                        },
                        new Restaurant
                        {
                            Name = "Palacex",
                            CustomerRating = 2,
                            Distance = 6,
                            Price = 15,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Palaceocity",
                            CustomerRating = 1,
                            Distance = 7,
                            Price = 25,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Ambrosial Yummy",
                            CustomerRating = 3,
                            Distance = 7,
                            Price = 50,
                            CuisineId = 17
                        },
                        new Restaurant
                        {
                            Name = "Nibble Yummy",
                            CustomerRating = 1,
                            Distance = 8,
                            Price = 15,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Accent Yummy",
                            CustomerRating = 5,
                            Distance = 3,
                            Price = 40,
                            CuisineId = 17
                        },
                        new Restaurant
                        {
                            Name = "Yummylia",
                            CustomerRating = 1,
                            Distance = 1,
                            Price = 40,
                            CuisineId = 5
                        },
                        new Restaurant
                        {
                            Name = "Hotspot Yummy",
                            CustomerRating = 1,
                            Distance = 3,
                            Price = 45,
                            CuisineId = 17
                        },
                        new Restaurant
                        {
                            Name = "Chef Yummy",
                            CustomerRating = 4,
                            Distance = 9,
                            Price = 10,
                            CuisineId = 12
                        },
                        new Restaurant
                        {
                            Name = "Acclaimed Yummy",
                            CustomerRating = 5,
                            Distance = 8,
                            Price = 50,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Yummyella",
                            CustomerRating = 2,
                            Distance = 3,
                            Price = 40,
                            CuisineId = 6
                        },
                        new Restaurant
                        {
                            Name = "Palace Yummy",
                            CustomerRating = 4,
                            Distance = 2,
                            Price = 50,
                            CuisineId = 19
                        },
                        new Restaurant
                        {
                            Name = "Sizzle Yummy",
                            CustomerRating = 3,
                            Distance = 1,
                            Price = 15,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Galore Yummy",
                            CustomerRating = 2,
                            Distance = 9,
                            Price = 40,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Yummyquipo",
                            CustomerRating = 2,
                            Distance = 3,
                            Price = 45,
                            CuisineId = 7
                        },
                        new Restaurant
                        {
                            Name = "Divine Yummy",
                            CustomerRating = 1,
                            Distance = 10,
                            Price = 25,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Aladdin Yummy",
                            CustomerRating = 1,
                            Distance = 4,
                            Price = 30,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Yummyscape",
                            CustomerRating = 1,
                            Distance = 3,
                            Price = 35,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Yummylance",
                            CustomerRating = 1,
                            Distance = 9,
                            Price = 10,
                            CuisineId = 6
                        },
                        new Restaurant
                        {
                            Name = "Crisp Yummy",
                            CustomerRating = 1,
                            Distance = 10,
                            Price = 25,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Cantina Yummy",
                            CustomerRating = 5,
                            Distance = 6,
                            Price = 20,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Cellar Yummy",
                            CustomerRating = 2,
                            Distance = 8,
                            Price = 50,
                            CuisineId = 6
                        },
                        new Restaurant
                        {
                            Name = "Festive Yummy",
                            CustomerRating = 2,
                            Distance = 2,
                            Price = 25,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Upscale Yummy",
                            CustomerRating = 2,
                            Distance = 10,
                            Price = 45,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Lucha Yummy",
                            CustomerRating = 1,
                            Distance = 10,
                            Price = 40,
                            CuisineId = 3
                        },
                        new Restaurant
                        {
                            Name = "Diced Yummy",
                            CustomerRating = 5,
                            Distance = 3,
                            Price = 20,
                            CuisineId = 14
                        },
                        new Restaurant
                        {
                            Name = "Factory Yummy",
                            CustomerRating = 4,
                            Distance = 3,
                            Price = 15,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Dude Kitchen",
                            CustomerRating = 4,
                            Distance = 10,
                            Price = 35,
                            CuisineId = 5
                        },
                        new Restaurant
                        {
                            Name = "Kitchengenics",
                            CustomerRating = 4,
                            Distance = 3,
                            Price = 20,
                            CuisineId = 8
                        },
                        new Restaurant
                        {
                            Name = "Galore Kitchen",
                            CustomerRating = 5,
                            Distance = 10,
                            Price = 45,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Story Kitchen",
                            CustomerRating = 5,
                            Distance = 3,
                            Price = 20,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Kitchenbia",
                            CustomerRating = 2,
                            Distance = 1,
                            Price = 30,
                            CuisineId = 12
                        },
                        new Restaurant
                        {
                            Name = "Fuel Kitchen",
                            CustomerRating = 4,
                            Distance = 7,
                            Price = 40,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Dished Kitchen",
                            CustomerRating = 5,
                            Distance = 3,
                            Price = 30,
                            CuisineId = 14
                        },
                        new Restaurant
                        {
                            Name = "Kitchenish",
                            CustomerRating = 3,
                            Distance = 2,
                            Price = 20,
                            CuisineId = 6
                        },
                        new Restaurant
                        {
                            Name = "Bang Kitchen",
                            CustomerRating = 1,
                            Distance = 1,
                            Price = 40,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Bit Kitchen",
                            CustomerRating = 1,
                            Distance = 1,
                            Price = 30,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Kitchenlia",
                            CustomerRating = 2,
                            Distance = 7,
                            Price = 50,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Kitchenster",
                            CustomerRating = 2,
                            Distance = 1,
                            Price = 10,
                            CuisineId = 1
                        },
                        new Restaurant
                        {
                            Name = "Devine Kitchen",
                            CustomerRating = 3,
                            Distance = 9,
                            Price = 30,
                            CuisineId = 16
                        },
                        new Restaurant
                        {
                            Name = "Connoisseur Kitchen",
                            CustomerRating = 2,
                            Distance = 6,
                            Price = 30,
                            CuisineId = 19
                        },
                        new Restaurant
                        {
                            Name = "Munchies Kitchen",
                            CustomerRating = 5,
                            Distance = 5,
                            Price = 45,
                            CuisineId = 9
                        },
                        new Restaurant
                        {
                            Name = "Fine Kitchen",
                            CustomerRating = 2,
                            Distance = 10,
                            Price = 20,
                            CuisineId = 17
                        },
                        new Restaurant
                        {
                            Name = "Crisp Kitchen",
                            CustomerRating = 1,
                            Distance = 3,
                            Price = 35,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Hut Kitchen",
                            CustomerRating = 3,
                            Distance = 5,
                            Price = 10,
                            CuisineId = 17
                        },
                        new Restaurant
                        {
                            Name = "Kitchenvio",
                            CustomerRating = 3,
                            Distance = 1,
                            Price = 50,
                            CuisineId = 12
                        },
                        new Restaurant
                        {
                            Name = "Kitchenarc",
                            CustomerRating = 2,
                            Distance = 5,
                            Price = 10,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Kitchenry",
                            CustomerRating = 4,
                            Distance = 6,
                            Price = 40,
                            CuisineId = 11
                        },
                        new Restaurant
                        {
                            Name = "Safety Kitchen",
                            CustomerRating = 2,
                            Distance = 4,
                            Price = 20,
                            CuisineId = 6
                        },
                        new Restaurant
                        {
                            Name = "Smash Kitchen",
                            CustomerRating = 1,
                            Distance = 2,
                            Price = 50,
                            CuisineId = 7
                        },
                        new Restaurant
                        {
                            Name = "Brew Kitchen",
                            CustomerRating = 2,
                            Distance = 4,
                            Price = 40,
                            CuisineId = 18
                        },
                        new Restaurant
                        {
                            Name = "Connoisseur Bar",
                            CustomerRating = 2,
                            Distance = 2,
                            Price = 25,
                            CuisineId = 17
                        },
                        new Restaurant
                        {
                            Name = "Bariva",
                            CustomerRating = 5,
                            Distance = 10,
                            Price = 40,
                            CuisineId = 10
                        },
                        new Restaurant
                        {
                            Name = "Barscape",
                            CustomerRating = 3,
                            Distance = 4,
                            Price = 15,
                            CuisineId = 4
                        },
                        new Restaurant
                        {
                            Name = "Hot Bar",
                            CustomerRating = 4,
                            Distance = 4,
                            Price = 20,
                            CuisineId = 2
                        },
                        new Restaurant
                        {
                            Name = "Place Bar",
                            CustomerRating = 3,
                            Distance = 5,
                            Price = 50,
                            CuisineId = 13
                        },
                        new Restaurant
                        {
                            Name = "Grill Bar",
                            CustomerRating = 1,
                            Distance = 9,
                            Price = 40,
                            CuisineId = 5
                        },
                        new Restaurant
                        {
                            Name = "Dine Bar",
                            CustomerRating = 5,
                            Distance = 10,
                            Price = 35,
                            CuisineId = 15
                        },
                        new Restaurant
                        {
                            Name = "Wave Bar",
                            CustomerRating = 4,
                            Distance = 8,
                            Price = 20,
                            CuisineId = 3
                        }
                    );
                    }

                    //save changes
                    context.SaveChanges();

                }
            }
        }
    }
}
