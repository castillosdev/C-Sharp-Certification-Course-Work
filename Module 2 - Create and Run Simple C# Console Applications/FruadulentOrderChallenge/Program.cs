//This challenge is to filter out fraudulent orders from a list of orders. The fraudulent orders all start with the letter "B". The list of fraudulent orders is stored in the fraudulentOrderIDs array.
//The code should print the OrderID for any fraudulent order.

string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (var item in fraudulentOrderIDs)
{
   if (item.StartsWith("B"))
   {
       Console.WriteLine(item);
   }
}
