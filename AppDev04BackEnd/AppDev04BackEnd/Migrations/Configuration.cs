namespace AppDev04BackEnd.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HealthcareDBModel.DomainClasses;
    using AppDev04BackEnd.Models;

    public sealed class Configuration : DbMigrationsConfiguration<AppDev04BackEnd.Models.HealthcareDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppDev04BackEnd.Models.HealthcareDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

        public void Seed(Hulpverlener hulpverlener)
        {
            HealthcareDB context = new HealthcareDB();
            context.Hulpverlener.AddOrUpdate(hulpverlener);
            context.SaveChanges();
        }

        public void Seed(Vragenlijst vragenlijst)
        {
            HealthcareDB context = new HealthcareDB();
            context.Vragenlijst.AddOrUpdate(vragenlijst);
            context.SaveChanges();
        }

        public void Seed(Vraag[] vraag)
        {
            HealthcareDB context = new HealthcareDB();
            context.Vraag.AddOrUpdate(vraag);
            context.SaveChanges();
        }

        internal void Seed(Uitslag uitslag)
        {
            HealthcareDB context = new HealthcareDB();
            context.Uitslag.AddOrUpdate(uitslag);
            context.SaveChanges();
        }

        internal void Seed(Vraag vraag)
        {
            HealthcareDB context = new HealthcareDB();
            context.Vraag.AddOrUpdate(vraag);
            context.SaveChanges();
        }

        internal void Seed(Antwoord antwoord)
        {
            HealthcareDB context = new HealthcareDB();
            context.Antwoord.AddOrUpdate(antwoord);
            context.SaveChanges();
        }

        internal void Seed(Rapport rapport)
        {
            HealthcareDB context = new HealthcareDB();
            context.Rapport.AddOrUpdate(rapport);
            context.SaveChanges();
        }
    }
}
