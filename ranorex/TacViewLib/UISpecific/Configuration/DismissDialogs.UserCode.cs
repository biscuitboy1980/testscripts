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

namespace TacViewLib.UISpecific.Configuration
{
	/// <summary>
	/// The DismissDialogs recording.
	/// </summary>
	public partial class DismissDialogs
	{
		static DismissDialogs()
		{
			//Your recording specific initialization code goes here.
		}
		public int maxDialogsToDismiss = 40;
		
		public void Dismiss()
		{
			Duration origDur1 = repo.FormTacViewC2____map__Defaul.SearchTimeout;
			Duration origDur2 = repo.Form___map__not_loaded___ter.SearchTimeout;
			Duration origDur3 = repo.RealViewDialog.SearchTimeout;
			Duration origDur4 = repo.RealViewDialog.DialogBoxInfo.SearchTimeout;
			
			repo.FormTacViewC2____map__Defaul.SearchTimeout = 1000;
			repo.Form___map__not_loaded___ter.SearchTimeout = 1000;
			repo.RealViewDialog.SearchTimeout = 1000;
			repo.RealViewDialog.DialogBoxInfo.SearchTimeout = 1000;
			int maxDelays = 10;
			int maxDismissals = maxDialogsToDismiss;
			bool warningFree = true;
			while( (maxDelays > 0 && maxDismissals > 0) )
			{
				if(repo.FormTacViewC2____map__Defaul.SelfInfo.Exists() || repo.Form___map__not_loaded___ter.SelfInfo.Exists() )
					break; //TacView loaded
				
				if(repo.RealViewDialog.DialogBoxInfo.Exists() ) //Warning dialogs
				{
					Report.Error("Error during loading.");
					Report.Screenshot();
					Report.Info("Mouse Left Click item 'RealViewDialog.ButtonOK'");
					repo.RealViewDialog.ButtonOK.Click();
					warningFree = false;
					maxDismissals--;
				}
				else
					maxDelays--;
			}
			
			Validate.IsTrue(warningFree,"Validate TacView started in " + TacViewLib.UISpecific.Configuration.SetConfiguration.config + " mode without any warnings.", false);
			
			if(!repo.FormTacViewC2____map__Defaul.FormTacViewC2____map__DefaulInfo.Exists() && !repo.Form___map__not_loaded___ter.Form___map__not_loaded___terInfo.Exists() )
			{
				Report.Screenshot();
				Report.Error("TacView Failed to Load in " + TacViewLib.UISpecific.Configuration.SetConfiguration.config + " mode.");
			}
			Validate.IsTrue( (repo.FormTacViewC2____map__Defaul.FormTacViewC2____map__DefaulInfo.Exists() || repo.Form___map__not_loaded___ter.Form___map__not_loaded___terInfo.Exists() ), "Validating that TacView started.");
						
			repo.FormTacViewC2____map__Defaul.SearchTimeout = origDur1;
			repo.Form___map__not_loaded___ter.SearchTimeout = origDur2;
			repo.RealViewDialog.SearchTimeout = origDur3;
			repo.RealViewDialog.DialogBoxInfo.SearchTimeout = origDur4;
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}
