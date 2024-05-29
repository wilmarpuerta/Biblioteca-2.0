

using Microsoft.EntityFrameworkCore;

namespace Biblioteca_2._0.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
            
        }
    }
}