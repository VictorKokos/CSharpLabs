namespace Lab1
{
    public partial class Form1 : Form
    {
        private double value;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToDouble(ValueTextbox.Text);
            }
            catch (Exception ex)
            {
                value = 0;
            }
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerValue.Text = Math.Sin(Convert.ToDouble(ValueTextbox.Text)).ToString();
            }
            catch(Exception ex)
            {
                AnswerValue.Text = "Даннные введены неверно";
            }
            
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AnswerValue_Click(object sender, EventArgs e)
        {

        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerValue.Text = Math.Cos(Convert.ToDouble(ValueTextbox.Text)).ToString();
            }
            catch (Exception ex)
            {
                AnswerValue.Text = "Даннные введены неверно";
            }

        }

        private void TgButton_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerValue.Text = Math.Tan(Convert.ToDouble(ValueTextbox.Text)).ToString();
            }
            catch (Exception ex)
            {
                AnswerValue.Text = "Даннные введены неверно";
            }

        }

        private void CtgButton_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerValue.Text = (1/Math.Tan(Convert.ToDouble(ValueTextbox.Text))).ToString();
            }
            catch (Exception ex)
            {
                AnswerValue.Text = "Даннные введены неверно";
            }
        }

        private void ButtonSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerValue.Text =  Math.Sqrt(Convert.ToDouble(ValueTextbox.Text)).ToString();
            }
            catch (Exception ex)
            {
                AnswerValue.Text = "Даннные введены неверно";
            }
        }

        private void ButtonCbrt_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerValue.Text = Math.Cbrt(Convert.ToDouble(ValueTextbox.Text)).ToString();
            }
            catch (Exception ex)
            {
                AnswerValue.Text = "Даннные введены неверно";
            }
        }

        private void ButtonPow_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerValue.Text = Math.Pow(Convert.ToDouble(ValueTextbox.Text), 2).ToString();
            }
            catch (Exception ex)
            {
                AnswerValue.Text = "Даннные введены неверно";
            }
        }

        private void ButtonPow3_Click(object sender, EventArgs e)
        {
            try
            {
                AnswerValue.Text = Math.Pow(Convert.ToDouble(ValueTextbox.Text), 3).ToString();
            }
            catch (Exception ex)
            {
                AnswerValue.Text = "Даннные введены неверно";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ValueTextbox.Text = "";
            AnswerValue.Text = "";

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            value = Convert.ToDouble(AnswerValue.Text);
        }

        private void ButtonPaste_Click(object sender, EventArgs e)
        {
            ValueTextbox.Text = value.ToString();
        }
    }
}