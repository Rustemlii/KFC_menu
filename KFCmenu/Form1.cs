namespace KFCmenu
{
    public partial class Form1 : Form
    {
        Menyu menyu = new Menyu();
        public Form1()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void numericBoxMaster_ValueChanged(object sender, EventArgs e)
        {
            menyu.Total[0] = numericBoxMaster.Value * menyu.Price[0];
            labelBoxMaster.Text = menyu.Total[0].ToString() + " " + "Azn";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            menyu.Total[1] = numericQanad.Value * menyu.Price[1];
            labelQanadQiymet.Text = menyu.Total[1].ToString() + " " + "Azn";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {

                menyu.Total[2] = numericKartoshkaFree.Value * menyu.SizePrice[0];
                label2KartowkaFREE.Text = menyu.Total[2].ToString() + " " + "Azn";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                menyu.Total[3] = numericKartoshkaFree.Value * menyu.SizePrice[1];
                label2KartowkaFREE.Text = menyu.Total[3].ToString() + " " + "Azn";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                menyu.Total[4] = numericKartoshkaFree.Value * menyu.SizePrice[2];
                label2KartowkaFREE.Text = menyu.Total[4].ToString() + " " + "Azn";
            }
        }

        private void numericKola_ValueChanged(object sender, EventArgs e)
        {

            if (comboBoxCola.SelectedIndex == 0)
            {
                menyu.Total[5] = numericKola.Value * menyu.SizePrice[3];
                label3Kola.Text = menyu.Total[5].ToString() + " " + "Azn";
            }
            else if (comboBoxCola.SelectedIndex == 1)
            {
                menyu.Total[6] = numericKola.Value * menyu.SizePrice[4];
                label3Kola.Text = menyu.Total[6].ToString() + " " + "Azn";
            }
            else if (comboBoxCola.SelectedIndex == 2)
            {
                menyu.Total[7] = numericKola.Value * menyu.SizePrice[5];
                label3Kola.Text = menyu.Total[7].ToString() + " " + "Azn";
            }
        }

        private void numericNuggets_ValueChanged(object sender, EventArgs e)
        {
            menyu.Total[8] = numericNuggets.Value * menyu.Price[4];
            label4Nuggets.Text = menyu.Total[8].ToString() + " " + "Azn";

        }

        private void numericBud_ValueChanged(object sender, EventArgs e)
        {

            menyu.Total[9] = numericBud.Value * menyu.Price[5];
            label5Bud.Text = menyu.Total[9].ToString() + " " + "Azn";

        }

        private void label9Mebleg_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(menyu.Size[0]);
            comboBox1.Items.Add(menyu.Size[1]);
            comboBox1.Items.Add(menyu.Size[2]);
            comboBoxCola.Items.Add(menyu.Size[0]);
            comboBoxCola.Items.Add(menyu.Size[1]);
            comboBoxCola.Items.Add(menyu.Size[2]);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1Tesdiqetme_Click(object sender, EventArgs e)
        {

        }

        private void buttonSifarishVer_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (numericBoxMaster.Value != 0)
            {
                labelBoxMaster.Text = menyu.Total[0].ToString();
                form2.listBox1Ad.Items.Add(menyu.OrderName[0]);
                form2.listBoxEded.Items.Add(numericBoxMaster.Value);
                form2.listBox3Qiymet.Items.Add(menyu.Total[0] + " " + "Azn");
                form2.Show();
            }
            if (numericQanad.Value != 0)
            {
                labelQanadQiymet.Text = menyu.Total[1].ToString();
                form2.listBox1Ad.Items.Add(menyu.OrderName[1]);
                form2.listBoxEded.Items.Add(numericQanad.Value);
                form2.listBox3Qiymet.Items.Add(menyu.Total[1] + " " + "Azn");
                form2.Show();
            }
            if (numericKartoshkaFree.Value != 0)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label2KartowkaFREE.Text = menyu.Total[2].ToString();
                    form2.listBox1Ad.Items.Add(menyu.OrderName[2]);
                    form2.listBoxEded.Items.Add(numericKartoshkaFree.Value + "-" + menyu.Size[0]);
                    form2.listBox3Qiymet.Items.Add(menyu.Total[2] + " " + "Azn");
                    form2.Show();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label2KartowkaFREE.Text = menyu.Total[3].ToString();
                    form2.listBox1Ad.Items.Add(menyu.OrderName[2]);
                    form2.listBoxEded.Items.Add(numericKartoshkaFree.Value + "-" + menyu.Size[1]);
                    form2.listBox3Qiymet.Items.Add(menyu.Total[3] + " " + "Azn");
                    form2.Show();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label2KartowkaFREE.Text = menyu.Total[4].ToString();
                    form2.listBox1Ad.Items.Add(menyu.OrderName[2]);
                    form2.listBoxEded.Items.Add(numericKartoshkaFree.Value + "-" + menyu.Size[2]);
                    form2.listBox3Qiymet.Items.Add(menyu.Total[4] + " " + "Azn");
                    form2.Show();
                }

            }
            if (numericKola.Value != 0)
            {
                if (comboBoxCola.SelectedIndex == 0)
                {
                    if (numericBoxMaster.Value != 0)
                    {


                        label3Kola.Text = menyu.Total[5].ToString();
                        form2.listBox1Ad.Items.Add(menyu.OrderName[3]);
                        form2.listBoxEded.Items.Add(numericKola.Value + "-" + menyu.Size[0]);
                        form2.listBox3Qiymet.Items.Add(menyu.Total[5] + " " + "Azn");
                        form2.Show();
                    }
                }
                else if (comboBoxCola.SelectedIndex == 1)
                {
                    label3Kola.Text = menyu.Total[6].ToString();
                    form2.listBox1Ad.Items.Add(menyu.OrderName[3]);
                    form2.listBoxEded.Items.Add(numericKola.Value + "-" + menyu.Size[1]);
                    form2.listBox3Qiymet.Items.Add(menyu.Total[6] + " " + "Azn");
                    form2.Show();
                }
                else if (comboBoxCola.SelectedIndex == 2)
                {
                    label3Kola.Text = menyu.Total[7].ToString();
                    form2.listBox1Ad.Items.Add(menyu.OrderName[3]);
                    form2.listBoxEded.Items.Add(numericKola.Value + "-" + menyu.Size[0]);
                    form2.listBox3Qiymet.Items.Add(menyu.Total[7] + " " + "Azn");
                    form2.Show();
                }
            }
            if (numericNuggets.Value != 0)
            {
                label4Nuggets.Text = menyu.Total[8].ToString();
                form2.listBox1Ad.Items.Add(menyu.OrderName[4]);
                form2.listBoxEded.Items.Add(numericNuggets.Value);
                form2.listBox3Qiymet.Items.Add(menyu.Total[8] + " " + "Azn");
                form2.Show();
            }
            if (numericBud.Value > 0)
            {
                label5Bud.Text = menyu.Total[9].ToString();
                form2.listBox1Ad.Items.Add(menyu.OrderName[5]);
                form2.listBoxEded.Items.Add(numericBud.Value.ToString());
                form2.listBox3Qiymet.Items.Add(menyu.Total[9] + " " + "Azn");
                form2.Show();

            }
            form2.label8Toplammm.Text = (menyu.Total[0] + menyu.Total[1] + menyu.Total[2] + menyu.Total[3] + menyu.Total[4] +
             menyu.Total[5] + menyu.Total[6] + menyu.Total[7] + menyu.Total[8] + menyu.Total[9] + " " + "Azn");

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                numericKartoshkaFree.Value = 0;
                label2KartowkaFREE.Text = menyu.SizePrice[0].ToString() + " " + "Azn";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                numericKartoshkaFree.Value = 0;
                label2KartowkaFREE.Text = menyu.SizePrice[1].ToString() + " " + "Azn";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                numericKartoshkaFree.Value = 0;
                label2KartowkaFREE.Text = menyu.SizePrice[2].ToString() + " " + "Azn";
            }


        }

        private void comboBoxCola_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCola.SelectedIndex == 0)
            {
                numericKola.Value = 0;
                label3Kola.Text = menyu.SizePrice[3].ToString() + " " + "Azn";
            }
            else if (comboBoxCola.SelectedIndex == 1)
            {
                numericKola.Value = 0;
                label3Kola.Text = menyu.SizePrice[4].ToString() + " " + "Azn";
            }
            else if (comboBoxCola.SelectedIndex == 2)
            {
                numericKola.Value = 0;
                label3Kola.Text = menyu.SizePrice[5].ToString() + " " + "Azn";
            }
        }
    }
}