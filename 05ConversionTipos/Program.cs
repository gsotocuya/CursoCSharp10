byte b = 200;
long l = 2000;
string cadena = "2000";
string cadena2 = "2000";
long bl = b;
byte lb = (byte)l;
decimal d = Convert.ToDecimal(cadena);
decimal e = 0m; //Decimal.Parse(cadena2);
int i = Convert.ToInt32("2");
DateTime fecha = Convert.ToDateTime("2022-03-29");
if(Decimal.TryParse(cadena2, out e))
    Console.WriteLine("el valo del decimal e es: {0}", e);
else
    Console.WriteLine("La conversión no se pudo realizar");
Console.WriteLine("El valor de long bl es: {0}", bl);
Console.WriteLine("El valor del byte lb es: {0}", lb);
Console.WriteLine("El valor del decimal d es: {0}", d);
Console.WriteLine(i.ToString());
Console.WriteLine(fecha.ToShortDateString());

