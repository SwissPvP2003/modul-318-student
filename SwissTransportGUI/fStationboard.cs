using SwissTransport;
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
    public partial class fStationboard : Form
    {
        readonly Transport transport = new Transport();

        public fStationboard()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvConnections.Items.Clear();

            StationBoardRoot StationBoardRoot = GetStationboard(cbStation.Text, string.Empty);

            foreach (StationBoard stationBoard in StationBoardRoot.Entries)
            {
                lvConnections.Items.Add(ConvertToListViewItem(stationBoard));
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

        private void ClearStationsNames(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.SelectionStart = comboBox.Text.Length;
            comboBox.SelectionLength = 0;
        }

        private void AddStationNames(ComboBox comboBox)
        {
            comboBox.DroppedDown = true;
            foreach (Station station in transport.GetStations(comboBox.Text).StationList)
            {
                if (station.Name != null && station.Id != null)
                    comboBox.Items.Add(station.Name);
            }

        }

        private void cbStation_TextUpdate(object sender, EventArgs e)
        {
            ClearStationsNames(cbStation);
            AddStationNames(cbStation);
        }
    }
}
