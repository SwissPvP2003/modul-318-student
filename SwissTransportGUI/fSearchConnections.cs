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
    public partial class fSearchConnections : Form
    {
        readonly Transport transport = new Transport();

        public fSearchConnections()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvConnections.Items.Clear();

            Connections connections = GetConnections(cbStationFrom.Text, cbStationTo.Text);

            foreach (Connection connection in connections.ConnectionList)
            {
                lvConnections.Items.Add(ConvertToListViewItem(connection));
            }
        }

        private Connections GetConnections(string fromStation, string toStation)
        {
            Connections connections;
            connections = transport.GetConnections(fromStation, toStation);
            return connections;
        }

        private ListViewItem ConvertToListViewItem(Connection connection)
        {
            string[] connections = {connection.From.Departure.ToString().Substring(0, 10), connection.From.Station.Name, connection.From.Departure.ToString().Substring(11, 5), connection.To.Station.Name, connection.To.Arrival.ToString().Substring(11, 5), connection.Duration.Substring(3, 5), connection.From.Platform};
            return new ListViewItem(connections);
        }

        private void cbStationFrom_TextUpdate(object sender, EventArgs e)
        {
            ClearStationsNames(cbStationFrom);
            AddStationNames(cbStationFrom);
        }
        private void cbStationTo_TextUpdate(object sender, EventArgs e)
        {
            ClearStationsNames(cbStationTo);
            AddStationNames(cbStationTo);
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
                if(station.Name != null)
                    comboBox.Items.Add(station.Name);
            }
            
        }

    }
}
