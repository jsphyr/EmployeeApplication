namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        public frmEmployeeDatabase()
        {
            InitializeComponent();
        }
        public class Employee
        {
            private string employeeID;
            private string fName;
            private string lName;
            private string pos;

            public Employee()
            {
                employeeID = "";
                fName = "";
                lName = "";
                pos = "";
            }
            public Employee(string employeeID, string fName, string lName, string pos)
            {
                this.employeeID = employeeID;
                this.fName = fName;
                this.lName = lName;
                this.pos = pos;
            }
            public string EmployeeID
            {
                get { return employeeID; }
                set { employeeID = value; }
            }
            public string FName
            {
                get { return fName; }
                set { fName = value; }
            }
            public string LName
            {
                get { return lName; }
                set { lName = value; }
            }
            public string Pos
            {
                get { return pos; }
                set { pos = value; }
            }
        }
        private void frmEmployeeDatabase_Load(object sender, EventArgs e)
        {
            dataGridViewEmployee.ColumnCount = 4;

            dataGridViewEmployee.Columns[0].Name = "Employee ID";
            dataGridViewEmployee.Columns[1].Name = "First Name";
            dataGridViewEmployee.Columns[2].Name = "Last Name";
            dataGridViewEmployee.Columns[3].Name = "Position";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string employeeIDText = txtEmployeeID.Text.Trim();
            int employeeID;

            if(!int.TryParse(employeeIDText, out employeeID))
            {
                MessageBox.Show("Please enter a valid employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            string fName = txtFirstName.Text.Trim();
            string lName = txtLastName.Text.Trim();
            string pos = txtPosition.Text.Trim();

            if (string.IsNullOrEmpty(fName) || !ifValidInput(fName))
            {
                {
                    MessageBox.Show("Please enter a valid First Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            if (string.IsNullOrEmpty(lName) || !ifValidInput(lName))
            {
                {
                    MessageBox.Show("Please enter a valid Last Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            if (string.IsNullOrEmpty(pos) || !ifValidInput(pos))
            {
                {
                    MessageBox.Show("Please enter a valid Position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }

            Employee emp = new Employee(employeeID.ToString(), fName, lName, pos);

            string[] row = new string[]
            {
                emp.EmployeeID,
                emp.FName,
                emp.LName,
                emp.Pos
            };

            dataGridViewEmployee.Rows.Add(row);

            txtEmployeeID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPosition.Clear();
        }

        private bool ifValidInput(string inp)
        {
            foreach (char c in inp)
            {
                if(!char.IsLetter(c)) 
                {
                return false;
                }
            }
            return true;
        }
    }
}
