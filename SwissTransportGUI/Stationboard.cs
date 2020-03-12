using SwissTransport;
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
    public partial class Stationboard : Form
    {
        readonly Transport transport = new Transport();
        public Stationboard()
        {
            InitializeComponent();
        }

        private void CbStation_TextUpdate(object sender, EventArgs e)
        {
            cbStation.ClearStationsNames();
            cbStation.AddStationNames(transport);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            StationBoardRoot stationBoardRoot;

            Cursor.Current = Cursors.WaitCursor;
            lvConnections.Items.Clear();

            if (cbStation.IsBoxFilled())
            {
                stationBoardRoot = GetStationboard(cbStation.Text, string.Empty);

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
        private void BtnShowMap_Click(object sender, EventArgs e)
        {
            if(cbStation.IsBoxFilled())
            {
                Station station = transport.GetStations(cbStation.Text).StationList.First();
                Process.Start("https://www.google.com/maps/search/?api=1&query="+ station.Coordinate.XCoordinate + "," + station.Coordinate.YCoordinate);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
