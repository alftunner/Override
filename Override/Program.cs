using Override;

DishwashingLiquid dosia = new DishwashingLiquid(1, 150,4,"Dosia", 0, "shit");
Sousage starodvorskaya = new Sousage(2, 1500,4,"Starodvorskaya", new DateTime(2022,5,8), 500.2, "копчёная");

Good[] goods =
{
    new DishwashingLiquid(1, 150,4,"Dosia", 0, "shit"),
    new Sousage(2, 1500,4,"Starodvorskaya", new DateTime(2022,5,8), 500.2, "копчёная")
};

Income.Come(goods, "Sousage", 10);