using ConsoleApp1.DB;
using ConsoleApp1.DB.Model;
using ConsoleAppTestTgBot.Bot;

BotInitializer bot = new BotInitializer();
bot.Start();

TaskCompletionSource tcs = new TaskCompletionSource();

AppDomain.CurrentDomain.ProcessExit += (_, _) =>
{
bot.Stop();
tcs.SetResult();
};

Console.WriteLine("Нажмите CTRL+C для остановки");

await tcs.Task;

Console.WriteLine("Программа завершена");