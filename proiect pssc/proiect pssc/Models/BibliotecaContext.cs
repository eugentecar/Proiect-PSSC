﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proiect_pssc.Models
{
    public class BibliotecaContext :DbContext
    {
        public BibliotecaContext() : base("BibliotecaContext")
        {

        }


        public virtual DbSet<Client> Clienti { get; set; }
        public virtual DbSet<Carte> Carti { get; set; }
        public virtual DbSet<Imprumut> Imprumuturi { get; set; }
        public virtual DbSet<Loginnn> Loginuri { get; set; }
    }
}