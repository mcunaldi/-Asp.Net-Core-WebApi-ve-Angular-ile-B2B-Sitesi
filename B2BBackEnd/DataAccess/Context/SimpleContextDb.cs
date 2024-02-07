using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace DataAccess.Context;
public class SimpleContextDb : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=MCU\\SQLEXPRESS;Initial Catalog=B2BDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }


    public DbSet<User> Users { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    public DbSet<EmailParameter> EmailParameters { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<CustomerRelationship> CustomerRelationships { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<PriceListDetail> PriceListDetails { get; set; }
    public DbSet<PriceList> PriceLists { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
    public DbSet<Product> Products { get; set; }    
}
