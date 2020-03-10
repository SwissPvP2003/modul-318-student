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
        public fSearchConnections()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvConnections.Items.Clear();

            Connections connections = getConnections(cbStationFrom.Text, cbStationTo.Text);

            foreach (Connection connection in connections.ConnectionList)
            {
                lvConnections.Items.Add(GetListViewItem(connection));
            }
        }

        private Connections getConnections(string fromStation, string toStation)
        {
            Transport transport = new Transport();
            Connections connections;
            connections = transport.GetConnections(fromStation, toStation);
            return connections;
        }

        private ListViewItem GetListViewItem(Connection connection)
        {
            string[] connections = {connection.From.Departure.ToString().Substring(0, 10), connection.From.Station.Name, connection.From.Departure.ToString().Substring(11, 5), connection.To.Station.Name, connection.To.Arrival.ToString().Substring(11, 5), connection.Duration.Substring(3, 5), connection.From.Platform};
            return new ListViewItem(connections);
        }



    }
}
