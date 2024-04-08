//Ex3
//Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
//tastaura


Console.WriteLine("Scrieti un numar:");
BigInteger numar = BigInteger.Parse(Console.ReadLine());

BigInteger ultimulnumar = numar % (10);  
Console.WriteLine("Ultima cifra din numarul" + " " + numar  + " " + "este" + " " + ultimulnumar);
