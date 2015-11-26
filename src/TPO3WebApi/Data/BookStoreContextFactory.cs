using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.Configuration;
using TPO3WebApi.Models;

namespace TPO3WebApi.Data
{
    public static class BookStoreContextFactory
    {
        public static BookstoreContext MySqlBookstoreContext()
        {
            return new BookstoreContext();
        }
    }
}
