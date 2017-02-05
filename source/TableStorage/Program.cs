using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Configuration;

namespace TableStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01 - Connect to your azure storage account

            // 02 - Create a table called "customers"

            // 03 - Insert single entity (instance of the CustomerEntity class) into the table

            // 04 - Insert two additional CustomerEntity objects using batching (use PartitionKey "Netherlands")

            // 05 - Retrieve one of the entities using TableOperation.Retrieve and print its PartitionKey using Console.WriteLine()

            // 06 - Retrieve all entities with PartitionKey "Netherlands" using TableQuery and print their RowKey using Console.WriteLine()

            // 07 - Delete one of the entities from the table 

            // 08 - Insert a new entity into "customers" using DynamicTableEntity instead of CustomerEntity
        }
    }
}
