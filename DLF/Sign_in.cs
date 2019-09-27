using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;
using System.Drawing.Imaging;

namespace DLF
{
    public partial class DLF : Form
    {
        public DLF()
        {
            InitializeComponent();
        }
       
        //ON PAGE LOAD, DO THIS
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        private void DLF_Load(object sender, EventArgs e)
        {
            try
            {
                webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo VideoCaptureDevice in webcam)
                {
                    comboBox1.Items.Add(VideoCaptureDevice.Name);
                }
                comboBox1.SelectedIndex = 0;
                timeContainerLabel.Text = DateTime.Now.ToLongTimeString();
                dateContainerLabel.Text = DateTime.Now.ToLongDateString();
                timer1.Start();
                }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("there is no recognized camera device on this PC");
            }
        }
        //STATIC VALIDATION EVENTS
        private void nameValidate(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void surnameValidation(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && !(char.IsControl(e.KeyChar)) && !(char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void passwordValidate(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void steamInputValidate(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar))) 
            {
                e.Handled = true;
            }
        }
        //CLOCK TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeContainerLabel.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        //START CAM
        private void startCamButton_Click(object sender, EventArgs e)
        {
            try
            {
                cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
                cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
                cam.Start();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("there is no recognized camera device on this PC");
            }
        }
        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            selfieBox.Image = bit;
        }
        //STOP CAM
        private void stopCamButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cam.IsRunning)
                {
                    cam.Stop();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("there is no recognized camera device on this PC");
            }
        }
        //SUBMIT ALL INFO
        private void submitButton_Click(object sender, EventArgs e)
        {
            string listItems = streamList.Text;
            string firstName = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string stream = streamList.Text;
            string password = surnameTextBox.Text;
            string timecontainer = timeContainerLabel.Text;
            string datecontainer = dateContainerLabel.Text;
            string IE = streamList.Text, Safari = streamList.Text, Chrome = streamList.Text, Opera = streamList.Text, Dev_Zone = streamList.Text, MCSD = streamList.Text, MCSA = streamList.Text, CISCO = streamList.Text, SAP = streamList.Text, SAP_2 = streamList.Text;
            //EMPTY FIELD VALIDATION
            if(firstName == "" || surname == "" || stream == "" || password == "")
            {
                MessageBox.Show("You have left one or more input fields empty. Please note! 'ALL' input fields are required!");
                return;
            }
            if(stream == "Please select")
            {
                MessageBox.Show("Please select your classification");
            }

                try
            {
                switch(listItems)
                {
                    case "IE":
                        using(StreamWriter sw = new StreamWriter("Users/IE/" + firstName + datecontainer + ".doc"))
                        {
                            
                            //SAVE TEXT FIELDS
                            sw.WriteLine(firstName + Environment.NewLine + surname + Environment.NewLine + stream + Environment.NewLine + password + Environment.NewLine + timecontainer + Environment.NewLine + datecontainer);

                            // first save picturebox image to a file
                            // if it was loaded from a file in the first place
                            // then save it to a different file  
                            string filePath = "Users/IE/" + firstName + datecontainer + ".jpg";
                            selfieBox.Image.Save(filePath, ImageFormat.Jpeg);

                            //USER FEEDBACK
                            MessageBox.Show(firstName + " Your information has been submited", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Close form
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;

                    case "Safari":
                        using(StreamWriter sw = new StreamWriter("Users/Safari/" + firstName + datecontainer + ".doc"))
                        {
                            //SAVE TEXT FIELDS

                            sw.WriteLine(firstName + Environment.NewLine + surname + Environment.NewLine + stream + Environment.NewLine + password + Environment.NewLine + timecontainer + Environment.NewLine + datecontainer);

                            // first save picturebox image to a file
                            // if it was loaded from a file in the first place
                            // then save it to a different file  
                            string filePath = "Users/Safari/" + firstName + datecontainer + ".jpg";
                            selfieBox.Image.Save(filePath, ImageFormat.Jpeg);

                            //USER FEEDBACK
                            MessageBox.Show(firstName + " Your information has been submited", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Close form
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;

                    case "Opera":
                        using (StreamWriter sw = new StreamWriter("Users/Opera/" + firstName + datecontainer + ".doc"))
                        {
                            //SAVE TEXT FIELDS

                            sw.WriteLine(firstName + Environment.NewLine + surname + Environment.NewLine + stream + Environment.NewLine + password + Environment.NewLine + timecontainer + Environment.NewLine + datecontainer);

                            // first save picturebox image to a file
                            // if it was loaded from a file in the first place
                            // then save it to a different file  
                            string filePath = "Users/Opera/" + firstName + datecontainer + ".jpg";
                            selfieBox.Image.Save(filePath, ImageFormat.Jpeg);

                            //USER FEEDBACK
                            MessageBox.Show(firstName + " Your information has been submited", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Close form
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;

                    case "Chrome":
                        using (StreamWriter sw = new StreamWriter("Users/Chrome/" + firstName + datecontainer + ".doc"))
                        {
                            //SAVE TEXT FIELDS

                            sw.WriteLine(firstName + Environment.NewLine + surname + Environment.NewLine + stream + Environment.NewLine + password + Environment.NewLine + timecontainer + Environment.NewLine + datecontainer);

                            // first save picturebox image to a file
                            // if it was loaded from a file in the first place
                            // then save it to a different file  
                            string filePath = "Users/Chrome/" + firstName + datecontainer + ".jpg";
                            selfieBox.Image.Save(filePath, ImageFormat.Jpeg);

                            //USER FEEDBACK
                            MessageBox.Show(firstName + " Your information has been submited", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Close form
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;

                    case "Dev Zone":
                        using (StreamWriter sw = new StreamWriter("Users/Dev_Zone/" + firstName + datecontainer + ".doc"))
                        {
                            //SAVE TEXT FIELDS

                            sw.WriteLine(firstName + Environment.NewLine + surname + Environment.NewLine + stream + Environment.NewLine + password + Environment.NewLine + timecontainer + Environment.NewLine + datecontainer);

                            // first save picturebox image to a file
                            // if it was loaded from a file in the first place
                            // then save it to a different file  
                            string filePath = "Users/Dev_Zone/" + firstName + datecontainer + ".jpg";
                            selfieBox.Image.Save(filePath, ImageFormat.Jpeg);

                            //USER FEEDBACK
                            MessageBox.Show(firstName + " Your information has been submited", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Close form
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;

                    case "MCSD":
                        using (StreamWriter sw = new StreamWriter("Users/MCSD/" + firstName + datecontainer + ".doc"))
                        {
                            //SAVE TEXT FIELDS

                            sw.WriteLine(firstName + Environment.NewLine + surname + Environment.NewLine + stream + Environment.NewLine + password + Environment.NewLine + timecontainer + Environment.NewLine + datecontainer);

                            // first save picturebox image to a file
                            // if it was loaded from a file in the first place
                            // then save it to a different file  
                            string filePath = "Users/MCSD/" + firstName + datecontainer + ".jpg";
                            selfieBox.Image.Save(filePath, ImageFormat.Jpeg);

                            //USER FEEDBACK
                            MessageBox.Show(firstName + " Your information has been submited", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Close form
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;

                    case "MCSA":
                        using (StreamWriter sw = new StreamWriter("Users/MCSA/" + firstName + datecontainer + ".doc"))
                        {
                            //SAVE TEXT FIELDS

                            sw.WriteLine(firstName + Environment.NewLine + surname + Environment.NewLine + stream + Environment.NewLine + password + Environment.NewLine + timecontainer + Environment.NewLine + datecontainer);

                            // first save picturebox image to a file
                            // if it was loaded from a file in the first place
                            // then save it to a different file  
                            string filePath = "Users/MCSA/" + firstName + datecontainer + ".jpg";
                            selfieBox.Image.Save(filePath, ImageFormat.Jpeg);

                            //USER FEEDBACK
                            MessageBox.Show(firstName + " Your information has been submited", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Close form
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;

                    case "CISCO":
                        using (StreamWriter sw = new StreamWriter("Users/CISCO/" + firstName + datecontainer + ".doc"))
                        {
                            //SAVE TEXT FIELDS

                            sw.WriteLine(firstName + Environment.NewLine + surname + Environment.NewLine + stream + Environment.NewLine + password + Environment.NewLine + timecontainer + Environment.NewLine + datecontainer);

                            // first save picturebox image to a file
                            // if it was loaded from a file in the first place
                            // then save it to a different file  
                            string filePath = "Users/CISCO/" + firstName + datecontainer + ".jpg";
                            selfieBox.Image.Save(filePath, ImageFormat.Jpeg);

                            //USER FEEDBACK
                            MessageBox.Show(firstName + " Your information has been submited", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Close form
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;

                    case "SAP":
                        using (StreamWriter sw = new StreamWriter("Users/SAP/" + firstName + datecontainer + ".doc"))
                        {
                            //SAVE TEXT FIELDS

                            sw.WriteLine(firstName + Environment.NewLine + surname + Environment.NewLine + stream + Environment.NewLine + password + Environment.NewLine + timecontainer + Environment.NewLine + datecontainer);

                            // first save picturebox image to a file
                            // if it was loaded from a file in the first place
                            // then save it to a different file  
                            string filePath = "Users/SAP/" + firstName + datecontainer + ".jpg";
                            selfieBox.Image.Save(filePath, ImageFormat.Jpeg);

                            //USER FEEDBACK
                            MessageBox.Show(firstName + " Your information has been submited", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Close form
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;

                    case "SAP-2":
                        using (StreamWriter sw = new StreamWriter("Users/SAP_2/" + firstName + datecontainer + ".doc"))
                        {
                            //SAVE TEXT FIELDS

                            sw.WriteLine(firstName + Environment.NewLine + surname + Environment.NewLine + stream + Environment.NewLine + password + Environment.NewLine + timecontainer + Environment.NewLine + datecontainer);

                            // first save picturebox image to a file
                            // if it was loaded from a file in the first place
                            // then save it to a different file  
                            string filePath = "Users/SAP_2/" + firstName + datecontainer + ".jpg";
                            selfieBox.Image.Save(filePath, ImageFormat.Jpeg);

                            //USER FEEDBACK
                            MessageBox.Show(firstName + " Your information has been submited", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Close form
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        break;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("You have left one or more input fields empty. Please note! 'ALL' input fields are required!");
            }
            catch (ApplicationException)
            {
                MessageBox.Show("something went wrong, please try again");
            }
            catch (VideoException)
            {
                MessageBox.Show("something went wrong, please try again");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("there is no recognized camera device on this PC");
            }
        }
    }
}

