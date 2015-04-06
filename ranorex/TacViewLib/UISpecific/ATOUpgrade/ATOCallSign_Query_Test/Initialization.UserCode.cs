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

namespace TacViewLib.UISpecific.ATOUpgrade.ATOCallSign_Query_Test
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
	}
}
