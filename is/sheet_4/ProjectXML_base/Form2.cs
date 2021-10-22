using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectXML
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxXmlFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnExecuteXPath_Click(object sender, EventArgs e)
        {
            HandlerXML handler = new HandlerXML(textBoxXmlFile.Text);
            textBoxResult.Text = handler.executeXPath(textBoxXPath.Text);
        }

        /*13.
         
         13.1. dei/course[1] 
         13.2. dei/course[2]//@name 
         13.3. dei/course[last()]//@name 
         13.4. dei/course[last()-1]//@name 
         13.5. dei/course[1]/teachers/teacher[1]/name 
         13.6. dei/course[@name="Integracao de Sistemas"]/teachers/teacher/name 
         13.7. dei/course//@name
         13.8. dei/course/students/student/name[contains(text(), 'Manuel')]/parent::student/number
         13.9. dei/course/students/student[starts-with(name, 'M')]/number
         13.10. dei/course[starts-with(@name,'I') and @ects=6]/scheme
         13.11. dei/course/teachers/teacher[name = 'Francisco']/parent::teachers/parent::course//@name
         13.12 dei/course//@ects
         */
    }
}

