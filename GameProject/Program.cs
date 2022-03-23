// See https://aka.ms/new-console-template for more information

using GameProject.Concrete;

GamerManager gamerManager = new GamerManager();
gamerManager.Register(new Gamer { FirstName="Ömer Faruk",LastName="Didin",DateOfBirth=new DateTime(2001,05,16),NationalityId="33883446262"});

GameManager gameManager = new GameManager();
gameManager.GameSales(new Gamer { FirstName = "Ömer Faruk", LastName = "Didin", DateOfBirth = new DateTime(2001, 05, 16), NationalityId = "33883446262" }, new Game { Id = 51,GameName="Valorant",DiscountedPrice=25,UnitPrice=59 });



