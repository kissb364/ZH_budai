using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Taskok
{
    internal class Program
    {
        static async Task Egyes(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("*");
                await Task.Delay(100);
            }
        }

        static async Task Kettes(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("x");
                await Task.Delay(100);
            }
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("A task-ok elindultak.");
            Console.WriteLine("\nNyomj meg egy billentyűt a task-ok leállításához...");

            using (var cancellationTokenSource = new CancellationTokenSource())
            {
                // Várakozás a gombnyomásra a leállításhoz
                var keyPressedTask = Task.Run(() =>
                {
                    Console.ReadKey();
                });

                var token = cancellationTokenSource.Token;

                var taskEgyes = Egyes(token);
                var taskKettes = Kettes(token);

                // Várakozás arra, hogy bármelyik task befejeződjön
                await Task.WhenAny(keyPressedTask, Task.WhenAll(taskEgyes, taskKettes));

                // Ha a felhasználó lenyomta a billentyűt, leállítjuk a task-okat
                cancellationTokenSource.Cancel();

                // Várakozás a task-ok befejeződésére
                await Task.WhenAll(taskEgyes, taskKettes);
            }
                Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nA task-ok leálltak.");
            Thread.Sleep(3000);
        }
    }
}
