using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

namespace ConsoleAppTestTgBot.Bot;

public class BotInitializer
{
    private TelegramBotClient _botClient;
    private CancellationTokenSource _cancellationTokenSource;

    public BotInitializer()
    {
        _botClient = new TelegramBotClient("6450571149:AAGRChBNQZr65Jo5Em7Soz9177Rcc8-q22E");
        _cancellationTokenSource = new CancellationTokenSource();
        
        Console.WriteLine("Выполнена инициализация Бота");
    }
    
    public void Start()
    {
        ReceiverOptions receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = Array.Empty<UpdateType>()
        };

        BotRequestHandlers botRequestHandlers = new BotRequestHandlers();

        _botClient.StartReceiving(
            botRequestHandlers.HandleUpdateAsync,
            botRequestHandlers.HandlePollingErrorAsync,
            receiverOptions,
            _cancellationTokenSource.Token
        );
        
        Console.WriteLine("Бот запущен");
    }

    public void Stop()
    {
        _cancellationTokenSource.Cancel();
        
        Console.WriteLine("Бот остановлен");
    }
}