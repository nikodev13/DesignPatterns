// See https://aka.ms/new-console-template for more information

using Strategy;

var map = new Map(new BikeRouteStrategy());
map.CreateRoute(new Coordinate(1,1), new Coordinate(2,2));