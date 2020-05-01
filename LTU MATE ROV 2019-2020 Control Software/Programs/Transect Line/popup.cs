using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transect_Line_Code
{
    public partial class popup : Form
    {
        //char[] key = new char[21];
        Thread thread;

        public popup(Form1 form)
        {
            InitializeComponent();
            thread = new Thread(() => { form.DisplayWebcam(this); });
            // Store values
            //key = dataKey;
        }

        public void UpdateLabel(int id, string txt)
        {
            this.Invoke(new Action(() => {
                this.Controls["label" + id].Text = txt;
            }));
        }

        public void UpdateKeys(char[] key)
        {
            this.Invoke(new Action(() => {
                for (int i = 0; i < 21; i++)
                {
                    switch (key[i])
                    {
                        case 's':
                            this.Controls["label" + (i+1)].Text = "Starfish";
                            break;
                        case 'o':
                            this.Controls["label" + (i+1)].Text = "Coral Outcrop";
                            break;
                        case 'n':
                            this.Controls["label" + (i+1)].Text = "Coral Nest";
                            break;
                        default:
                            this.Controls["label" + (i+1)].Text = "Empty";
                            break;
                    }

                }
            }));
        }

        private void popup_Load(object sender, EventArgs e)
        {
            thread.Start();
        }


    }
}

