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

namespace TacViewLib.UISpecific.SendImageJ16
{
	/// <summary>
	/// The ValidateTwoWayReceived recording.
	/// </summary>
	public partial class ValidateTwoWayReceived
	{
		public static bool SuccessFlag;
		
		public static string password2;
		public static string username2;
		
		static ValidateTwoWayReceived()
		{
			//Your recording specific initialization code goes here.
		}
		
		public void Mouse_Click_CellAlert()
		{
			bool alertSendComplete = false;
			bool alertImageReceived = false;
			Cell imageReceived = null;
			foreach( Ranorex.Row row in repo.FormTacViewC2____map__Defaul1.TableEventHistory.Rows)
			{
				foreach( Cell cell in row.Cells )
				{
					if( cell.Text.Contains("Image Send Completed") )
					{
						alertSendComplete = true;
					}
					    
					if( cell.Text.Contains( "Image Received" ) )
					{
						alertImageReceived = true;
						imageReceived = cell;
					}
				}
			}
			
			if ( alertSendComplete && alertImageReceived )
			{			
				SuccessFlag = true;
	
				Report.Info("Mouse Left Click Image Received Alert at Center.");
				imageReceived.Click();
				
				Delay.Milliseconds(1000);		
				
				Report.Info("Mouse Left DoubleClick FormRealView at (175;107).");
				repo.FormRealView.Self.Click("175;107");
				
				if (repo.FormUsername_and_Password.TextUsernameInfo.Exists())
				{
					Keyboard.Press(username2, 1);
					Keyboard.Press(Keys.Tab, 15, Keyboard.DefaultKeyPressTime, 1, false);
					Keyboard.Press(password2, 1);
					Keyboard.Press(Keys.Return, 15, Keyboard.DefaultKeyPressTime, 1, false);
				}
				Validate.IsTrue(TacViewLib.UISpecific.Configuration.Common.ValidateNoUnexpectedDialogs());
			}
			else
			{
				SuccessFlag = false;
				Report.Error("J16 Send Image Failed. Aborting Image Validation");	
				Report.Screenshot();
			}
		}

		public void Validate_FormImage_Viewer()
		{
			if (SuccessFlag)
			{
				Report.Info("Validating Exists on item 'SendImageJ16.FormImage_Viewer.FormImage_Viewer'.");
				Validate.Exists(repo.SendImageJ16.FormImage_Viewer.FormImage_ViewerInfo, Validate.DefaultMessage, false);
			}
		}

		public void Validate_Container1004()
		{
			if (SuccessFlag)
			{
				Report.Info("Validating ContainsImage (Screenshot: 'Screenshot5' with region {X=0,Y=0,Width=186,Height=162}) on item 'SendImageJ16.FormImage_Viewer.Container1004'.");
				Validate.ContainsImage(repo.SendImageJ16.FormImage_Viewer.Container1004Info, Container1004_Screenshot5, Container1004_Screenshot5_Options, Validate.DefaultMessage, false);
			}
		}

		public void Mouse_Click_ButtonCLOSE()
		{
			if (SuccessFlag)
			{
				Report.Info("Mouse Left Click item 'SendImageJ16.FormImage_Viewer.ButtonCLOSE' at Center.");
				repo.SendImageJ16.FormImage_Viewer.ButtonCLOSE.Click();
			}
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}
