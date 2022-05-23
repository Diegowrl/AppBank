using bankApp.Domain.Entities;
using bankApp.Map;
using bankApp.Model;
using Newtonsoft.Json;

Initial();

static void Initial()
{

    string json = File.ReadAllText(@"inputJson/myFile.json");

    //var json = "[[{'operation':'buy', 'unit-cost':10.00, 'quantity': 100},{'operation':'sell', 'unit-cost':15.00, 'quantity': 50},{'operation':'sell', 'unit-cost':15.00, 'quantity': 50}]]";
    //var json = "[[{'operation':'buy', 'unit-cost':10.00, 'quantity': 10000},{'operation':'sell', 'unit-cost':20.00, 'quantity': 5000},{'operation':'sell', 'unit-cost':5.00, 'quantity': 5000}]]";
    //var json = "[[{'operation':'buy', 'unit-cost':10.00, 'quantity': 100},{'operation':'sell', 'unit-cost':15.00, 'quantity': 50},{'operation':'sell', 'unit-cost':15.00, 'quantity': 50}],[{'operation':'buy', 'unit-cost':10.00, 'quantity': 10000},{'operation':'sell', 'unit-cost':20.00, 'quantity': 5000},{'operation':'sell', 'unit-cost':5.00, 'quantity': 5000}]]";
    //var json = "[[{'operation':'buy', 'unit-cost':10.00, 'quantity': 10000},{'operation':'sell', 'unit-cost':5.00, 'quantity': 5000},{'operation':'sell', 'unit-cost':20.00, 'quantity': 3000}]]";
    //var json = "[[{'operation':'buy', 'unit-cost':10.00, 'quantity': 10000},{'operation':'buy', 'unit-cost':25.00, 'quantity': 5000},{'operation':'sell', 'unit-cost':15.00, 'quantity': 10000}]]";
    //var json = "[[{'operation':'buy', 'unit-cost':10.00, 'quantity': 10000},{'operation':'buy', 'unit-cost':25.00, 'quantity': 5000},{'operation':'sell', 'unit-cost':15.00, 'quantity': 10000},{'operation':'sell', 'unit-cost':25.00, 'quantity': 5000}]]";
    //var json = "[[{'operation':'buy', 'unit-cost':10.00, 'quantity': 10000},{'operation':'sell', 'unit-cost':2.00, 'quantity': 5000},{'operation':'sell', 'unit-cost':20.00, 'quantity': 2000},{'operation':'sell', 'unit-cost':20.00, 'quantity': 2000},{'operation':'sell', 'unit-cost':25.00, 'quantity': 1000}]]";
    //var json = "[[{'operation':'buy', 'unit-cost':10.00, 'quantity': 10000},{'operation':'sell', 'unit-cost':2.00, 'quantity': 5000},{'operation':'sell', 'unit-cost':20.00, 'quantity': 2000},{'operation':'sell', 'unit-cost':20.00, 'quantity': 2000},{'operation':'sell', 'unit-cost':25.00, 'quantity': 1000},{'operation':'buy', 'unit-cost':20.00, 'quantity': 10000},{'operation':'sell', 'unit-cost':15.00, 'quantity': 5000},{'operation':'sell', 'unit-cost':30.00, 'quantity': 4350},{'operation':'sell', 'unit-cost':30.00, 'quantity': 650}]]";

    var listTransactionsModel = JsonConvert.DeserializeObject<List<List<TransactionModel>>>(json);

    var operations = new List<Operation>();
    var Taxes = new List<decimal>();

    foreach (var transactionsModel in listTransactionsModel)
    {
        var transactions = new List<Transaction>();

        foreach (var transaction in transactionsModel)
            transactions.Add(new Transaction(transaction.operation.Map(), transaction.unitCost, transaction.quantity));

        operations.Add(new Operation(transactions));
    }

    foreach (var operation in operations)
        Console.WriteLine(JsonConvert.SerializeObject(operation.Transactions.Select(t => new { tax = t.Tax }).ToList()));

}