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
using System.IO;

using Ranorex;
using Ranorex.Core;

namespace TacViewLib.UISpecific.Configuration
{
	/// <summary>
	/// The SelectDefaultMap recording.
	/// </summary>
	public partial class SelectDefaultMap
	{
		static SelectDefaultMap()
		{
			//Your recording specific initialization code goes here.
		}
		public void SetDefaultMap()
		{
			Duration origDur = repo.Load_Map_Pop_Up.SearchTimeout;
			repo.Load_Map_Pop_Up.SearchTimeout = 3000;
			
			Report.Info("Dismiss Map dialog if present, selecting default map.");
			if(repo.Load_Map_Pop_Up.SelfInfo.Exists())
			{
				Report.Info("Mouse Left Click item 'Load_Map_Pop_Up.Cancel' at Center.");
				repo.Load_Map_Pop_Up.Cancel.Click();
			}
			repo.Load_Map_Pop_Up.SearchTimeout = origDur;	
			
			Delay.Milliseconds(2000); //let TacView finish loading
			
			if(!repo.FormTacViewC2____map__Defaul1.FormTacViewC2____map__DefaulInfo.Exists()  )
			{
				Report.Screenshot();
				Report.Error("TacView Failed to Load in " + TacViewLib.UISpecific.Configuration.SetConfiguration.config + " mode.");
			}
			Validate.IsTrue( (repo.FormTacViewC2____map__Defaul1.FormTacViewC2____map__DefaulInfo.Exists() ), "Validating that TacView started.");
			
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}