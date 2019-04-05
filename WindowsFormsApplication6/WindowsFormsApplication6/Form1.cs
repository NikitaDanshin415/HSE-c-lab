using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm f = new StudentForm();

            if (f.ShowDialog() == DialogResult.OK)
            {
                Student s = f.strudent;

                using (FileStream file = new FileStream("data.dat", FileMode.Append, FileAccess.Write))
                {
                    var bf = new BinaryFormatter();
                    bf.Serialize(file, s);
                }

                var item = new ListViewItem(
                    new[] { s.surName,s.name,s.course.ToString()}
                    );
                listView1.Items.Add(item);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream file = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    var bf = new BinaryFormatter();

                    while (file.Position < file.Length) {
                        var s = (Student)bf.Deserialize(file);
                        var item = new ListViewItem(
                            new[] { s.surName, s.name, s.course.ToString() }
                            );
                        listView1.Items.Add(item);
                    }
                    
                }
            }
        }
    }
}
