
using Autofac;
using Autofac.Integration.Mvc;
using MyShop.Data.Models;
using MyShop.Data.Services;
using System.Web.Mvc;

namespace MyShop.Web
{
    public class ContainerConfig
    {
        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlClothingShopCategory>() .As<IClothingData<Category>>();
            builder.RegisterType<SqlClothingShopSubcategory>().As<IClothingData<Subcategory>>();
            builder.RegisterType<SqlClothingShopColor>().As<IClothingData<Color>>();
            builder.RegisterType<SqlClothingShopPrice>().As<IClothingData<Price>>();
            builder.RegisterType<SqlClothingShopProduct>().As<IClothingData<Product>>();
            builder.RegisterType<SqlClothingShopProductPhoto>().As<IClothingData<ProductPhoto>>();
            builder.RegisterType<SqlClothingShopProductType>().As<IClothingData<ProductType>>();
            builder.RegisterType<SqlClothingShopProductVariant>().As<IClothingData<ProductVariant>>();
            builder.RegisterType<SqlClothingShopSize>().As<IClothingData<Size>>();
            builder.RegisterType<ShopDbContext>().InstancePerRequest();
       
           
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
           
          
        }

    }

}