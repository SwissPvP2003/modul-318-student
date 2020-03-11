using SwissTransport;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    class DropDownComboBox : ComboBox
    {
        public void ClearStationsNames()
        {
            Items.Clear();
            BackColor = SystemColors.Window;
            SelectionStart = Text.Length;
            SelectionLength = 0;
        }

        public void AddStationNames(Transport transport)
        {
            DroppedDown = true;
            foreach (Station station in transport.GetStations(Text).StationList)
            {
                if (station.Name != null && station.Id != null)
                    Items.Add(station.Name);
            }
            if(Items.Count <= 0)
            {

            }

        }

        public bool IsBoxFilled()
        {
            if(Text == null || Text.Length <= 0)
            {
                BackColor = Color.Red;
                return false;
            }
            return true;
        }
    }
}
