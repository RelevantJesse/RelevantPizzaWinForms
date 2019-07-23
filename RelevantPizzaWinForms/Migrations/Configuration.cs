namespace RelevantPizzaWinForms.Migrations
{
    using RelevantPizza.Data;
    using RelevantPizza.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RelevantPizza.Data.PizzaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PizzaContext context)
        {
            SeedEmployees(context);
            SeedCustomers(context);
            SeedInventoryItems(context);
        }

        private void SeedEmployees(PizzaContext context)
        {
            if (context.Employees.Any())
            {
                return;
            }

            Employee[] employees = new Employee[]
            {
                new Employee{FirstName = "Jesse", LastName = "Prescott", PhoneNumber="123-123-1234", Role=Roles.Manager, Salary=100000M},
                new Employee{FirstName = "Jim", LastName = "Smith", PhoneNumber="123-123-1234", Role=Roles.AssistantManager, Salary=40000M},
                new Employee{FirstName = "Bob", LastName = "Anderson", PhoneNumber="123-123-1234", Role=Roles.Cashier, Salary=10000M}
            };

            context.Employees.AddRange(employees);
            context.SaveChanges();
        }

        private void SeedCustomers(PizzaContext context)
        {
            if (context.Customers.Any())
            {
                return;
            }

            Customer[] customers = new Customer[]
            {
                new Customer{FirstName = "Jesse", LastName = "Prescott", PhoneNumber="123-123-1234", StreetAddress="123 Main St", City="New York", State="NY", Zip=90210},
                new Customer{FirstName = "Jim", LastName = "Smith", PhoneNumber="123-123-1234", StreetAddress="123 Main St", City="New York", State="NY", Zip=90210},
                new Customer{FirstName = "Bob", LastName = "Anderson", PhoneNumber="123-123-1234", StreetAddress="123 Main St", City="New York", State="NY", Zip=90210}
            };

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        private void SeedInventoryItems(PizzaContext context)
        {
            if (context.InventoryItems.Any())
            {
                return;
            }

            InventoryItem[] inventoryItems = new InventoryItem[]
            {
                new InventoryItem{Name="Pepperoni", Type=InventoryItemType.Topping, QuantityRemaining=1000, PricePerUnit=.01M},
                new InventoryItem{Name="Sausage", Type=InventoryItemType.Topping, QuantityRemaining=1000, PricePerUnit=.01M},
                new InventoryItem{Name="Mozerella", Type=InventoryItemType.Cheese, QuantityRemaining=1000, PricePerUnit=.01M},
                new InventoryItem{Name="Surge", Type=InventoryItemType.Flavor, QuantityRemaining=50, PricePerUnit=.50M},
            };

            context.InventoryItems.AddRange(inventoryItems);
            context.SaveChanges();
        }
    }
}
