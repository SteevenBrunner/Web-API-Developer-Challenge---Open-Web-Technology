using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Developer_Challenge___Open_Web_Technology.Services
{
    interface IContactsService
    {

        public IEnumerable<Contact> GetAll();

        public Contact Get(int id);

        public Contact Add(Contact contact);

        public bool Update(Contact contact);

        public void Delete(int id);

    }
}
