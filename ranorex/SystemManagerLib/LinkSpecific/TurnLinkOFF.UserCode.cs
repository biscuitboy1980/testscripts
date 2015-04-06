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

namespace SystemManagerLib.LinkSpecific
{
	/// <summary>
	/// The TurnLinkOFF recording.
	/// </summary>
	public partial class TurnLinkOFF
	{
		static TurnLinkOFF()
		{
			//Your recording specific initialization code goes here.
		}

		public void TurnOFFLink()
		{
			Duration durr = 40000;  	// set timeout to 40 seconds
			Ranorex.Adapter.DefaultSearchTimeout = durr;
			
			Duration OrigDur = repo.FormSystem_Manager___UNCLASS.CellOPERInfo.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.CellOPERInfo.SearchTimeout = 500;	
			Duration OrigDur1 = repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = 500;
			Duration OrigDur2 = repo.FormSystem_Manager___UNCLASS.CellACTIVEInfo.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.CellACTIVEInfo.SearchTimeout = 500;
			Duration OrigDur3 = repo.FormSystem_Manager___UNCLASS.CellDOWNInfo.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.CellDOWNInfo.SearchTimeout = 500;
			Duration OrigDur4 = repo.FormSystem_Manager___UNCLASS.SearchTimeout;
			repo.FormSystem_Manager___UNCLASS.SearchTimeout = 500;
			
			if (repo.FormSystem_Manager___UNCLASS.CellOPERInfo.Exists())
				{
				Report.Info("Link is currently OPER, Turning off link " + currentLinkNum);
				repo.FormSystem_Manager___UNCLASS.CellOPER.Click();
				Validate.Exists(repo.FormSystem_Manager___UNCLASS.CellOFF);
				}
			else if (repo.FormSystem_Manager___UNCLASS.CellONInfo.Exists())
				{
				Report.Info("Link is currently ON, Turning off link " + currentLinkNum);
				repo.FormSystem_Manager___UNCLASS.CellON.Click();
				Validate.Exists(repo.FormSystem_Manager___UNCLASS.CellOFF);
				}
			else if (repo.FormSystem_Manager___UNCLASS.CellACTIVEInfo.Exists())
				{
				Report.Info("Link is currently ACTIVE, Turning off link " + currentLinkNum);
				repo.FormSystem_Manager___UNCLASS.CellACTIVE.Click();
				Validate.Exists(repo.FormSystem_Manager___UNCLASS.CellOFF);
				}
			else if (repo.FormSystem_Manager___UNCLASS.CellDOWNInfo.Exists())
				{
				Report.Info("Link is currently DOWN, Turning off link " + currentLinkNum);
				repo.FormSystem_Manager___UNCLASS.CellDOWN.Click();
				Validate.Exists(repo.FormSystem_Manager___UNCLASS.CellOFF);
				}
			
			repo.FormSystem_Manager___UNCLASS.CellOPERInfo.SearchTimeout = OrigDur;
			repo.FormSystem_Manager___UNCLASS.CellONInfo.SearchTimeout = OrigDur1;
			repo.FormSystem_Manager___UNCLASS.CellACTIVEInfo.SearchTimeout = OrigDur2;
			repo.FormSystem_Manager___UNCLASS.CellDOWNInfo.SearchTimeout = OrigDur3;
			repo.FormSystem_Manager___UNCLASS.SearchTimeout = OrigDur4;	
			
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

	}
}