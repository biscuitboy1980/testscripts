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

namespace TacViewLib.UISpecific.Display
{
	/// <summary>
	/// The CheckDisplay recording.
	/// </summary>
	public partial class CheckDisplay
	{
		static CheckDisplay()
		{
			//Your recording specific initialization code goes here.
		}
		public string Unit1;
		public string Unit2;
		
		public void TurnOffAllInterfaces()
		{
			Report.Info("This test assumes Interface 1 is C2 Host.");
			foreach( Ranorex.Row row in repo.FormTacViewC2.Host_Interface_Control.Rows)
			{
				if( !row.Cells[0].Text.Equals("OFF") )
				{
					Report.Info("Turning off " + row.Cells[1].Text + " which was set to " + row.Cells[0].Text);
					row.Cells[0].Click(Location.CenterLeft);
				}
			}
		}

		public void Take_Force_Authority()
		{
			Report.Info("If item 'FormRealView4.MenuItemTake_Force_Authority' exists click at center.");
			if( repo.FormRealView4.MenuItemTake_Force_AuthorityInfo.Exists() )
			{
				Report.Info("Mouse Left Click item 'FormRealView4.MenuItemTake_Force_Authority' at Center.");
				repo.FormRealView4.MenuItemTake_Force_Authority.Click();
				Delay.Milliseconds(5000, false);				
			}
		}
		
		
		public void Release_Force_Authority()
		{
			Report.Info("If item 'MenuItemRelease_Force_AuthorityInfo' exists click at center.");
			if( repo.MenuItemRelease_Force_AuthorityInfo.Exists() )
			{
				Report.Info("Mouse Left Click item 'MenuItemRelease_Force_AuthorityInfo' at Center.");
				repo.MenuItemRelease_Force_Authority.Click();
				Delay.Milliseconds(5000, false);				
			}
		}

		public void Validate_Unit1()
		{
			TacViewLib.UISpecific.Configuration.EnterInterface1IP.Validate_Unit();
		}
		public void Validate_Unit2()
		{
			TacViewLib.UISpecific.Configuration.EnterInterface2IP.Validate_Unit();
		}

		public void Validate_InterfaceText()
		{
			TacViewLib.UISpecific.Configuration.EnterInterface1IP.ValidateInterfaceText();
			TacViewLib.UISpecific.Configuration.EnterInterface2IP.ValidateInterfaceText();
		}

		public void Enable_Interface_One()
		{
			TacViewLib.UISpecific.Configuration.EnterInterface1IP.EnsureInterface1On();
		}

		public void Enable_Interface_Two()
		{
			TacViewLib.UISpecific.Configuration.EnterInterface2IP.EnsureInterface2On();
		}

		public void Mouse_Right_Click_Interface_One()
		{
			TacViewLib.UISpecific.Configuration.EnterInterface1IP.RightClickInterface();
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}
