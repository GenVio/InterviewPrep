Store Blockchain Workbench messages in Cosmos DB 
=================================================

Overview
--------

This sample shows how you can use Azure Functions to react to events published
by Azure Blockchain Workbench to Event Grid

Create and configure a new Function App
=======================================

1.  If not already present, create a new function app :

    ![](media/3f09e843716df586fa78f923da898cf7.png)

2.  Use the template to create a function with the EventGrid Trigger

![](media/d20878cde659502b57581214f73c52d3.png)

1.  Choose C\# as the programming language and give an appropriate name. Once
    the function is created, go to the integrate tab to add an output trigger to
    CosmosDB

    For the Cosmos DB account connection, choose the account created in the
    above section. Make sure you check the flag to create a Cosmos DB database
    and collection

    ![](media/84c43d8d0f72beb3d81d62f0e6bbf81e.png)

2.  In the function body, paste the following snippet :

>   public static void Run(JObject eventGridEvent, TraceWriter log, out object
>   document)

>   {

>   document = null;

>   String operationName = eventGridEvent["data"]["OperationName"].ToString();

>   switch(operationName)

>   {

>   case "AccountCreated":

>   case "ContractInsertedOrUpdated":

>   case "UpdateUserBalance":

>   case "InsertBlock":

>   case "InsertTransaction":

>   break;

>   }

>   }

You can now add logic to case statements to process messages as appropriate.

Full details on the message types and C\# classes for them can be found
[here](https://docs.microsoft.com/en-us/azure/blockchain-workbench/blockchain-workbench-messages-overview).

1.  Add the Event Grid subscription by clicking on the link next to the Run
    button. Choose the topic type as “Even Grid Topics” and select the event
    grid from your workbench deployment to listen to the messages.

    ![](media/8e1c62de958cfdd7fba0ffe616260521.png)

2.  Once the event grid subscription is added successfully, you can run the
    Azure function.

3.  Validate that you are seeing the expected output of your logic.
