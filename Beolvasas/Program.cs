using Beolvasas.Data;

var _context = new PersonContext();

if (!_context.Persons.Any())
{
    var lines = File.ReadAllLines(@"C:\Users\Laptop\Desktop\Suli\Datas\9.csv").Skip(1);
    foreach (var line in lines)
    {
        _context.Persons.Add(new Beolvasas.Models.Person(line));
    }
    _context.SaveChanges();
    Console.WriteLine("Emberek feltöltése sikeres!");
}

foreach (var item in _context.Persons)
{
    Console.WriteLine(item);
    Console.WriteLine();
}