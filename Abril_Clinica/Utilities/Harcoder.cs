﻿using Abril_Clinica.Models;
using AbrilClinica.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Utilities
{
    public static class Harcoder
    {
        static List<User> users;
        static List<Appointment> appointments;
        static List<Admin> admins;
        static List<Patient> patients;
        public static List<Patient> HardcodePatients()
        {
            //var random = new Random();
            patients = new List<Patient>();
            patients.Add(new Patient("Bianca", "Decima", "bdecima", "coco123", false, 45686325));
            patients.Add(new Patient("Marcos", "Dente", "holamarcos", "holahola", false, 54686325));
            patients.Add(new Patient("Florencia", "Peña", "fpenia", "fifus", false, 98586325));
            patients.Add(new Patient("Simon", "Dice", "sidimonce", "98pepe", false, 78654235));
            return patients;
        }

        public static List<User> HarcodeUsers()
        {
            users = new List<User>();
            users.Add(new Patient("Bianca", "Decima", "bdecima", "coco123", false, 45686325));
            users.Add(new Patient("Marcos", "Dente", "holamarcos", "holahola", false, 54686325));
            users.Add(new Patient("Florencia", "Peña", "fpenia", "fifus", false, 98586325));
            users.Add(new Patient("Simon", "Dice", "sidimonce", "98pepe", false, 78654235));

            users.Add(new Admin("John", "Melano", "jmela", "mela1", true, 501, "Medicina Familiar"));
            users.Add(new Admin("Carlos", "Horia", "horiac", "horica00", true, 406, "Ginecologia"));
            users.Add(new Admin("Sofia", "Munro", "smunro", "rofia77", true, 407, "Nutricion"));
            users.Add(new Admin("Sergio", "Hernandez", "shernan", "nandez88", true, 408, "Kinesiologia"));
            users.Add(new Admin("Mauro", "Casorio", "msorio", "cauro22", true, 406, "Obstetricia"));
            return users;
        }

        public static List<Admin> HardcodeAdmins()
        {
            admins = new List<Admin>();
            admins.Add(new Admin("John", "Melano", "jmela", "mela1", true, 501, "Medicina Familiar"));
            admins.Add(new Admin("Carlos", "Horia", "horiac", "horica00", true, 406, "Ginecologia"));
            admins.Add(new Admin("Sofia", "Munro", "smunro", "rofia77", true, 407, "Nutricion"));
            admins.Add(new Admin("Sergio", "Hernandez", "shernan", "nandez88", true, 408, "Kinesiologia"));
            admins.Add(new Admin("Mauro", "Casorio", "msorio", "cauro22", true, 406, "Obstetricia"));
            return admins;
        }

        public static List<Appointment> HardcodeAppointment()
        {
            appointments = new List<Appointment>();
            appointments.Add(new Appointment(4005, 98586325, "Medicina Familiar", new DateTime(2023, 7, 7, 12, 0, 0)/*, 501*/));
            appointments.Add(new Appointment(1, 45686325, "Ginecologia", new DateTime(2023, 7, 7, 12, 0, 0)/*, 406*/));
            appointments.Add(new Appointment(2, 54686325, "Nutricion", new DateTime(2023, 12, 8, 9, 0, 0)/*, 407*/));
            appointments.Add(new Appointment(3, 98586325, "Kinesiologia", new DateTime(2023, 5, 6, 14, 30, 0)/*, 408*/));
            appointments.Add(new Appointment(4, 78654235, "Obstreticia", new DateTime(2023, 12, 4, 10, 45, 0)/*, 409*/));
            return appointments;
        }

    }
}
