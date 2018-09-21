# Azure Functions - Cosmos DB Real-time Update Demo

A simple demo of broadcasting real-time updates from Cosmos DB over websockets. Uses:

* Azure Cosmos DB Change Feed
* Azure SignalR Service
* Azure Functions bindings:
    - Cosmos DB trigger
    - SignalR Service bindings

Put one or more documents into the demo/flights collection:

```
{
    "from": "SEA",
    "to": "YVR",
    "price": 199
}
```
