
using SUS.AtomicAssets.Client;

AtomicAssetsClient<dynamic, dynamic, dynamic, dynamic, dynamic> atomicAssetsClient = new("https://wax.api.atomicassets.io");

var response = await atomicAssetsClient.Transfers.Get().Senders(["neftyblocksp"]).Collections(["hyperhuskyyy"]).Limit(10).Execute();
Console.WriteLine(response.QueryTime);