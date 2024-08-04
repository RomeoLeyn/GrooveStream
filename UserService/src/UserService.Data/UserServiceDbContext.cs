using Microsoft.EntityFrameworkCore;

namespace UserService.UserService.Data;

public class UserServiceDbContext : DbContext
{
    protected readonly IConfiguration configuration;

    public UserServiceDbContext(IConfiguration configuration)
    {
        configuration = configuration;
    }

    protected void OnConfiguration(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(configuration.GetConnectionString("DataBase"));
    }
}