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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnSearchConnetctions_Click(object sender, EventArgs e)
        {
            SearchConnections fSearchConnections = new SearchConnections();
            fSearchConnections.ShowDialog();
        }

        private void BtnShowStationboard_Click(object sender, EventArgs e)
        {
            Stationboard fStationboard = new Stationboard();
            fStationboard.ShowDialog();
        }
    }
}
