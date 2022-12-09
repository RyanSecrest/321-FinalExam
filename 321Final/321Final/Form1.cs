namespace _321Final
{
    public partial class Form1 : Form
    {
        int lettersCreated = 0;
        int lettersDeleted = 0;
        int totalLetters = 0;
        string cbSelected;
        string cbSelected2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // leters created 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // big curve-texture-form
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // little line
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // big curve-color-form
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // show created letters
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // big curve-label
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // big curve-color-label
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // big curve-texture-label
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //big line-label
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //big line-color-label
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //big line-texture-label
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            //big line-color-form
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //big line-texture-form
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //little line-label
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //little line-color-label
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //little line-texture-label
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //little line-color-form
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //little line-texture-form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button create-big-curve
            string color = textBox2.Text; // takes string from b-c-color form
            string texture = textBox3.Text; // takes string from b-c-texture form
            string bigCurve;
            if (String.IsNullOrEmpty(color) && String.IsNullOrEmpty(texture) == true)
            {
                bigCurve = "";
                BigCurveDisplay.Text = bigCurve;
                return;
            }
            bigCurve = "Big Curve(color: "+color+", texture: "+texture+")";
            BigCurveDisplay.Text = bigCurve;
            comboBox2.Items.Add(bigCurve);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button create-big-line
            string color = textBox4.Text; // takes string from b-c-color form
            string texture = textBox6.Text; // takes string from b-c-texture form
            string bigLine;
            if (String.IsNullOrEmpty(color) && String.IsNullOrEmpty(texture) == true)
            {
                bigLine = "";
                BigLineDisplay.Text = bigLine;
                return;
            }
            bigLine = "Big Line(color: " + color + ", texture: " + texture + ")";
            BigLineDisplay.Text = bigLine;
            comboBox2.Items.Add(bigLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button create-little-line
            string color = textBox8.Text; // takes string from b-c-color form
            string texture = textBox7.Text; // takes string from b-c-texture form
            string littleLine;
            if (String.IsNullOrEmpty(color) && String.IsNullOrEmpty(texture) == true)
            {
                littleLine = "";
                LittleLineDisplay.Text = littleLine;
                return;
            }
            littleLine = "Little Line(color: " + color + ", texture: " + texture + ")";
            LittleLineDisplay.Text = littleLine;
            comboBox2.Items.Add(littleLine);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //start letter making process
        }

        private void label12_Click(object sender, EventArgs e)
        {
            //letter label
        }

        private void label11_Click(object sender, EventArgs e)
        {
            //letter name-label
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //letter case-label
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //letter name-form
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //letter case-form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //letter create-button
            string name = textBox10.Text;

            string casing;

            if (radioButtonUpper.Checked)
            {
                casing = "Uppercase";
            }
            else
            {
                casing = "Lowercase";
            }
            LetterDisplay.Text = "You created an " +casing+ " " +name+ " using "+BigCurveDisplay.Text+" and " +BigLineDisplay.Text+ " and " +LittleLineDisplay.Text+"";
            lettersCreated += 1;
            totalLetters = lettersCreated - lettersDeleted;
            TotalLettersDisplay_Click(sender, e);
            LettersCreatedNumDisplayLabel_Click(sender, e);
     
            comboBox1.Items.Add(name);
        }

        private void LettersCreatedNumLabel_Click(object sender, EventArgs e)
        {

        }

        private void LettersCreatedNumDisplayLabel_Click(object sender, EventArgs e)
        {
            string lettersCreated2 = Convert.ToString(lettersCreated);
            LettersCreatedNumDisplay.Text = lettersCreated2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSelected = comboBox1.SelectedItem.ToString();
           
        }

        private void DisplayLetters_Click(object sender, EventArgs e)
        {
            DisplayLetterLabel.Text = cbSelected.ToString();
        }

        private void DeleteLetter_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(cbSelected);
            lettersDeleted +=1 ;
            totalLetters = lettersCreated - lettersDeleted;
            TotalLettersDisplay_Click(sender, e);
            LettersDeletedDisplay_Click(sender, e);
        }

        private void LettersDeletedDisplay_Click(object sender, EventArgs e)
        {
            string lettersDeleted2 = Convert.ToString(lettersDeleted);
            LettersDeletedDisplay.Text = lettersDeleted2;
        }

        private void LettersCreatedNumDisplay_Click(object sender, EventArgs e)
        {

        }

        private void TotalLettersDisplay_Click(object sender, EventArgs e)
        {
            string totalLetters2 = Convert.ToString(totalLetters);
            TotalLettersDisplay.Text = totalLetters2;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSelected2 = comboBox2.SelectedItem.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //display a shape
            DisplayShapeLabel.Text = cbSelected2.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //delete a shape
            comboBox2.Items.Remove(cbSelected2);
        }

        private void HELPBUTTON_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To creat a letter add some shapes to the stack. To remove a shape on the stack, hit 'create' with empty color and texture parameters. You can delete letters and shapes as you see fit.");
        }
    }
}