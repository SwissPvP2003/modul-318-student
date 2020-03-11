﻿using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class fStationboard : Form
    {
        readonly Transport transport = new Transport();

        public fStationboard()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lvConnections.Items.Clear();
            if (cbStation.IsBoxFilled())
            {
                StationBoardRoot stationBoardRoot = GetStationboard(cbStation.Text, string.Empty);

                if(stationBoardRoot.Entries.Count > 0)
                {
                    foreach (StationBoard stationBoard in stationBoardRoot.Entries)
                    {
                        lvConnections.Items.Add(ConvertToListViewItem(stationBoard));
                    }
                }
                else
                {
                    MessageBox.Show("No Results found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private StationBoardRoot GetStationboard(string station, string id)
        {
            StationBoardRoot stationBoardRoot;
            stationBoardRoot = transport.GetStationBoard(station, id);
            return stationBoardRoot;
        }

        private ListViewItem ConvertToListViewItem(StationBoard stationBoard)
        {
            string[] stationboardInformations = {stationBoard.Stop.Departure.TimeOfDay.ToString(), stationBoard.To, stationBoard.Category + stationBoard.Number };
            return new ListViewItem(stationboardInformations);
        }

        private void dropDownComboBox1_TextUpdate(object sender, EventArgs e)
        {
            cbStation.ClearStationsNames();
            cbStation.AddStationNames(transport);
        }

        private void btnShowMap_Click(object sender, EventArgs e)
        {
            if(cbStation.IsBoxFilled())
            {
                Station station = transport.GetStations(cbStation.Text).StationList.First();
                Process.Start("https://www.google.com/maps/search/?api=1&query="+ station.Coordinate.XCoordinate + "," + station.Coordinate.YCoordinate);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
