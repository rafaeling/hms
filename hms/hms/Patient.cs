using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hms
{
    class Patient
    {
        private int patient_id;
        private int outpatient_yn;
        private int hospital_number;
        private int nhs_number;
        private int gender;
        private String patient_first_name;
        private String patient_middle_name;
        private String patient_last_name;

        private int _age;
        private string _name;

        public Patient()
        {
            Age = 0;
            Name = "Not available";
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Name
        { 
            get { return _name; }
            set { _name = value; }
            
        }

        static void Main(string[] args)
        {
            /*
            Form1 m = new Form1();

            Patient myCustomer = new Patient();
            myCustomer.Name = "Kevin Browne";
            myCustomer.Age = 42;
            m Text = "Name: " + myCustomer.Name + "<br/>Age: " + myCustomer.Age.ToString();
            Console.WriteLine(Text);

            Console.ReadKey();*/


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ViewPatient());

        }

    }
}
