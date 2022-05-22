using Newtonsoft.Json;

Initial();

static void Initial()
{

    string jsonString = File.ReadAllText(@"D:\myFile.json");

    var response = JsonConvert.DeserializeObject<List<TicketModel>>(jsonString);

    foreach (var item in response)
    {
        Console.WriteLine($"Operacaçao: {item.operation} , Unit-Cost: {item.unitCost} ,Quantidade:{item.quantity}");
    }


}

public class TicketModel
{
    [JsonProperty("operation")]
    public string operation { get; set; }

    [JsonProperty("unit-cost")]
    public decimal unitCost { get; set; }

    [JsonProperty("quantity")]
    public int quantity { get; set; }
}