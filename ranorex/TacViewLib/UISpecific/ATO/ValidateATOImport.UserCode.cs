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

namespace TacViewLib.UISpecific.ATO
{
	/// <summary>
	/// The ValidateATOImport recording.
	/// </summary>
	public partial class ValidateATOImport
	{
		static ValidateATOImport()
		{
			//Your recording specific initialization code goes here.
		}

		public void CellInterface()
		{			
			Duration OrigDur = repo.FormTacViewC2.UNIT_ONEInfo.SearchTimeout;
			repo.FormTacViewC2.UNIT_ONEInfo.SearchTimeout = 3000;
			Duration OrigDur1 = repo.FormTacViewC2.UNIT_THREEInfo.SearchTimeout;
			repo.FormTacViewC2.UNIT_THREEInfo.SearchTimeout = 3000;
			
			if (repo.FormTacViewC2.UNIT_ONEInfo.Exists())
			{
				Report.Info("Mouse Right Click item 'FormTacViewC2.UNIT_ONE' at Center.");
				repo.FormTacViewC2.UNIT_ONE.Click(MouseButtons.Right);
			}
			else if (repo.FormTacViewC2.UNIT_THREEInfo.Exists())
			{
				Report.Info("Mouse Right Click item 'FormTacViewC2.UNIT_THREE' at Center.");
				repo.FormTacViewC2.UNIT_THREE.Click(MouseButtons.Right);
			}
			
			repo.FormTacViewC2.UNIT_ONEInfo.SearchTimeout = OrigDur;
			repo.FormTacViewC2.UNIT_THREEInfo.SearchTimeout = OrigDur1;			
		}

		public void Click_CellFull_Call_Sign()
		{
			if (repo.ATO.FormATO_List.CellFull_Call_Sign.Text != "Ascending")
			{
				Report.Info("Mouse Left Click item 'ATO.FormATO_List.CellFull_Call_Sign' at Center.");
				repo.ATO.FormATO_List.CellFull_Call_Sign.Click();
			}
		}

		public void Validate_CellATO_End_Time1()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='302359Z') on item 'ATO.FormATO_List.CellATO_End_Time'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellATO_End_TimeInfo, "AccessibleValue", "302359Z", Validate.DefaultMessage, false);
		}

		public void Validate_CellFull_Call_Sign11()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='APPLE01') on item 'ATO.FormATO_List.CellFull_Call_Sign1'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellFull_Call_Sign1Info, "AccessibleValue", "APPLE01", Validate.DefaultMessage, false);
		}

		public void Validate_CellMode_2_Code1()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='5501') on item 'ATO.FormATO_List.CellMode_2_Code'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellMode_2_CodeInfo, "AccessibleValue", "5501", Validate.DefaultMessage, false);
		}

		public void Validate_CellMode_3_Code1()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='5501') on item 'ATO.FormATO_List.CellMode_3_Code'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellMode_3_CodeInfo, "AccessibleValue", "5501", Validate.DefaultMessage, false);
		}

		public void Validate_CellNum_AirCraft1()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='4F5E') on item 'ATO.FormATO_List.CellNum_AirCraft'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellNum_AirCraftInfo, "AccessibleValue", "4F5E", Validate.DefaultMessage, false);
		}

		public void Validate_CellMission_Number1()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='5501') on item 'ATO.FormATO_List.CellMission_Number'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellMission_NumberInfo, "AccessibleValue", "5501", Validate.DefaultMessage, false);
		}

		public void Validate_CellAMSN1()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='GDCA') on item 'ATO.FormATO_List.CellAMSN'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellAMSNInfo, "AccessibleValue", "GDCA", Validate.DefaultMessage, false);
		}

		public void Validate_CellATO_Start_Time1()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='011600Z') on item 'ATO.FormATO_List.CellATO_Start_Time'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellATO_Start_TimeInfo, "AccessibleValue", "011600Z", Validate.DefaultMessage, false);
		}

		public void Validate_CellFull_Call_Sign21()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='XENON51') on item 'ATO.FormATO_List.CellFull_Call_Sign2'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellFull_Call_Sign2Info, "AccessibleValue", "XENON51", Validate.DefaultMessage, false);
		}

		public void Validate_CellMode_2_Code11()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='6350') on item 'ATO.FormATO_List.CellMode_2_Code1'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellMode_2_Code1Info, "AccessibleValue", "6350", Validate.DefaultMessage, false);
		}

		public void Validate_CellMode_3_Code11()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='6351') on item 'ATO.FormATO_List.CellMode_3_Code1'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellMode_3_Code1Info, "AccessibleValue", "6351", Validate.DefaultMessage, false);
		}

		public void Validate_CellNum_AirCraft11()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='2HH47') on item 'ATO.FormATO_List.CellNum_AirCraft1'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellNum_AirCraft1Info, "AccessibleValue", "2HH47", Validate.DefaultMessage, false);
		}

		public void Validate_CellMission_Number11()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='6350') on item 'ATO.FormATO_List.CellMission_Number1'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellMission_Number1Info, "AccessibleValue", "6350", Validate.DefaultMessage, false);
		}

		public void Validate_CellAMSN11()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='SUPT') on item 'ATO.FormATO_List.CellAMSN1'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellAMSN1Info, "AccessibleValue", "SUPT", Validate.DefaultMessage, false);
		}

		public void Validate_CellATO_Start_Time11()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='011400Z') on item 'ATO.FormATO_List.CellATO_Start_Time1'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellATO_Start_Time1Info, "AccessibleValue", "011400Z", Validate.DefaultMessage, false);
		}

		public void Validate_CellATO_End_Time11()
		{
			Report.Info("Validating AttributeEqual (AccessibleValue='301359Z') on item 'ATO.FormATO_List.CellATO_End_Time1'.");
			Validate.Attribute(repo.ATO.FormATO_List.CellATO_End_Time1Info, "AccessibleValue", "301359Z", Validate.DefaultMessage, false);
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}