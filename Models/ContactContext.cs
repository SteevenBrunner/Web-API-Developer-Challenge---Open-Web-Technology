using Microsoft.EntityFrameworkCore;

namespace Web_API_Developer_Challenge___Open_Web_Technology.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            :base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }

    }
}
