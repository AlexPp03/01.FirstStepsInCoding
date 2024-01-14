double yard = double.Parse(Console.ReadLine());

double price = yard * 7.61;
double discount = 0.18 * price;
double finalprice = price - discount;

Console.WriteLine($"The final price is: {finalprice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");



