using ExChainOfResponsabilty;

var validator = new LengthValidator();
var digit = new DigitValidator();
var upper = new UpperValidator();
var special = new SpecialValidator();

validator.Successor(digit)
    .Successor(upper)
    .Successor(special);

Console.WriteLine("Inserisci password da validare: ");
string password = Console.ReadLine();

var error = validator.Validate(password);

try
{
    if (error.errorMessage.Any())
    {
        Console.WriteLine("Password non valida");
        error.Print();
    } else
    {
        Console.WriteLine("Password valida");
    }


} catch (Exception)
{
    Console.WriteLine("Errore nel log error");
}