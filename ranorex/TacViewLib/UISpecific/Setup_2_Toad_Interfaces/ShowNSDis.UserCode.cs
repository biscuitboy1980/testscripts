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

namespace TacViewLib.UISpecific.Setup_2_Toad_Interfaces
{
	/// <summary>
	/// The Recording1 recording.
	/// </summary>
	public partial class ShowNSDis
	{
		
		
		public void Validate_NS_Is_Enabled()
		{
			if  (repo.FormPreferences.CheckBoxDisplay_No_Statement_val.Checked)
			{
				return;
			
			}
			else 
				
				repo.FormPreferences.CheckBoxDisplay_No_Statement_val.Click();
			
		}

		static ShowNSDis()
		{
			//Your recording specific initialization code goes here.
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

	}
}
