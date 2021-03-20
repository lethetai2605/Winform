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
using System.Xml.Serialization;
using static WindowsFormsAppCalendar.PlanItem;

namespace WindowsFormsAppCalendar
{
    public partial class Form1 : Form
    {
        #region Properties
        private List<List<Button>> matrix;
        private string filePath = "data.xml";
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        public PlanData Job { get => job; set => job = value; }

        private PlanData job;
        private List<string> dateOfWeek = new List<string>{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        public Form1()
        {
            InitializeComponent();
            LoadMatrix();
         /*   try
            {
             //   DeserializeFromXML(filePath);
            }
            catch {
                SetDefaulJob();
            }*/
        }
      /*  void SetDefaulJob()
        {
            
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Test",
                Status = PlanItem.ListStatus[(int)EPlanItem.COMING]});
          
        } */
        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayofColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayofWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dataButtonWidth,Height = Cons.dataButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    panelMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldBtn = btn;

                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dataButtonHeight) };
            }
            setDefaultDate();
           // addNumberIntoMatrixByDate(dateTimePickerDate.Value);
        }
      
        int dayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if (date.Year % 4 == 0 && date.Year % 100 != 0 || date.Year % 400 == 0)
                    {
                        return 29;
                    }
                    else return 28;
                    
                default:
                    return 30;
            }
        }
        void addNumberIntoMatrixByDate(DateTime date)
        {
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            for (int i = 1; i <= dayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                if(isEqualDate(useDate,date))
                {
                    btn.BackColor = Color.Red;
                }

                if (isEqualDate(useDate,DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }
                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);
            }
        }
        bool isEqualDate(DateTime dateA,DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }
        void setDefaultDate()
        {

            dateTimePickerDate.Value = DateTime.Now;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ClearMatrix();
            addNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonWednesday_Click(object sender, EventArgs e)
        {

        }

        private void buttonToday_Click(object sender, EventArgs e)
        {

        }

        private void buttonSunday_Click(object sender, EventArgs e)
        {

        }

        private void buttonFriday_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLast_MouseClick(object sender, MouseEventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddMonths(-1);
        }

        private void buttonNext_MouseClick(object sender, MouseEventArgs e)
        {
            dateTimePickerDate.Value = dateTimePickerDate.Value.AddMonths(1);
        }

        private void buttonToday_MouseClick(object sender, MouseEventArgs e)
        {
            setDefaultDate();
        }

        /*private void SerializeToXML(object data,string filePath)
        {
           FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write,FileShare.Read);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
           
      sr.Serialize(fs, data);
            
            

            

      fs.Close();
    }
    private object DeserializeFromXML(string filePath)
    {
       FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read); ;
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
            
            object result = sr.Deserialize(fs);
           fs.Flush();

           return result;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
       {
            SerializeToXML(Job, filePath);
}*/
    }
}
