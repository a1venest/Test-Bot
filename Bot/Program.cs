using Telegram.Bot;

string token = "5637986180:AAHQ_sAH3OfgyyanBUFAfa8tiyqhe650vaA";
var client = new TelegramBotClient(token);

string GetAnswer(string msg)
{
    string answer = "🤝";
    if (msg.Contains("hi"))
    {
        answer = "Дратути!";
    }
    return answer;
}

client.StartReceiving(
(c, arg, _) =>
{
    return c.SendTextMessageAsync(arg.Message.Chat.Id,
    GetAnswer(arg.Message.Text.ToLower()));
},
(_, _, _) => Task.CompletedTask

);
Console.WriteLine("StartReceiving ...");
Console.ReadLine();
