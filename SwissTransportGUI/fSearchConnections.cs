﻿using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class fSearchConnections : Form
    {
        readonly Transport transport = new Transport();

        public fSearchConnections()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lvConnections.Items.Clear();
            if(cbStationFrom.IsBoxFilled() && cbStationTo.IsBoxFilled())
            {
                Connections connections = GetConnections(cbStationFrom.Text, cbStationTo.Text, dtpDate.Text, dtpTime.Text);
                if(connections.ConnectionList.Count > 0)
                {
                    foreach (Connection connection in connections.ConnectionList)
                    {
                        lvConnections.Items.Add(ConvertToListViewItem(connection));
                    }
                }
                else
                {
                    MessageBox.Show("No Results found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Connections GetConnections(string fromStation, string toStation, string date, string time)
        {
            Connections connections;
            connections = transport.GetConnections(fromStation, toStation, date, time);
            return connections;
        }

        private ListViewItem ConvertToListViewItem(Connection connection)
        {
            string[] connections = {connection.From.Departure.ToString().Substring(0, 10), connection.From.Station.Name, connection.From.Departure.ToString().Substring(11, 5), connection.To.Station.Name, connection.To.Arrival.ToString().Substring(11, 5), connection.Duration.Substring(3, 5), connection.From.Platform};
            return new ListViewItem(connections);
        }

        private void dropDownComboBox1_TextUpdate(object sender, EventArgs e)
        {
            cbStationFrom.ClearStationsNames();
            cbStationFrom.AddStationNames(transport);
        }

        private void cbStationTo_TextUpdate(object sender, EventArgs e)
        {
            cbStationTo.ClearStationsNames();
            cbStationTo.AddStationNames(transport);
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            MailSender mailSender = new MailSender();
            mailSender.Subject = "Fahrplan";
            foreach(ListViewItem connection in lvConnections.Items)
            {
                foreach(ListViewItem.ListViewSubItem subItem in connection.SubItems)
                {
                    mailSender.Body += subItem.Text + " ";
                }
            }
            mailSender.sendMail();
        }

        private void btnSwitchStations_Click(object sender, EventArgs e)
        {
            string station = cbStationFrom.Text;
            cbStationFrom.Text = cbStationTo.Text;
            cbStationTo.Text = station;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
