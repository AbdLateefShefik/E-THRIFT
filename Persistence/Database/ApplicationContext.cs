using Microsoft.EntityFrameworkCore;

namespace Persistence.Database;

public class ApplicationContext :DbContext
{
    public ApplicationContext(DbContextOptions options) : base(options)
    {
        
    }
}
