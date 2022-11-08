﻿using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactManager.Services;

namespace ContactManager.Controllers
{
    public class ContactController : ApiController
    {

        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        public contacts[] Get()
        {
            return contactRepository.GetAllContacts();

            {
                new contacts
                {
                    Id = 1,
                    Name = "Glenn Block"
                }
                ,
        new contacts
        {
            Id = 2,
            Name = "Dan Roth"
        }
   };
        }
    }
}
