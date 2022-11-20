using System.Net.Http;

// JSON (текстовый формат обмена данными, основанный на JavaScript. 
// Используется для передачи данных между клиентом и сервером):
// {
//     "ok": true,
//     "result": {
//         "id": 5825155230,
//         "is_bot": true,
//         "first_name": "\u041c\u0438\u0441\u0442\u0435\u0440 \u0411\u043e\u0442",
//         "username": "MisssssterBot",
//         "can_join_groups": true,
//         "can_read_all_group_messages": false,
//         "supports_inline_queries": false
//     }
// }

/*
//json в csharp
class GetMeModel
{
    bool ok;
    Result result;
}

class Result
{
    long id;
    bool is_bot;
    string? first_name;
    string? username;
    bool can_join_groups;
    bool can_read_all_group_messages;
    bool supports_inline_queries;
}
*/


string token = File.ReadAllText("token.config"); //считывание данных
HttpClient hc = new();
hc.BaseAddress = new Uri($"https://api.telegram.org/bot{token}/getMe");

//рез-т будем получать в строках(string)
string contentObj = hc.GetStringAsync("getme").Result;
System.Console.WriteLine(contentObj);


