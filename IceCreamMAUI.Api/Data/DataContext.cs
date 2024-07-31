using IceCreamMAUI.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace IceCreamMAUI.Api.Data;
    public class DataContext: DbContext
    {

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Icecream> Icecreams { get; set; }

    public DbSet<IcecreamOption> IcecreamOptions { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderItem> OrderItems { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IcecreamOption>()
                    .HasKey(io => new { io.IcecreamId, io.Flavor, io.Topping });

        AddSeedData(modelBuilder);
    }

    private static void AddSeedData(ModelBuilder modelBuilder)
    {
        Icecream[] icecream = [
            new Icecream { Id=1, Name="Vanilla Delight", Image="https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0", Price=6.25},
            new Icecream { Id=2, Name="chocoBerry Bliss", Image="https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0",Price=6.25},
            new Icecream { Id=3, Name="Vanilla Delight", Image="https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0",Price=6.25},
            new Icecream { Id=4, Name="Vanilla Delight", Image="https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0",Price=6.25},
            new Icecream { Id=5, Name="Vanilla Delight", Image="https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation?view=net-maui-8.0",Price=6.25}
            ];

        IcecreamOption[] icecreamOptions = [
            new IcecreamOption {IcecreamId=1,Flavor="Vanilla",Topping="default"},
            new IcecreamOption {IcecreamId=2,Flavor="Vanilla",Topping="default"},
            new IcecreamOption {IcecreamId=3,Flavor="Vanilla",Topping="default"},
            new IcecreamOption {IcecreamId=4,Flavor="Vanilla",Topping="default"},
            ];



        modelBuilder.Entity<Icecream>()
            .HasData(icecream);

        modelBuilder.Entity<IcecreamOption>()
            .HasData(icecreamOptions);

    }



}

