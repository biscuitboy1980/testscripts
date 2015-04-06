/*
 * Created by Ranorex
 * User: gguenther
 * Date: 8/4/2011
 * Time: 1:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace CommonUtilLib.Forms
{
	/// <summary>
	/// Description of SetupForm.
	/// </summary>
	public partial class SetupForm : Form
	{
		public SetupForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			numericUpDown1.ResetText();
			this.Activate();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void  OnButton1Clicked(Object sender, EventArgs e)
	  	{
			bool ErrFlag = false;		
				
//			CommonUtilLib.CreateSocket.InjectorValidator = this.comboBox1.Text;
//			CommonUtilLib.CreateSocket.ServerClientMode = this.comboBox2.Text;
//			CommonUtilLib.CreateSocket.IPaddress = this.maskedTextBox1.Text;
//			CommonUtilLib.CreateSocket.Port = this.numericUpDown1.Text;		
			
			// Validate IP Address
			string IP = maskedTextBox1.Text;
			
			string IPAdress =@"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$";
	 		
			if (IP == "")
			{
				MessageBox.Show("IP Address is Required.", "Invalid IP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	            maskedTextBox1.Focus();
	            ErrFlag = true;
			}		
	 		else if (System.Text.RegularExpressions.Regex.IsMatch(IP,IPAdress) == false)
	 		{
	 			MessageBox.Show("Invalid IP Address.", "Invalid IP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	 			maskedTextBox1.Clear();
	 			maskedTextBox1.Focus();
	            ErrFlag = true;
	 		}		
		
			// Validate Port
			else if (numericUpDown1.Text == "")
			{
				MessageBox.Show("Port Number is Required.", "Invalid Port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	            numericUpDown1.Focus();
	            ErrFlag = true;
			}
			else
			{
				ErrFlag = false;
			}
				
			if (!ErrFlag)
			{
				this.Close();
			}
		}
		
		public void OnButton2Clicked(Object sender,EventArgs e)
	  	{
			this.Close();
			Environment.Exit(-1);
	  	}
	}
}
