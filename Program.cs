using bankApp.Aplication.command;
using bankApp.Aplication.Model;
using Newtonsoft.Json;

Start();

static async void Start()
{
    string json = File.ReadAllText(@"inputJson/Cases.json");
    //string json = File.ReadAllText(@"../../../inputJson/Cases.json");

    var listTransactionsModel = JsonConvert.DeserializeObject<List<List<TransactionModel>>>(json);

    var Taxes = new List<decimal>();

    var command = new OperatorCommand{ };

    var operations = await command.Send(listTransactionsModel);

    foreach (var operation in operations)
        Console.WriteLine(JsonConvert.SerializeObject(operation.Transactions.Select(t => new { tax = t.Tax }).ToList()));

}