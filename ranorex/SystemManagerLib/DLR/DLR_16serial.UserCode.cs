﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using Ranorex;
using Ranorex.Core;

namespace SystemManagerLib.DLR
{
	/// <summary>
	/// The DLR_16serial recording.
	/// </summary>
	public partial class DLR_16serial
	{
		static DLR_16serial()
		{
			Report.Info("DLR'ing Serial Link 16");
			//Your recording specific initialization code goes here.
		}

		public void Selectxport()
		{
			Report.Info("selecting xport");
			switch (xport)
			{
				case "1":
					repo.FormSm.ListItem1.Click();
					break;
				case "2":
					repo.FormSm.ListItem2.Click();
					break;
				case "3":
					repo.FormSm.ListItem3.Click();
					break;
				case "4":
					repo.FormSm.ListItem4.Click();
					break;
				case "5":
					repo.FormSm.ListItem5.Click();
					break;
				case "6":
					repo.FormSm.ListItem6.Click();
					break;
				case "7":
					repo.FormSm.ListItem7.Click();
					break;
				case "8":
					repo.FormSm.ListItem8.Click();
					break;
				case "9":
					repo.FormSm.ListItem9.Click();
					break;
				case "10":
					repo.FormSm.ListItem10.Click();
					break;
				case "11":
					repo.FormSm.ListItem11.Click();
					break;
				case "12":
					repo.FormSm.ListItem12.Click();
					break;
				case "13":
					repo.FormSm.ListItem13.Click();
					break;
				case "14":
					repo.FormSm.ListItem14.Click();
					break;
				case "15":
					repo.FormSm.ListItem15.Click();
					break;
				case "16":
					repo.FormSm.ListItem16.Click();
					break;
			}
			
		}

		public void selectxport()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			Report.Info("Mouse Left Click item 'FormSm.ListItem4' at 6;7.");
			repo.FormSm.ListItem4.Click("6;7");
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

	}
}
