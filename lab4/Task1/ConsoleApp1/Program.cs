using ConsoleApp1;
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
MachineHandler machineHandler = new MachineHandler();
DefaultConsultant defaultConsultant = new DefaultConsultant();
Engineer engineer = new Engineer();
Boss boss = new Boss();

machineHandler.SetNext(defaultConsultant).SetNext(engineer).SetNext(boss).SetNext(machineHandler);

Console.WriteLine("Тестування ланцюжка обробників");

Console.WriteLine("Починаємо обробку запиту");

object response = machineHandler.Handle("test request");

Console.WriteLine("Відповідь: " + response);