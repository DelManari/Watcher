using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watcher
{
    public partial class Form1 : Form
    {
        Subject subject;
        Observer observer1;
        bool direction;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            subject = new Subject();
            observer1 = new Observer(subject);
            subject.Subscribe(observer1);
            subject.SetValue(int.Parse(Watchertxt.Text));

            Point p= observer1btn.Location;

            if (p.X <=this.ClientSize.Width)
                p.X += observer1.getVal();
            if (p.X >= this.ClientSize.Width)
                p.X -= observer1.getVal();

            observer1btn.Location = p;
        }
    }
}