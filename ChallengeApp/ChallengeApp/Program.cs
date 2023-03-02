string myName = "Ewa";
var myAge = 33;
bool mezczyzna = false;

if (mezczyzna == false)
{
    if (myAge < 30 && myName == "Ewa")
        Console.WriteLine("Mloda kobieta");
    else if (myName == "Ewa" && myAge == 33)
        Console.WriteLine("Ewa ma 33 lat");
}
if (mezczyzna == true)
{
    if (myAge < 18)
        Console.WriteLine("Nieletni mezczyzna");
}
