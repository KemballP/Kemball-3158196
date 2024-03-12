// See https://aka.ms/new-console-template for more informatio
using Domain.Entities;
using Infrastructure.Data;

var context = new ApplicationDbContext();
var categoryRepo = new Repo<Category>(context);
var productRepo = new Repo<Product>(context);
//var product = new Product();
//product.Name = "SmartPhone";
//product.Price = "$999";
//var category = new Category();
//category.Name = "Electronics";
//category.Products.Add(product);

//categoryRepo.CreateEntity(category);
//categoryRepo.CommitChanges();
//categoryRepo.DisplayAllToConsole();

//Console.WriteLine("Before Update:");
//productRepo.DisplayAllToConsole();
//var updateId = productRepo.FindById(1);
//updateId.Price = "$899";
//productRepo.Update(updateId);
//productRepo.CommitChanges();
//Console.WriteLine("After Update:");
//productRepo.DisplayAllToConsole();

//productRepo.DeleteById(1);
//productRepo.CommitChanges();
//productRepo.DisplayAllToConsole();





