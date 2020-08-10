using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Developer_Challenge___Open_Web_Technology.Services
{
    public class ContactsService : IContactsService
    {

        private List<Contact> contacts = new List<Contact>();
        private int _nextId = 1;


        public ContactsService()
        {
            Add(new Contact { Firstname = "Joe0", Lastname = "Dassin0", Fullname = "Joe Dassin0", Address = "32 Avenue du midi0", Email = "joedassin@gmail.com0", MobilePhoneNumber = "0000000000"});
            Add(new Contact { Firstname = "Joe1", Lastname = "Dassin1", Fullname = "Joe Dassin1", Address = "32 Avenue du midi1", Email = "joedassin@gmail.com1", MobilePhoneNumber = "1111111111"});
            Add(new Contact { Firstname = "Joe2", Lastname = "Dassin2", Fullname = "Joe Dassin2", Address = "32 Avenue du midi2", Email = "joedassin@gmail.com2", MobilePhoneNumber = "2222222222"});
            Add(new Contact { Firstname = "Joe3", Lastname = "Dassin3", Fullname = "Joe Dassin3", Address = "32 Avenue du midi3", Email = "joedassin@gmail.com3", MobilePhoneNumber = "3333333333"});
        }

        public IEnumerable<Contact> GetAll()
        {
            return contacts;
        }

        public Contact Get(int id)
        {
            return contacts.Find(p => p.Id == id);
        }

        public Contact Add(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException("item");
            }

            contact.Id = _nextId++;
            contacts.Add(contact);
            return contact;
        }

        public bool Update(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException("Cannot update contact: [" + contact.Id + "]");

            int index = contacts.FindIndex(p => p.Id == contact.Id);

            if (index == -1)
                return false;

            contacts.RemoveAt(index);
            contacts.Add(contact);
            return true;
        }

        public void Delete(int id)
        {
            contacts.RemoveAll(p => p.Id == id);
        }
    }
}
