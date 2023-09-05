//This code is supposed  to give a discount to users who renew their subscription early. The discount is determined by the number of days remaining on their subscription. The number of days remaining is stored in the daysUntilExpiration variable.
// The code should print the following messages:
// Your subscription expires within a day!
// Renew now and save 20%!
// Your subscription expires in 5 days.
// Renew now and save 10%!
// Your subscription expires in 10 days.
// Your subscription will expire soon.  Renew now!
// Your subscription has expired.

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
else
{
    Console.WriteLine("Your subscription will expire soon.  Renew now!");
}
