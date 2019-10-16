using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System;
using System.Linq;
using Network.Models;

namespace Network
{
    public class Startup
    {

        public Startup(IConfiguration configuration, ILogger<Startup> logger)
        {
            Configuration = configuration;
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IConfiguration Configuration { get; }
        private readonly ILogger<Startup> logger;


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRouting();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}");
            });

            //FillDB();
            
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Defaut path!");
            //});
        }
        private void FillDB()
        {
            try
            {
                ShopContext sc = new ShopContext();

                var productsDesc = new List<ProductD>
                {
                    new ProductD
                    {
                         Name = "Кофеварка",
                         Description = "В хозяйстве пригодится. Использутся для варки кофе. " +
                         "короче то - что нужно каждому.",
                         Price = 89
                    },
                    new ProductD
                    {
                        Name = "Блендер",
                         Description = "Положи туда что-нибудь, нажми кнопку и радуйся.",
                         Price = 55
                    },
                    new ProductD
                    {
                        Name = "Пылесос",
                         Description = "соселыП. Сегодня дешего, успей забрать!",
                         Price = 1
                    },
                    new ProductD
                    {
                        Name = "Отпугиватель тараканов",
                         Description = "Отпугивать потенциальную еду - глупо, не покупайте.",
                         Price = 12
                    },
                    new ProductD
                    {
                        Name = "Отпугиватель студентов",
                         Description = "Первая пара",
                         Price = 0
                    },
                    new ProductD
                    {
                        Name = "Автомат по экзамену",
                         Description = "Слишком хорошо, что бы быть правдой",
                         Price = 9999999
                    },
                    new ProductD
                    {
                        Name = "Вилка",
                         Description = "чисти чисти чисти чисти чисти чисти чисти чисти чисти чисти чисти " +
                         "чисти чисти чисти чисти чисти чисти чисти чисти чисти чисти чисти чисти чисти чисти ",
                         Price = 3
                    },
                    new ProductD
                    {
                        Name = "Пачка сижек",
                         Description = "Пыхтите на здоровье!",
                         Price = 20
                    },
                    new ProductD
                    {
                        Name = "Абонимент в качалку",
                         Description = "Перед покупкой нужно отстоять очередь",
                         Price = 14
                    },
                    new ProductD
                    {
                        Name = "Билет на коржа",
                         Description = "Просрочен",
                         Price = 2
                    },
                    new ProductD
                    {
                        Name = "Пицца",
                         Description = "Валялась на полу",
                         Price = 2.13
                    },
                };

                sc.PrD.AddRange(productsDesc);
                
                //var purchase = new Purchase
                //{
                //    PurchaseDat = new DateTime(2012, 12, 12),
                //    Products = new List<Product>
                //    {
                //    }
                //};
                //sc.Acc.Add(new Account
                //{
                //    FirstName = "faeda",
                //    LastName = "fefef",
                //    Age = 10,
                //    Money = 100,
                //    Points = 100,
                //    Purchases = new List<Purchase>
                //    {
                //        purchase
                //    }

                //});
                //sc.Strg.Add(new ItemsStorage
                //{
                //    OnSale = false,
                //    Product = product

                //});
                sc.SaveChanges();
                sc.Dispose();
            }
            catch (Exception e)
            {
                logger.LogError(e, "Pizda");
            }
        }
    }
}
