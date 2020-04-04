using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        public class AutPayload
        {
            public string username = "paulosmantziaris@gmail.com";
            public string password = "35364546aA@";
            public MCAPIWrapper.Primatives.UUID clientToken = new MCAPIWrapper.Primatives.UUID();
            public bool reuqestUser = true;
            public _agent agent = new _agent();
            public class _agent
            {
                public string name = "Minecraft";
                public int version = 1;
            }
        }
        
    }
}
