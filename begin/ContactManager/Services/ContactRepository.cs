using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactManager.Models;

namespace ContactManager.Services
{
    public class ContactRepository
    {
        public contacts[] GetAllContacts()
        {
            return new contacts[]
            {
            new contacts
            {
                Id = 1,
                Name = "Glenn Block"
            },
            new contacts
            {
                Id = 2,
                Name = "Dan Roth"
            }
            };
        }
    }