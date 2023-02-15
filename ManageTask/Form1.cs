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
            Task task = new Task();
            task.Id = taskList.Count + 1;
            task.TaskName = textBox1.Text;
            task.Description = textBox2.Text;
            task.DueTime = dateTimePicker1.Value;
            task.Priority = comboBox1.Text;
            task.Status = comboBox2.Text;

            taskList.Add(task);
            MessageBox.Show("Görev Baþarýyla Eklendi.");
            textBox1.Text = ""; textBox2.Text = ""; comboBox1.Text = ""; comboBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < taskList.Count; i++)
            {
                dataGridView1.Rows.Add();
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

            for (int i = 0; i < taskList.Count; i++)
            {
                if (result == taskList[i].Id)
                {
                    textBox3.Text = taskList[i].TaskName;
                    textBox4.Text = taskList[i].Description;
                    dateTimePicker2.Value = taskList[i].DueTime;
                    comboBox3.Text = taskList[i].Priority;
                    comboBox4.Text = taskList[i].Status;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox5.Text);

            for (int i = 0; i < taskList.Count; i++)
            {
                if (result == taskList[i].Id)
                {
                    taskList.Remove(taskList[i]);
                    MessageBox.Show("Görev Baþarýyla Silindi.");
                    textBox3.Text = ""; textBox4.Text = ""; comboBox3.Text = ""; comboBox4.Text = ""; textBox5.Text = "";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox6.Text);

            for (int i = 0; i < taskList.Count; i++)
            {
                if (result == taskList[i].Id)
                {
                    textBox8.Text = taskList[i].TaskName;
                    textBox7.Text = taskList[i].Description;
                    dateTimePicker3.Value = taskList[i].DueTime;
                    comboBox6.Text = taskList[i].Priority;
                    comboBox5.Text = taskList[i].Status;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox6.Text);
            for (int i = 0; i < taskList.Count; i++)
            {
                if (result == taskList[i].Id)
                {
                    taskList[i].TaskName = textBox8.Text;
                    taskList[i].Description = textBox7.Text;
                    taskList[i].DueTime = dateTimePicker3.Value;
                    taskList[i].Priority = comboBox6.Text;
                    taskList[i].Status = comboBox5.Text;

                    MessageBox.Show("Görev Baþarýyla Güncellendi.");
                    textBox8.Text = ""; textBox7.Text = ""; comboBox6.Text = ""; comboBox5.Text = ""; textBox6.Text = "";
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox9.Text);
            dataGridView1.Rows.Clear();

            for (int i = 0; i < taskList.Count; i++)
            {
                if (result == taskList[i].Id)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = taskList[i].Id;
                    dataGridView1.Rows[i].Cells[1].Value = taskList[i].TaskName;
                    dataGridView1.Rows[i].Cells[2].Value = taskList[i].Description;
                    dataGridView1.Rows[i].Cells[3].Value = taskList[i].DueTime;
                    dataGridView1.Rows[i].Cells[4].Value = taskList[i].Priority;
                    dataGridView1.Rows[i].Cells[5].Value = taskList[i].Status;
                }
            }
            textBox9.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < taskList.Count; i++)
            {
                if (textBox10.Text == taskList[i].TaskName)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = taskList[i].Id;
                    dataGridView1.Rows[i].Cells[1].Value = taskList[i].TaskName;
                    dataGridView1.Rows[i].Cells[2].Value = taskList[i].Description;
                    dataGridView1.Rows[i].Cells[3].Value = taskList[i].DueTime;
                    dataGridView1.Rows[i].Cells[4].Value = taskList[i].Priority;
                    dataGridView1.Rows[i].Cells[5].Value = taskList[i].Status;
                }
            }
            textBox10.Text = "";
        }
    }
}