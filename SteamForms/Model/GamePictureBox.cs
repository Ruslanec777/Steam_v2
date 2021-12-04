using App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamForms.Model
{
    class GamePictureBox : PictureBox
    {
        public Game Game{ get; set; }
    }
}
