﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Uge_15___Disaheim
{
    public class Controller
    {
        public List<Book> Books;
        public List<Amulet> Amulets;

        public Controller() 
        { 
            Books = new List<Book>();
            Amulets = new List<Amulet>();
        }

        public void AddToList (Book book) 
        { Books.Add(book); }

        public void AddToList (Amulet amulet)
        { Amulets.Add(amulet); }
    }
}