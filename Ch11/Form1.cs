namespace Ch11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("기본 메시지박스");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제목과 내용이 있는 메시지박스", "버튼2 클릭");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("두개의 버튼을 갖는 메시지박스", 
                                                 "버튼3 클릭",
                                                  MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes를 클릭!");
            }
            else
            {
                MessageBox.Show("No를 클릭!");
            }
        }

        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text = "결과 : " + uid;

        }

        private void txtUid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lbName.Text = "결과 : " + name;
        }

        private void txtHp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            string hp = txtHp.Text;
            lbHp.Text = "결과 : " + hp;
        }

        private void btnChkFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chkFruits = { chkFruit1, chkFruit2, chkFruit3, chkFruit4, chkFruit5 };
            List<string> fruits = new List<string>();

            foreach(CheckBox chk in chkFruits)
            {
                if (chk.Checked)
                {
                    fruits.Add(chk.Text);
                }
            }

            lbFruitResult.Text = "결과 : " + String.Join(", ", fruits); 

        }

        private void btnChkColor_Click(object sender, EventArgs e)
        {
            CheckBox[] chkColors = { chkColor1, chkColor2, chkColor3, chkColor4, chkColor5 };
            List<string> colors = new List<string>();

            foreach (CheckBox chk in chkColors)
            {
                if (chk.Checked)
                {
                    colors.Add(chk.Text);
                }
            }

            lbColorResult.Text = "결과 : " + String.Join(", ", colors);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}