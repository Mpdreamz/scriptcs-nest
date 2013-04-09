ScriptCs.Nest
=============

ScriptCs package to ease using [NEST](http://nest.azurewebsites.net) in combination with [ScriptCs](http://scriptcs.net/)

Install the package:

    scriptcs -install ScriptCs.Nest

Run your script:

    scriptcs connect.csx

Example .csx file:

    var host = new Uri("http://localhost:9200");
    var client = Require<NestClientFactory>().CreateClient(host, s => s.SetDefaultIndex("mpdreamz"));

    Console.WriteLine(client.IsValid);