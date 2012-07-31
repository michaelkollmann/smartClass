using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using smartClass.Model;
using Windows.UI;
using System.Runtime.Serialization.Json;
using System.Collections.ObjectModel;
using Windows.Foundation.Collections;
using System.Diagnostics;

namespace smartClass.ViewModel
{
    public class VMSchedule : VMBase
    {
        private ObservableCollection<VMLesson> _lessons;
        private ObservableCollection<VMAppointment> _appointments;


        public VMSchedule()
        {
            GenerateTestData();

            Storage.StorageWriter writer = new Storage.StorageWriter();
            writer.WriteClassAsync(_lessons.FirstOrDefault().Model.Class).Start();

            Load();
            
            
            //Fächer laden
            //Stunden laden
            //Fächer den Stunden zuordnen
            //Terminarten laden
            //Termine laden
            //Terminarten den Terminen zuordnen
            //Stunden den Terminen zuordnen
            //lokale Properties füllen (OC<ViewModel>)
            //  -- Stunden nach Tagen gruppiert, nach Zeit aufsteigend sortiert
        }

        private void GenerateTestData()
        {
            MClass cl00 = new MClass(0, "Kommunikation");
            MClass cl01 = new MClass(1, "Deutsch");
            MClass cl02 = new MClass(2, "Englisch");
            MClass cl03 = new MClass(3, "Mathe");
            MClass cl04 = new MClass(4, "Sport");
            MClass cl05 = new MClass(5, "Datenbanken");
            MClass cl06 = new MClass(6, "Java");
            MClass cl07 = new MClass(7, "C#");
            MClass cl08 = new MClass(8, "Methoden");
            MClass cl09 = new MClass(9, "ABAP");
            MClass cl10 = new MClass(10, "BWL");
            MClass cl11 = new MClass(11, "IuK Vernetzung");
            MClass cl12 = new MClass(12, "Datenbanken TrFi");
            MClass cl13 = new MClass(13, "Dev TrFi");
            MClass cl14 = new MClass(14, "IuK BS");
            MClass cl15 = new MClass(15, "Sozialkunde");

            MLesson ls00 = new MLesson(0, cl00, DayOfWeek.Monday, new TimeSpan(08, 00, 00), new TimeSpan(09, 30, 00), "1.09");
            MLesson ls01 = new MLesson(1, cl01, DayOfWeek.Monday, new TimeSpan(09, 45, 00), new TimeSpan(11, 15, 00), "1.22");
            MLesson ls02 = new MLesson(2, cl02, DayOfWeek.Monday, new TimeSpan(11, 30, 00), new TimeSpan(13, 00, 00), "1.02");
            MLesson ls03 = new MLesson(3, cl03, DayOfWeek.Monday, new TimeSpan(13, 45, 00), new TimeSpan(15, 15, 00), "1.09");
            MLesson ls04 = new MLesson(4, cl04, DayOfWeek.Monday, new TimeSpan(15, 30, 00), new TimeSpan(17, 00, 00), "Turnhalle");

            MLesson ls05 = new MLesson(5, cl05, DayOfWeek.Tuesday, new TimeSpan(08, 00, 00), new TimeSpan(09, 30, 00), "10.61");
            MLesson ls06 = new MLesson(6, cl06, DayOfWeek.Tuesday, new TimeSpan(09, 45, 00), new TimeSpan(11, 15, 00), "2.07");
            MLesson ls07 = new MLesson(7, cl00, DayOfWeek.Tuesday, new TimeSpan(11, 30, 00), new TimeSpan(13, 00, 00), "1.09");
            MLesson ls08 = new MLesson(8, cl07, DayOfWeek.Tuesday, new TimeSpan(13, 45, 00), new TimeSpan(16, 00, 00), "1.22");

            MLesson ls09 = new MLesson(9, cl08, DayOfWeek.Wednesday, new TimeSpan(08, 00, 00), new TimeSpan(09, 30, 00), "2.07");
            MLesson ls10 = new MLesson(10, cl09, DayOfWeek.Wednesday, new TimeSpan(09, 45, 00), new TimeSpan(11, 15, 00), "2.06");
            MLesson ls11 = new MLesson(11, cl10, DayOfWeek.Wednesday, new TimeSpan(11, 30, 00), new TimeSpan(13, 00, 00), "2.09");
            MLesson ls12 = new MLesson(12, cl11, DayOfWeek.Wednesday, new TimeSpan(13, 45, 00), new TimeSpan(14, 30, 00), "10.63");
            MLesson ls13 = new MLesson(13, cl07, DayOfWeek.Wednesday, new TimeSpan(14, 30, 00), new TimeSpan(15, 15, 00), "10.63");

            MLesson ls14 = new MLesson(14, cl12, DayOfWeek.Wednesday, new TimeSpan(08, 00, 00), new TimeSpan(09, 30, 00), "2.07");
            MLesson ls15 = new MLesson(15, cl13, DayOfWeek.Wednesday, new TimeSpan(09, 45, 00), new TimeSpan(13, 00, 00), "Trainingsfirma");
            MLesson ls16 = new MLesson(16, cl14, DayOfWeek.Wednesday, new TimeSpan(13, 45, 00), new TimeSpan(16, 00, 00), "10.61");

            MLesson ls17 = new MLesson(17, cl05, DayOfWeek.Friday, new TimeSpan(08, 00, 00), new TimeSpan(08, 45, 00), "10.61");
            MLesson ls18 = new MLesson(18, cl15, DayOfWeek.Friday, new TimeSpan(08, 45, 00), new TimeSpan(09, 30, 00), "10.61");
            MLesson ls19 = new MLesson(19, cl06, DayOfWeek.Friday, new TimeSpan(09, 40, 00), new TimeSpan(12, 50, 00), "2.07");

            List<MLesson> _locallessonmodels = new List<MLesson>();
            _locallessonmodels.Add(ls00);
            _locallessonmodels.Add(ls01);
            _locallessonmodels.Add(ls02);
            _locallessonmodels.Add(ls03);
            _locallessonmodels.Add(ls04);
            _locallessonmodels.Add(ls05);
            _locallessonmodels.Add(ls06);
            _locallessonmodels.Add(ls07);
            _locallessonmodels.Add(ls08);
            _locallessonmodels.Add(ls09);
            _locallessonmodels.Add(ls10);
            _locallessonmodels.Add(ls11);
            _locallessonmodels.Add(ls12);
            _locallessonmodels.Add(ls13);
            _locallessonmodels.Add(ls14);
            _locallessonmodels.Add(ls15);
            _locallessonmodels.Add(ls16);
            _locallessonmodels.Add(ls17);
            _locallessonmodels.Add(ls18);
            _locallessonmodels.Add(ls19);
        }
        private void Load()
        {
            //Storage.StorageWriter writer = new Storage.StorageWriter();
            //writer.Write(typeof(VMClass), new object()).Start();
        }


        public ObservableCollection<VMLesson> Lessons
        {
            get { return _lessons; }
            set { _lessons = value; }
        }
        public ObservableCollection<VMAppointment> Appointments
        {
            get { return _appointments; }
            set { _appointments = value; }
        }
    }
}
