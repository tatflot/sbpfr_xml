using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using sbpfr_xml.Model;

namespace sbpfr_xml
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ЭДПФР test = null;
            string path = @".\test.XML";
            if (File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ЭДПФР));
                using (StreamReader reader = new StreamReader(path))
                {
                    test = (ЭДПФР)serializer.Deserialize(reader);

                    MessageBox.Show(test.СЗВТД.Руководитель.ФИО.Фамилия);
                    reader.Close();
                }
            }
            else
            {

                MessageBox.Show("err file");
            }
        }
    }
}
