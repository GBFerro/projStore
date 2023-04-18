using System.Threading.Channels;
using Controllers;
using Models;

Console.WriteLine("Projeto Loja!");

Store store = new Store()
{
    Description = "Essa é a sua 5 loja",
    Address = "Rua dos Bobos No 666"
};

string getInformation = (new StoreController().Insert(store) ? "Inserido" : "Erro");
Console.WriteLine(getInformation);

new StoreController().GetAll().ForEach(store => Console.WriteLine(store));
