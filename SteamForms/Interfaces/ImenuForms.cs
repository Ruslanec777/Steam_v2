using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamForms.Interfaces
{
    interface ImenuForms
    {
        public AccountProvider AccountProvider { get; set; }
        public Form LocalParentForm { get; set; }

        public bool IsClosingThisForm { get; set; }

    }
}
