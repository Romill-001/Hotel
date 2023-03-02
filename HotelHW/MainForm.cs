﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelHW
{
    public partial class MainForm : Form
    {
        readonly CardOfClient card = new CardOfClient();
        public List<Person> persons = new List<Person>();
        public MainForm()
        {
            InitializeComponent();
            PictureOfClient.Visible = false;
            RoomNum.Visible = false;
            stlabel.Visible = false;
            CurrentStatusLabel.Visible = false;
            FullNameLabel.Visible = false;
            GBDateOfEnter.Visible = false;
            GBDateOfLeaving.Visible = false;
            Timer.Start();
            foreach (var line in File.ReadLines(@"./../../Clients.txt"))
            {
                var client = line.Split('|');
                persons.Add(new Person(client[0], client[1], client[2], client[3], client[4], char.Parse(client[5]), client[6], client[7], client[8]));
            }
            foreach (var person in persons)
            {
                ClientsList.Rows.Add(person.full_name, person.status, person.room);
            }
        }

        private void SearchTextBoxClick(object sender, EventArgs e)
        {
            SearchLabel.Hide();
        }
        private void TimerTick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString(" hh : mm : ss tt", CultureInfo.InvariantCulture);
        }

        private void ShowCardButton_Click(object sender, EventArgs e)
        {
            card.Show();
        }

        private void ReservedStatus_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < ClientsList.Rows.Count; i++)
            {
                ClientsList.Rows[i].Visible = ClientsList[1, i].Value.ToString() == "зарезервировано";
            }
        }

        private void FreeStatus_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientsList.Rows.Count; i++)
            {
                ClientsList.Rows[i].Visible = ClientsList[1, i].Value.ToString() == "свободно";
            }
        }

        private void AccupiedStatus_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientsList.Rows.Count; i++)
            {
                ClientsList.Rows[i].Visible = ClientsList[1, i].Value.ToString() == "занято";
            }
        }

        private void LeavingStatus_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientsList.Rows.Count; i++)
            {
                ClientsList.Rows[i].Visible = ClientsList[1, i].Value.ToString() == "выписывается";
            }
        }

        private void AllStatuses_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClientsList.Rows.Count; i++)
            {
                ClientsList.Rows[i].Visible = true;
            }
        }

        private void ClientsList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomNum.Text = $"Номер № {persons[ClientsList.CurrentCell.RowIndex].room}";
            CurrentStatusLabel.Text = persons[ClientsList.CurrentCell.RowIndex].status;
            FullNameLabel.Text = persons[ClientsList.CurrentCell.RowIndex].full_name;
            DateOfEnter.Text = persons[ClientsList.CurrentCell.RowIndex].date_of_entering;
            DateOfLeaving.Text = persons[ClientsList.CurrentCell.RowIndex].date_of_leaving;
            PictureOfClient.Visible = true;
            RoomNum.Visible = true;
            stlabel.Visible = true;
            CurrentStatusLabel.Visible = true;
            FullNameLabel.Visible = true;
            GBDateOfEnter.Visible = true;
            GBDateOfLeaving.Visible = true;
        }
    }
    public class Person
    {
        public string full_name;
        public string status;
        public string room;
        public string bday;
        public string days;
        public char animals;
        public string payment;
        public string date_of_entering;
        public string date_of_leaving;
        public Person(string full_name, string status, string room, string bday, string days, char animals, string payment, string date_of_entering, string date_of_leaving)
        {
            this.full_name = full_name;
            this.status = status;
            this.room = room;
            this.bday = bday;
            this.days = days;
            this.animals = animals;
            this.payment = payment;
            this.date_of_entering = date_of_entering;
            this.date_of_leaving = date_of_leaving;
        }
    }
}