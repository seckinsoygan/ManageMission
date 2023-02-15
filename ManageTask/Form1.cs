namespace ManageTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Low"); comboBox1.Items.Add("Medium"); comboBox1.Items.Add("High");
            comboBox3.Items.Add("Low"); comboBox3.Items.Add("Medium"); comboBox3.Items.Add("High");
            comboBox6.Items.Add("Low"); comboBox6.Items.Add("Medium"); comboBox6.Items.Add("High");

            comboBox2.Items.Add("Not Started"); comboBox2.Items.Add("In Progress"); comboBox2.Items.Add("Completed");
            comboBox4.Items.Add("Not Started"); comboBox4.Items.Add("In Progress"); comboBox4.Items.Add("Completed");
            comboBox5.Items.Add("Not Started"); comboBox5.Items.Add("In Progress"); comboBox5.Items.Add("Completed");
        }

        List<Task> taskList = new List<Task>();
        private void button1_Click(object sender, EventArgs e)
        {
            Task list = new Task();
            list.Id = taskList.Count + 1;
            list.TaskName = textBox1.Text;
            list.Description = textBox2.Text;
            list.DueTime = textBox9.Text;
            list.Priority = comboBox1.Text;
            list.Status = comboBox2.Text;

            taskList.Add(list);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < taskList.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = taskList[i].Id;
                dataGridView1.Rows[i].Cells[1].Value = taskList[i].TaskName;
                dataGridView1.Rows[i].Cells[2].Value = taskList[i].Description;
                dataGridView1.Rows[i].Cells[3].Value = taskList[i].DueTime;
                dataGridView1.Rows[i].Cells[4].Value = taskList[i].Priority;
                dataGridView1.Rows[i].Cells[5].Value = taskList[i].Status;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox5.Text);

            for(int i = 0; i < taskList.Count; i++)
            {
                if (result == taskList[i].Id)
                {
                    textBox3.Text = taskList[i].TaskName;
                    textBox4.Text = taskList[i].Description;
                    textBox10.Text = taskList[i].DueTime;
                    comboBox3.Text = taskList[i].Priority;
                    comboBox4.Text = taskList[i].Status;
                }
            }
        }
    }
}