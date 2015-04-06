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

namespace TacViewLib.UISpecific.ATOUpgrade.Mode2andMode3Codes_Correlation_Test
{
	/// <summary>
	/// The Initialization recording.
	/// </summary>
	public partial class Initialization
	{
		static Initialization()
		{
			//Your recording specific initialization code goes here.
		}
		
		public void InterfaceOFF()
		{
			//Turn off C2 HOST 2 if Necessary
			if (repo.FormTacViewC2.STATUS_TWO.Text.Equals("OPER"))
			{
				Report.Info("Mouse Left Click item 'FormTacViewC2.STATUS_TWO' at CenterLeft.");
				repo.FormTacViewC2.STATUS_TWO.Click(Location.CenterLeft);
				Delay.Milliseconds(350);
			}
		}		
		
		public void CloseDialog()
		{
			while (repo.FormATO_Import_Progress.SelfInfo.Exists())
			{
				//wait
				Keyboard.Press(Keys.Return, Keyboard.DefaultScanCode, 1, 1, true);
			}
		}		

		public void SelectionCriteria_Mode2_Only()
		{
			Report.Info("Unselecting Mode 2 then Mode 3");
			repo.FormCorrelation_Criteria.List10081.ListItemMode_2_over_Mode_3__Track.Click("8;10");
			
			Report.Info("Selecting Mode 2 and Mode 3");
			repo.FormCorrelation_Criteria.List10081.ListItemMode_2_and_3__Track_Modes.Click("8;10");	
		}

		public void EnableATOs()
		{
			Report.Info("Manually Enabling ATO's if Necessary");
			if (repo.FormSet_ATO_List_State.MenuItemManually_Enabled.Enabled == true)
			{
				repo.FormSet_ATO_List_State.MenuItemManually_Enabled.Click("Center");
			}	
			else
			{
				Keyboard.Press(Keys.Escape);				
			}
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}
