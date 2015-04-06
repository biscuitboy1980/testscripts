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

namespace TacViewLib.UISpecific.ATOUpgrade.ATO2orMoreAircraft_Query_Test
{
	/// <summary>
	/// The CreateQuery recording.
	/// </summary>
	public partial class CreateQuery
	{
		static CreateQuery()
		{
			//Your recording specific initialization code goes here.
		}
		
		//************************************************************************************//
		//*******************************Enters User Query************************************//
		//************************************************************************************//
		
		public void SelectQuery()
		{
			int x = 0;
			
			while (x < 2)
			{
				try
				{
				    Keyboard.Press("{LMenu down}{Down}{LMenu up}");				    
					repo.ListRealView.ListItemTwo_or_More_Aircraft.Select();
		       		repo.ListRealView.ListItemTwo_or_More_Aircraft.Click();
		   			string QueryValue = repo.FormRun_User_Query.Text1001.SelectedItemText;
		   			Report.Info("Query Selected = " + QueryValue);
		   			ValidateQuery.QueryOOR = false;
		   			x=2;
				}
				catch (ArgumentOutOfRangeException e)
				{								   			
			   		x++;
			   		if (x == 1)
			   		{
			   			Report.Debug("List Count Out of Range for Query Name, Re-Executing Function");
			   			Report.Debug(e.ToString());	
			   		}
			   		else if (x == 2)
			   		{
			   			Report.Debug("List Count Out of Range for Query Name, List Item Will Not be Validated");
			   			Report.Debug(e.ToString());	
			   			ValidateQuery.QueryOOR = true;
			   		}
				}			
			}
		}

		public void UserCodeMethod1()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			
		}
	}
}
