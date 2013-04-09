var host = new Uri("http://localhost:9200");
var client = Require<NestClientFactory>().CreateClient(host, s => s.SetDefaultIndex("mpdreamz"));

Console.WriteLine(client.IsValid);