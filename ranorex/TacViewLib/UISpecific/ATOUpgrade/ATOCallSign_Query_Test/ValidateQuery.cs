﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;

namespace TacViewLib.UISpecific.ATOUpgrade.ATOCallSign_Query_Test
{
	/// <summary>
	/// The ValidateQuery recording.
	/// </summary>
	[TestModule("6b619463-2a3a-47b6-bff0-ef9d4ebaaf99", ModuleType.Recording, 1)]
	public partial class ValidateQuery : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.ATOUpgradeRepository repository.
		/// </summary>
		public static TacViewLib.ATOUpgradeRepository repo = TacViewLib.ATOUpgradeRepository.Instance;

		static ValidateQuery instance = new ValidateQuery();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ValidateQuery()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static ValidateQuery Instance
		{
			get { return instance; }
		}

#region Variables

#endregion

		/// <summary>
		/// Starts the replay of the static recording <see cref="Instance"/>.
		/// </summary>
		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.0.0")]
		public static void Start()
		{
			TestModuleRunner.Run(Instance);
		}

		/// <summary>
		/// Performs the playback of actions in this recording.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		[System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.0.0")]
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 150;
			Keyboard.DefaultKeyPressTime = 25;
			Delay.SpeedFactor = 1.0;

			Init();

			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibleValue='GABBY61') on item 'FormRealView1.Row0.CellATO_Call_Sign'.", repo.FormRealView1.Row0.CellATO_Call_SignInfo, new RecordItemIndex(0));
				Validate.Attribute(repo.FormRealView1.Row0.CellATO_Call_SignInfo, "AccessibleValue", "GABBY61", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FormRealView1.Row0.CellMissionKey'.", repo.FormRealView1.Row0.CellMissionKeyInfo, new RecordItemIndex(1));
			Validate.Exists(repo.FormRealView1.Row0.CellMissionKeyInfo);
			Delay.Milliseconds(100);
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibleValue='') on item 'FormRealView1.Row0.CellMode1Code'.", repo.FormRealView1.Row0.CellMode1CodeInfo, new RecordItemIndex(2));
				Validate.Attribute(repo.FormRealView1.Row0.CellMode1CodeInfo, "AccessibleValue", "", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibleValue='6161') on item 'FormRealView1.Row0.CellMode_2_Code'.", repo.FormRealView1.Row0.CellMode_2_CodeInfo, new RecordItemIndex(3));
				Validate.Attribute(repo.FormRealView1.Row0.CellMode_2_CodeInfo, "AccessibleValue", "6161", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibleValue='6161') on item 'FormRealView1.Row0.CellMode_3_Code'.", repo.FormRealView1.Row0.CellMode_3_CodeInfo, new RecordItemIndex(4));
				Validate.Attribute(repo.FormRealView1.Row0.CellMode_3_CodeInfo, "AccessibleValue", "6161", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibleValue='') on item 'FormRealView1.Row0.CellJUAddress'.", repo.FormRealView1.Row0.CellJUAddressInfo, new RecordItemIndex(5));
				Validate.Attribute(repo.FormRealView1.Row0.CellJUAddressInfo, "AccessibleValue", "", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='') on item 'FormRealView1.Row0.CellLink_16_Call_Sign'.", repo.FormRealView1.Row0.CellLink_16_Call_SignInfo, new RecordItemIndex(6));
			Validate.Attribute(repo.FormRealView1.Row0.CellLink_16_Call_SignInfo, "AccessibleValue", "");
			Delay.Milliseconds(100);
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibleValue='2') on item 'FormRealView1.Row0.CellNumber_of_Aircraft'.", repo.FormRealView1.Row0.CellNumber_of_AircraftInfo, new RecordItemIndex(7));
				Validate.Attribute(repo.FormRealView1.Row0.CellNumber_of_AircraftInfo, "AccessibleValue", "2", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibleValue='A4W1') on item 'FormRealView1.Row0.CellPrimary_Config_Code'.", repo.FormRealView1.Row0.CellPrimary_Config_CodeInfo, new RecordItemIndex(8));
				Validate.Attribute(repo.FormRealView1.Row0.CellPrimary_Config_CodeInfo, "AccessibleValue", "A4W1", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibleValue='A4W1') on item 'FormRealView1.Row0.CellSecondary_Config_Code'.", repo.FormRealView1.Row0.CellSecondary_Config_CodeInfo, new RecordItemIndex(9));
				Validate.Attribute(repo.FormRealView1.Row0.CellSecondary_Config_CodeInfo, "AccessibleValue", "A4W1", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibleValue='') on item 'FormRealView1.Row0.CellTACAN_Channel'.", repo.FormRealView1.Row0.CellTACAN_ChannelInfo, new RecordItemIndex(10));
				Validate.Attribute(repo.FormRealView1.Row0.CellTACAN_ChannelInfo, "AccessibleValue", "", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (AccessibleValue='ACTYP:F5E') on item 'FormRealView1.Row0.CellAC_Type'.", repo.FormRealView1.Row0.CellAC_TypeInfo, new RecordItemIndex(11));
				Validate.Attribute(repo.FormRealView1.Row0.CellAC_TypeInfo, "AccessibleValue", "ACTYP:F5E", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'FormRealView1.Row0.CellPkey'.", repo.FormRealView1.Row0.CellPkeyInfo, new RecordItemIndex(12));
				Validate.Exists(repo.FormRealView1.Row0.CellPkeyInfo, Validate.DefaultMessage, false);
				Delay.Milliseconds(4120);
			} catch(Exception) { }
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView1.ButtonCLOSE' at Center.", repo.FormRealView1.ButtonCLOSEInfo, new RecordItemIndex(13));
			repo.FormRealView1.ButtonCLOSE.Click();
			Delay.Milliseconds(0);
			
		}

#region Image Feature Data
#endregion
	}
}
