using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using HealthcareDBModel.DomainClasses;

namespace AppDev04BackEnd.Models
{

    public class HealthcareDB : DbContext
    {

        public DbSet<Leeftijd> Leeftijd { get; set; }
        public DbSet<Antwoord> Antwoord { get; set; }
        public DbSet<Antwoordenlijst> Antwoordenlijst { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Hulpverlener> Hulpverlener { get; set; }
        public DbSet<Mantelzorger> Mantelzorger { get; set; }
        public DbSet<NAHCategorie> NAHCategorie { get; set; }
        public DbSet<Onderzoeker> Onderzoeker { get; set; }
        public DbSet<Rapport> Rapport { get; set; }
        public DbSet<Relatie> Relatie { get; set; }
        public DbSet<Uitslag> Uitslag { get; set; }
        public DbSet<Vraag> Vraag { get; set; }
        public DbSet<Vragenlijst> Vragenlijst { get; set; }
    }
}
