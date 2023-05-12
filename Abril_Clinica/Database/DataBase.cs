﻿using Abril_Clinica.Models;
using AbrilClinica.Entities.Models;
using Google.Type;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Database
{
    public class DataBase
    {
        private const string _appointmentPath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\appointment.csv";
        private const string _userPath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\user.csv";
        private const string _adminPath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\admin.csv";
        private const string _patientPath = "C:\\Users\\Urano\\source\\Decima_Labo2_PP\\PrimerParcial_Labo2\\patient.csv";

        public DataBase()
        {
        }

        public void CreateUserArchive()
        {
            //if (!File.Exists(_userPath))
            //{
            using (StreamWriter sw = new StreamWriter(_userPath))
            {
                sw.WriteLine("Bianca,Decima,bdecima,coco123,false,45686325");
                sw.WriteLine("Marcos,Dente,holamarcos,holahola,false,54686325");
                sw.WriteLine("Florencia,Peña,fpenia,fifus,false,98586325");
                sw.WriteLine("Simon,Dice,sidimonce,98pepe,false,78654235");

                sw.WriteLine("John,Melano,jmela,mela1,true,501,Medicina Familiar");
                sw.WriteLine("Carlos,Horia,horiac,horica00,true,406,Ginecologia");
                sw.WriteLine("Sofia,Munro,smunro,rofia77, true, 407,Nutricion");
                sw.WriteLine("Sergio,Hernandez,shernan,nandez88,true,408,Kinesiologia");
                sw.WriteLine("Mauro,Casorio,msorio,cauro22,true,406,Obstetricia");
            }
                
                //sw.Close();
            //}
        }

        public void CreateAppointmentArchive()
        {
            if (!File.Exists(_appointmentPath))
            {
                using StreamWriter sw = new StreamWriter(_appointmentPath);

                sw.WriteLine("4005,98586325,Medicina Familiar,2023/7/7");
                sw.WriteLine("(1,45686325,Ginecologia,2023/7/7");
                sw.WriteLine("2,54686325,Nutricion,2023/12/8");
                sw.WriteLine("4,78654235,Obstreticia,2023/12/4");
                sw.WriteLine("3,98586325,Kinesiologia,2023/5/6");
            }
        }

        public string Read(string path) 
        {
            var text = File.ReadAllText(path);
            return text;
        }
        
        
        public List<Appointment> GetAppointments()
        {
            string text = Read(_appointmentPath);
            string[] line = text.Split('\n');
            List<string> appointmentStringList = new List<string>();
            List<Appointment> appointmentList = new List<Appointment>();

            for(int i = 0; i < line.Length -1; i++)
            {
                appointmentStringList.Add(line[i]);
            }
            foreach (string row in appointmentStringList)
            {
                appointmentList.Add((Appointment)row);
            }

            return appointmentList;
        }

        public List<User> GetUsers()
        {
            string text = Read(_userPath);
            string[] line = text.Split('\n');
            List<string> userStringList = new List<string>();
            List<User> userList = new List<User>();

            for (int i = 0; i < line.Length - 1; i++)
            {
                userStringList.Add(line[i]);
            }
            foreach (string row in userStringList)
            {
                userList.Add((User)row);
            }

            return userList;
        }


        public void SetAppointments(List<Appointment> appointments)
        {
            StreamWriter sw = new StreamWriter(_appointmentPath);
            foreach (var item in appointments)
            {
                sw.WriteLine(item.ObjectToString());
            }

            sw.Close();
        }

        public void SetUsers(List<User> users)
        {
            StreamWriter sw = new StreamWriter(_userPath);
            foreach (var item in users)
            {
                sw.WriteLine(item.ObjectToString());
            }

            sw.Close();
        }
    }
}
