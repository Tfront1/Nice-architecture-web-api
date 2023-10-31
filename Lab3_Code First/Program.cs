
using DataAccess.Context;
using DataAccess.Repositories;
using Lab3_Code_First.Services;
using Microsoft.EntityFrameworkCore;

namespace Lab3_Code_First
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=lab3CodeFirst;Trusted_Connection=True";
            builder.Services.AddDbContext<SkiResContext>(options =>
                options.UseSqlServer(connectionString)
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging()
                .LogTo(Console.WriteLine,
                new[] { DbLoggerCategory.Database.Command.Name },
                LogLevel.Information)
            );
            builder.Services.AddAutoMapper(typeof(Program).Assembly);

            builder.Services.AddTransient(typeof(IEntityRepository<,>), typeof(EntityRepository<,>));
            builder.Services.AddTransient(typeof(IEntityServiceBase<,>), typeof(EntityServiceBase<,>));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}