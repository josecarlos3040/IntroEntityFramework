using IntroEntityFramework.Models;

Console.WriteLine("Hello, World!");

SystemContext context = new SystemContext();

context.Database.EnsureCreated();


/* Create
Computer c1 = new Computer(1, "16GB", "i5");
context.Computers.Add(c1 );
context.SaveChanges();

Computer c2 = new Computer(2, "16GB", "i5");
context.Computers.Add(c2);
context.SaveChanges();

Computer c3 = new Computer(3, "8GB", "i5");
context.Computers.Add(c3);
context.SaveChanges();
*/

// Read
IEnumerable<Computer> computers = context.Computers.ToList();
foreach(var comp in computers)
{
    Console.WriteLine($"{comp.Id}, {comp.Ram}, {comp.Processor}");
}

// Read
Computer encontrado = context.Computers.Find(3);
Console.WriteLine($"Encontrado com Id 3: {encontrado.Ram}, {encontrado.Processor}");

//Update
encontrado.Ram="10Gb";
encontrado.Processor="amd";
context.Computers.Update(encontrado);

Computer atualizado = context.Computers.Find(3);
Console.WriteLine($"Atualizado com Id 3: {encontrado.Ram}, {encontrado.Processor}");

//Delete

