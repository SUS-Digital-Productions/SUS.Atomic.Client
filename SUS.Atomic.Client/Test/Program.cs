﻿using SUS.AtomicAssets.Client;

AtomicAssetsClient<dynamic, dynamic, dynamic, dynamic, dynamic> client = new("https://wax.api.atomicassets.io");
var response = await client.Accounts.Get().Collection("warsaken").Schema("cards").Page(1).Limit(20).Order(false).Execute();
Console.WriteLine(response.QueryTime);