using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebStoreMVC.Data.Entities.Identity;

namespace WebStoreMVC;

public static class DbSeeder
{
    public static async Task SeedData(this WebApplication webApplication)
    {
        //Це для того, щоб запрости у Dependecy Injection потрібні сервіси для роботи з базою даних та ролями.
        using var scope = webApplication.Services.CreateScope();
        // Отримуємо сервіси з DI контейнера
        var services = scope.ServiceProvider;

        var context = services.GetRequiredService<Data.MyContextShopMVC>();
        await context.Database.MigrateAsync();
        var roleManager = services.GetRequiredService<RoleManager<RoleEntity>>();
        // Створення ролей
        foreach (var roleName in Constants.Roles.AllRoles)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new RoleEntity { Name = roleName });
            }
        }
    }
}
