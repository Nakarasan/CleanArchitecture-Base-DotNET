using CleanArchitecture.Domain.Entity;
using CleanArchitecture.Domain.Entity.Advertisements;
using CleanArchitecture.Domain.Entity.Customers;
using CleanArchitecture.Domain.Entity.Discounts;
using CleanArchitecture.Domain.Entity.Offers;
using CleanArchitecture.Domain.Entity.Orders;
using CleanArchitecture.Domain.Entity.Products;
using CleanArchitecture.Domain.Entity.Purchases;
using CleanArchitecture.Domain.Entity.Reviews;
using CleanArchitecture.Domain.Entity.ShoppingCart;
using CleanArchitecture.Domain.Entity.Wishlists;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        #region
        //Products
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<VariantColor> VariantColors { get; set; }
        public DbSet<VariantSize> VariantSizes { get; set; }
        public DbSet<VariantUnit> VariantUnits { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<Warranty> Warranties { get; set; }
        public DbSet<Stock> Stocks { get; set; }


        //Customers
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<ContactDetail> ContactDetails { get; set; }


        //Purchase
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseReturn> PurchaseReturns { get; set; }

        //Orders
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderReturn> OrderReturns { get; set; }

        //Offers
        public DbSet<Offer> Offers { get; set; }
        public DbSet<ProductOffer> ProductOffers { get; set; }

        //Discounts
        public DbSet<Discount> Discounts { get; set; }

        //Reviews
        public DbSet<Review> Reviews { get; set; }

        //ShoppingCart
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ProductVarientCart> ProductVarientCarts { get; set; }

        //Wishlists
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<ProductVarientWishlist> ProductVarientWishlists { get; set; }

        //Advertisements
        public DbSet<Advertisement> Advertisements { get; set; }
        

        public DbSet<Blog> Blogs {  get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductOffer>()
                .HasKey(po => new { po.ProductId, po.OfferId });

            modelBuilder.Entity<ProductOffer>()
                .HasOne(po => po.Product)
                .WithMany(p => p.ProductOffers)
                .HasForeignKey(po => po.ProductId);

            modelBuilder.Entity<ProductOffer>()
               .HasOne(po => po.Offers)
               .WithMany(p => p.ProductOffers)
               .HasForeignKey(po => po.OfferId);

            modelBuilder.Entity<ProductVarientCart>()
               .HasKey(pv => new { pv.CartId, pv.productVariantsId });

            modelBuilder.Entity<ProductVarientCart>()
                .HasOne(pv => pv.Cart)
                .WithMany(p => p.ProductVariantsCart)
                .HasForeignKey(pv => pv.CartId);

            modelBuilder.Entity<ProductVarientCart>()
               .HasOne(pv => pv.productVariant)
               .WithMany(p => p.ProductVariantsCart)
               .HasForeignKey(pv => pv.productVariantsId);

            modelBuilder.Entity<ProductVarientWishlist>()
              .HasKey(pw => new { pw.wishListId, pw.productVariantsId });

            modelBuilder.Entity<ProductVarientWishlist>()
                .HasOne(pw => pw.wishList)
                .WithMany(p => p.ProductVarientWishlist)
                .HasForeignKey(pw => pw.wishListId);

            modelBuilder.Entity<ProductVarientWishlist>()
               .HasOne(pw => pw.productVariant)
               .WithMany(p => p.ProductVariantWishList)
               .HasForeignKey(pw => pw.productVariantsId);

            base.OnModelCreating(modelBuilder);

        }

    }
}
