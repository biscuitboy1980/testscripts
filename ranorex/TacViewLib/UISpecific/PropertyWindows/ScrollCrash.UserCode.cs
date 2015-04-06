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

namespace TacViewLib.UISpecific.PropertyWindows
{
	/// <summary>
	/// The ScrollCrash recording.
	/// </summary>
	public partial class ScrollCrash
	{
		public string recipient;
		
		static ScrollCrash()
		{
			
		}

		public void ScrollDown()
		{	
			Mouse.ScrollWheel(-.5);			
			Report.Info("Mouse Scroll Down");
			
			Mouse.ScrollWheel(.5);	
			Report.Info("Mouse Scroll Up");
		}

		public void JUTrackNum()
		{
			Duration OrigDur = repo.FormTacViewC2.UNIT_ONEInfo.SearchTimeout;
			repo.FormTacViewC2.UNIT_ONEInfo.SearchTimeout = 2000;
			
			if (repo.FormTacViewC2.UNIT_ONEInfo.Exists())
			{
			Accessible accElement = new Accessible(repo.FormTacViewC2.UNIT_ONE);  
   			recipient = accElement.Value;
			}
			else
			{
			Accessible accElement = new Accessible(repo.FormTacViewC2.UNIT_THREE);  
   			recipient = accElement.Value;
			}
   			
			Report.Info("Key sequence 'JU Track Number'.");
			Keyboard.Press(recipient);
			
			repo.FormTacViewC2.UNIT_ONEInfo.SearchTimeout = OrigDur;
		}
		
		public void JUSelect()
		{
			if( TacViewLib.UISpecific.Configuration.Common.JUSelect(recipient) )
			{
				Report.Info("Mouse Left Click item 'FormTOAD.MenuItemTrack_Properties' at Center.");
				repo.FormTOAD.MenuItemTrack_Properties.Click("Center");
			}
			else
			{
				Report.Info("Mouse Left Click item 'FormRealView.MenuItemTrack_Properties' at Center.");
				repo.FormRealView.MenuItemTrack_Properties.Click("Center");				
			}
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}