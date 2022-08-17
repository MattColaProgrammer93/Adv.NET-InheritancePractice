namespace InheritancePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void btnDisplayCandy_Click(object sender, EventArgs e)
        {
            Candy c = new()
            {
                Name = "Jackels",
                Flavor = "Watermellon"
            };

            // Override the default behavior
            MessageBox.Show(c.ToString());
            lstCandies.Items.Add(c);
        }

        private void ClearTextBox(TextBoxBase box)
        {
            box.Clear();
        }

        private void btnClearBoxes_Click(object sender, EventArgs e)
        {
            ClearTextBox(txtInput);
            ClearTextBox(maskedTextBox1);
        }
    }
}