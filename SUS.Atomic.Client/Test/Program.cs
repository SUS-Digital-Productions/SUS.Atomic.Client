using SUS.AtomicAssets.Client;
using SUS.AtomicAssets.Client.EndpointGroups.V1.Collections;

AtomicAssetsClient<dynamic, dynamic, dynamic, dynamic, dynamic> client = new("https://wax.api.atomicassets.io");
var response = await client.Collections.Get().Sort(AllCollectionSortType.COLLECTION_NAME).Execute();