using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentUi
{
    public partial class StudentUi : Form
    {
        int index = 0;
        List<string> id = new List<string> { };
        List<string> name = new List<string> { };
        List<string> mobile = new List<string> { };
        List<int> age = new List<int> { };
        List<string> address = new List<string> { };
        List<double> gpaPoint = new List<double> { };
        public StudentUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text.Length == 4) //code start for id
            {
                if (id.Contains(idTextBox.Text))
                {
                    MessageBox.Show("This id already inserted.");
                    return;
                }                
            }
            else
            {
                MessageBox.Show("Id number must be 4 unique character.");
                return;
            } //code end for id

            if (nameTextBox.Text.Length <= 30)
            {
                
            }
            else
            {
                MessageBox.Show("Name must be less than or equal 30 characters.");
                return;
            }
            if (mobileTextBox.Text.Length == 11)
            {
                if (mobile.Contains(mobileTextBox.Text))
                {
                    MessageBox.Show("This mobile number already inserted.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mobile number must be 11 digit");
                return;
            }//end for mobile

            if (gpaPointTextBox.Text.Length>0 && gpaPointTextBox.Text.Length <= 4.00)
            {

            }
            else
            {
                MessageBox.Show("GPA point must be 0 - 4.00");
                return;
            }

            id.Add(idTextBox.Text);
            name.Add(nameTextBox.Text);
            mobile.Add(mobileTextBox.Text);
            age.Add(Convert.ToInt32(ageTextBox.Text));
            address.Add(addressTextBox.Text);
            gpaPoint.Add(Convert.ToDouble(gpaPointTextBox.Text));

            idTextBox.Clear();
            nameTextBox.Clear();
            mobileTextBox.Clear();
            ageTextBox.Clear();
            addressTextBox.Clear();
            gpaPointTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            for (index = 0; index < id.Count(); index++)
            {
                showRichTextBox.Text += "Id no is : " + id[index]+"\n";
                showRichTextBox.Text += "Name is : " + name[index] + "\n";
                showRichTextBox.Text += "Mobile no : " + mobile[index] + "\n";
                showRichTextBox.Text += "Age is : " + age[index] + "\n";
                showRichTextBox.Text += "Address is : " + address[index] + "\n";
                showRichTextBox.Text += "Point is : " + gpaPoint[index] + "\n\n\n";
            }
            double max = gpaPoint.Max();
            maxTextBox.Text = Convert.ToString(max);
            //maxNameTextBox.Text = name[];

            //maxTextBox.Text=Convert.ToString (gpaPoint.Max());
            

            //double maxGpa = gpaPoint.Max();
            //int nameGpa = gpaPoint.IndexOf(maxGpa);
            //string maxGpaName = name[nameGpa];
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Search for id
            if (idRadioButton.Checked)
            {
                int i = id.IndexOf(idTextBox.Text);
                if (id.Contains(idTextBox.Text))
                {
                    idTextBox.Text = id[i];
                    nameTextBox.Text = name[i];
                    mobileTextBox.Text = mobile[i];
                    ageTextBox.Text = Convert.ToString(age[i]);
                    addressTextBox.Text = address[i];
                    gpaPointTextBox.Text = Convert.ToString(gpaPoint[i]);
                }
            }
            //Search for name
            else if (nameRadioButton.Checked) {
                int j = name.IndexOf(nameTextBox.Text);
                if (name.Contains(nameTextBox.Text))
                {
                    idTextBox.Text = id[j];
                    nameTextBox.Text = name[j];
                    mobileTextBox.Text = mobile[j];
                    ageTextBox.Text = Convert.ToString(age[j]);
                    addressTextBox.Text = address[j];
                    gpaPointTextBox.Text = Convert.ToString(gpaPoint[j]);
                }
            }
            //Search for mobile
            else if (mobileRadioButton.Checked)
            {
                int k = mobile.IndexOf(mobileTextBox.Text);
                if (mobile.Contains(mobileTextBox.Text))
                {
                    idTextBox.Text = id[k];
                    nameTextBox.Text = name[k];
                    mobileTextBox.Text = mobile[k];
                    ageTextBox.Text =Convert.ToString (age[k]);
                    addressTextBox.Text = address[k];
                    gpaPointTextBox.Text =Convert.ToString (gpaPoint[k]);

                }
            }            
            else
                {
                    MessageBox.Show("Please Select the search option");
                    return;
                }
            }            
        }        
    }

