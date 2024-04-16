using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CarpetAndFloor
{
    public partial class Form1 : Form
    {

        /**
         * These strings and the font are required to be static (and defined right here in the code) so that 
         * Form2 can find the data within.
         */
        
        public static string ValueForTxtAddressOutput = String.Empty;
        public static string ValueForTxtQuotation = String.Empty;
        public static Font ValueForFont = new Font("Arial", 14);
        public static Color ValueForColor = Color.Black;
        public static DateTime localDate = DateTime.Now;


        public string MyValue
        {
            get { return textBox1.Text; }
        }
        public Form1()
        {
            InitializeComponent();
            rdoSelf.Checked = true;
        }


        private List<FloorType> getFloorData()
        {
            //This data could come from a Database or csv file, etc.
            List<FloorType> floorList = new List<FloorType>();
            floorList.Add(new FloorType("Cherry", "Hardwood", 8.00m));
            floorList.Add(new FloorType("Oak", "Hardwood", 9.75m));
            floorList.Add(new FloorType("Walnut", "Hardwood", 15.75m));
            floorList.Add(new FloorType("Bamboo", "Bamboo", 7.75m));
            floorList.Add(new FloorType("Pine Laminate", "Laminate", 7.00m));
            floorList.Add(new FloorType("Oak Laminate", "Laminate", 7.00m));
            floorList.Add(new FloorType("Cherry Laminate", "Laminate", 7.00m));
            floorList.Add(new FloorType("Linoleum", "Linoleum", 6.00m));
            floorList.Add(new FloorType("Glazed Ceramic", "Tile", 6.00m));
            floorList.Add(new FloorType("Quarry Tile", "Tile", 10.00m));
            floorList.Add(new FloorType("Porcelain Tile", "Tile", 30.00m));
            floorList.Add(new FloorType("Terracotta Tile", "Tile", 25.00m));
            floorList.Add(new FloorType("Wool Carpet", "Carpet", 6.00m));
            floorList.Add(new FloorType("Nylon Carpet", "Carpet", 6.00m));
            floorList.Add(new FloorType("Acrylic Carpet", "Carpet", 6.00m));
            floorList.Add(new FloorType("Polyester Carpet", "Carpet", 6.00m));
            floorList.Add(new FloorType("Travertine", "Stone", 22.00m));
            floorList.Add(new FloorType("Marble", "Stone", 50.00m));
            floorList.Add(new FloorType("Vinyl", "Vinyl", 4.00m));
            floorList.Add(new FloorType("Cork", "Cork", 6.00m));
            floorList.Add(new FloorType("Burlap Squares", "Carpet", 1.99m));

            return floorList;
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\nCarpetAndFloor\n\nVersion: 1.3.0");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindFloor.DataSource = getFloorData();
            dgvFloorList.DataSource = bindFloor.DataSource;

            lstState.SetSelected(lstState.Items.IndexOf("TN"), true);
            LoadPictures();

        }

        private void LoadPictures()
        {
            //K:\JCSCHNEIDER\Courses\CITC 2310 Adv DotNet Prgm\src\CarpetAndFloor1.2.0
            pb1.Image = Image.FromFile(@"K:\JCSCHNEIDER\Courses\CITC 2310 Adv DotNet Prgm\src\CarpetAndFloor1.2.0\francesca-tosolini-XAHSexPxSus-unsplash.jpg");
            pb1.Size = new Size(500, 500);
            pb1.Width = 500;
            pb1.Height = 200;
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            label11.BackColor = Color.AliceBlue;
            label11.Text = "Photo by Francesca Tosolini on Unsplash";

            pb2.Image = Image.FromFile(@"K:\JCSCHNEIDER\Courses\CITC 2310 Adv DotNet Prgm\src\CarpetAndFloor1.2.0\andrey-haimin-q2Fyzn-KJOQ-unsplash.jpg");
            pb2.Size = new Size(500, 500);
            pb2.Width = 500;
            pb2.Height = 200;
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;

            label15.BackColor = Color.AliceBlue;
            label15.Text = "Photo by Andrey Haimin on Unsplash";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 1 clicked");
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtFloorName.Text = dgvFloorList.CurrentRow.Cells[0].Value.ToString();
            txtFloorCtgry.Text = dgvFloorList.CurrentRow.Cells[1].Value.ToString();
            txtFloorPrice.Text = dgvFloorList.CurrentRow.Cells[2].Value.ToString();

            UpdateCalculation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateCalculation();
        }

        private void UpdateCalculation()
        {
            FloorType buffer = new FloorType(
                txtFloorName.Text,
                txtFloorCtgry.Text,
                decimal.Parse(txtFloorPrice.Text));

            double length = 0.0;
            double width = 0.0;
            //double area = 0.0;
            //double sqYard = 0.0;
            decimal installationCost = 0.00m;
            //txtOutput.Text = String.Empty;

            if (!double.TryParse(txtLength.Text, out length))
            {
                txtLength.Text = "1.0";
                length = 1.0;
            }
            buffer.Length = length;


            if (!double.TryParse(txtWidth.Text, out width))
            {
                txtWidth.Text = "1.0";
                width = 1.0;
            }
            buffer.Width = width;


            if (rdoInstall.Checked)
            {
                if (!decimal.TryParse(txtLaborCharge.Text, out installationCost))
                {
                    installationCost = 30.00m;
                }
            }
            buffer.Labor = installationCost * (decimal)buffer.AreaSqYards;

            txtSqFt.Text = buffer.Area.ToString();
            txtSqYd.Text = buffer.AreaSqYards.ToString();
            txtMaterials.Text = buffer.Cost.ToString();
            txtLaborTotal.Text = buffer.Labor.ToString();
            txtTotalCost.Text = (buffer.Labor + buffer.Cost).ToString();
            txtQuotation.Text = buffer.ToStringDetail();
            ValueForTxtQuotation = txtQuotation.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();

            if (!String.IsNullOrEmpty(txtCustomerName.Text))
            {
                cust.Name = txtCustomerName.Text;
                cust.Addr = txtCustomerAddr.Text;
                cust.Addr2 = txtCustomerAddr2.Text;
                cust.City = txtCustomerCity.Text;
                cust.State = lstState.SelectedItem.ToString();
                cust.Zip = txtCustZip.Text;
            }
            //MessageBox.Show(cust.ToStringFormatted());

            textBox1.Text = cust.ToStringFormatted();

            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1);
        }


        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValueForTxtAddressOutput = textBox1.Text;
            ValueForTxtQuotation = txtQuotation.Text;
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }


        private void FontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            //fd.ShowDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            fontDlg.MaxSize = 16;
            fontDlg.MinSize = 8;

            if(fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                //txtOutput.Font = fontDlg.Font;
                txtCustomerName.Font = fontDlg.Font;
                txtCustomerAddr.Font = fontDlg.Font;
                txtCustomerAddr2.Font = fontDlg.Font;
                txtCustomerCity.Font = fontDlg.Font;
                txtCustZip.Font = fontDlg.Font;
                ValueForFont = fontDlg.Font;
            }
        }
        
        private void ColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            
            colorDlg.AllowFullOpen = true;
            colorDlg.AnyColor = true;
            colorDlg.Color = Color.Red;
            if(colorDlg.ShowDialog() == DialogResult.OK)
            {
                //txtOutput.ForeColor = colorDlg.Color;
                txtCustomerName.ForeColor = colorDlg.Color;
                txtCustomerAddr.ForeColor = colorDlg.Color;
                txtCustomerAddr2.ForeColor = colorDlg.Color;
                txtCustomerCity.ForeColor = colorDlg.Color;
                txtCustZip.ForeColor = colorDlg.Color;

                ValueForColor = colorDlg.Color;
            }
           
    }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanFormImproved();
        }

        private void CleanFormImproved()
        {
            foreach (var c in this.Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }

        
    }

}



