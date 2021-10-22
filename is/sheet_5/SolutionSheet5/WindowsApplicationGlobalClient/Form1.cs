using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplicationGlobalClient.ServiceReferenceHoliday;

namespace WindowsApplicationGlobalClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownYear.Value = DateTime.Today.Year;

        }

        private void buttonGetService_Click(object sender, EventArgs e)
        {
            HolidaySoapClient service = new HolidaySoapClient();
            int year = Convert.ToInt32(numericUpDownYear.Value);
            Holiday[] holidays = service.GetAllHolidays(year);
            listBoxResults.Items.Clear();
            foreach (Holiday holiday in holidays)
            {
                string holidayFormmated = $"{holiday.Date.ToShortDateString()} : {holiday.Type}\t{holiday.Description}";
                listBoxResults.Items.Add(holidayFormmated);
            }
        }
    }
}
