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
    public partial class fStartGUI : Form
    {
        public fStartGUI()
        {
            InitializeComponent();
        }

        private void BtnSearchConnetctions_Click(object sender, EventArgs e)
        {
            fSearchConnections searchConnections = new fSearchConnections();
            searchConnections.ShowDialog();
        }

        private void BtnShowStationboard_Click(object sender, EventArgs e)
        {
            fStationboard stationboard = new fStationboard();
            stationboard.ShowDialog();
        }
    }
}
