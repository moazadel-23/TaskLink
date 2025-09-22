using Microsoft.EntityFrameworkCore;
using TaskLink.Data;

namespace TaskLink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new();
            // 1.
            //var customer = db.Customers.Select(e => new
            //{
            //    e.FirstName,
            //    e.LastName,
            //    e.Email
            //});
            //foreach (var item in db.Customers)
            //{
            //    Console.WriteLine($"Name: {item.FirstName} {item.LastName}  Email: {item.Email}");
            //}

            //--------------------------------------------------------------------

            //2.
            //db.Orders.Where(e => e.StaffId == 3).ToList();
            //foreach (var item in db.Orders)
            //{
            //    Console.WriteLine($"OrderId: {item.OrderId}  OrderDate: {item.OrderDate}  StaffId: {item.StaffId}");
            //}
            //--------------------------------------------------------------
            //3.
            //var product = db.Products.Where(e => e.Category.CategoryName == "Mountain Bikes").Select(e => new
            //  {
            //    e.ProductId,
            //    e.ProductName,
            //    e.Category.CategoryName
            //});
            //foreach(var item in product)
            //{
            //    Console.WriteLine($"Id: {item.ProductId} ProductName : {item.ProductName} CategoryName: {item.CategoryName}");
            //}
            //---------------------------------------------------------------------
            //4.
            //var orders = db.Orders.GroupBy(e => e.StoreId).Select(e => new
            //{
            //   storeId = e.Key,
            //   orderCount = e.Count()
            //});
            //foreach (var item in orders)
            //{
            //    Console.WriteLine($"id: {item.storeId} OrderCount: {item.orderCount}");
            //}
            //---------------------------------------------------------------------
            //5.
            //var order = db.Orders.Where(e => e.ShippedDate == null).ToList();
            //foreach (var item in order)
            //{
            //    Console.WriteLine($"Id: {item.OrderId} ShippedDate: {item.ShippedDate}");
            //}
            //---------------------------------------------------------------------
            //6.
            //db.Customers.Select(e => new
            //{
            //    e.FirstName,
            //    e.LastName,
            //    order = e.Orders.Count() 
            //});
            //foreach (var item in db.Customers)
            //{
            //    Console.WriteLine($"Name: {item.FirstName} {item.LastName}  OrderCount: {item.Orders.Count()}");
            //}
            //-----------------------------------------------------------------------
            //7.
            //var productsNeverOrdered = db.Products.Where(p => !db.OrderItems.Any(oi => oi.ProductId == p.ProductId));

            //foreach (var p in productsNeverOrdered)
            //{
            //    Console.WriteLine($"Id: {p.ProductId}, ProductName: {p.ProductName}");
            //}
            //-----------------------------------------------------------------------
            //8.
            //var product = db.Stocks.Where(e => e.Quantity > 5).Select(e => new
            //{
            //    e.Product.ProductId,
            //    e.Product.ProductName,
            //    e.Quantity
            //});
            //foreach (var item in product)
            //{
            //    Console.WriteLine($"Id: {item.ProductId} ProductName : {item.ProductName} Quantity: {item.Quantity}");
            //}
            //-----------------------------------------------------------------------
            //9.
            //var firstProduct = db.Products.FirstOrDefault(e => e.ProductId == 1);
            //if (firstProduct != null)
            //{
            //    Console.WriteLine($"Id: {firstProduct.ProductId} ProductName: {firstProduct.ProductName} Price: {firstProduct.ListPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("Product not found.");
            //}

            //-----------------------------------------------------------------------
            //10.
            //var modelYear = db.Products.Where(e => e.ModelYear == 2016).Select(e => new
            //{
            //    e.ProductId,
            //    e.ProductName,
            //    e.ModelYear
            //});
            //foreach (var item in modelYear)
            //{
            //    Console.WriteLine($"Id: {item.ProductId} ProductName : {item.ProductName} ModelYear: {item.ModelYear}");
            //}
            //-----------------------------------------------------------------------
            //11.
            //var NumProduct = db.Products.GroupBy(e => e.ProductId).Select(e => new
            //{
            //    product = e.Key,
            //    NumOfProduct = e.Count()
            //});
            //foreach (var item in NumProduct)
            //{
            //    Console.WriteLine($"ProductName: {item.product} NumOfProduct: {item.NumOfProduct}");
            //}
            //-----------------------------------------------------------------------
            //12.
            //var NumOfProductInCatogery = db.Products.GroupBy(e => e.CategoryId).Select(e => new
            //{
            //    Id = e.Key,
            //    Num = e.Count()
            //}).ToList();
            //foreach (var item in NumOfProductInCatogery)
            //{
            //    Console.WriteLine($"Id: {item.Id} NumOfProductInCatogery: {item.Num}");
            //}
            //-----------------------------------------------------------------------
            //13.
            //var AvgOfProducts = db.Products.Average(e => e.ListPrice);
            //Console.WriteLine($"AvgOfProducts: {AvgOfProducts}");
            //-----------------------------------------------------------------------
            //14.
            //Console.WriteLine("Enter ProductId:");
            //int ProductId = Convert.ToInt32(Console.ReadLine());
            //var product = db.Products.Where(e => e.ProductId == ProductId).Select(e => new
            //{
            //    e.ProductId,
            //    e.ProductName
            //}).FirstOrDefault();
            //if (product != null)
            //{
            //    Console.WriteLine($"ProductId: {product.ProductId} | ProductName{product.ProductName}");
            //}
            //else
            //{
            //    Console.WriteLine("Product not found.");
            //}
            //-----------------------------------------------------------------------
            //15.
            //var totalProducts = db.Stocks.Where(e =>e.Quantity > 3).Select(e => new
            //{
            //    e.Product.ProductId,
            //    e.Product.ProductName,
            //    e.Quantity
            //}).ToList();
            //foreach (var item in totalProducts)
            //{
            //    Console.WriteLine($"Id: {item.ProductId} ProductName : {item.ProductName} Quantity: {item.Quantity}");
            //}
            //-----------------------------------------------------------------------
            //16.
            //var StaffName = db.Staffs.Select(e => new
            //{
            //    e.FirstName,
            //    e.LastName,
            //    e.Orders.Count
            //});
            //foreach (var item in StaffName)
            //{
            //    Console.WriteLine($"Name: {item.FirstName} {item.LastName}  OrderCount: {item.Count}");
            //}
            //-----------------------------------------------------------------------
            //17.
            //var ActiveStaff = db.Staffs.Where(e => e.Active == 1).Select(e => new
            //{
            //    e.FirstName,
            //    e.LastName,
            //    e.Active
            //}).ToList();
            //foreach (var item in ActiveStaff)
            //{
            //    Console.WriteLine($"Name: {item.FirstName} {item.LastName}  Active: {item.Active}");
            //}
            //------------------------------------------------------------------------
            //18.
            //var AllPeoduct = db.Products.Select(e => new
            //{
            //    e.ProductId,
            //    e.ProductName,
            //    e.ListPrice,
            //    e.ModelYear,
            //    e.Brand.BrandName,
            //    e.Category.CategoryName
            //});
            //foreach (var item in AllPeoduct)
            //{
            //    Console.WriteLine($"Id: {item.ProductId} | productName: {item.ProductName} | ListPrice: {item.ListPrice}" +
            //        $" | ModelYear: {item.ModelYear} | BrandName: {item.BrandName} | CategoryName: {item.CategoryName}");
            //}
            //------------------------------------------------------------------------
            //19.
            //var orderStatus = db.Orders.Select(e => new
            //{
            //    e.OrderId,
            //    e.OrderStatus
            //});
            //foreach (var item in orderStatus)
            //{
            //    Console.WriteLine($"Id: {item.OrderId} | Status:{item.OrderStatus}");
            //}
            //-------------------------------------------------------------------------
            //20.
            //var ProductAndQuantity = db.Products.Select(e => new
            //{
            //    e.ProductId,
            //    count = e.OrderItems.Sum(o => o.Quantity)
            //}).OrderByDescending(e => e.count).ToList();
            //foreach (var item in ProductAndQuantity)
            //{
            //    Console.WriteLine($"id: {item.ProductId}  Count:{item.count}");
            //}

        }
    }
}
