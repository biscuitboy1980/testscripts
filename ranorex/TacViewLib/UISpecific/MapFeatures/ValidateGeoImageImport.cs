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

namespace TacViewLib.UISpecific.MapFeatures
{
	/// <summary>
	/// The ValidateGeoImageImport recording.
	/// </summary>
	[TestModule("48fbace7-e5d3-40a8-b5b0-a900f7149bad", ModuleType.Recording, 1)]
	public partial class ValidateGeoImageImport : ITestModule
	{
		/// <summary>
		/// Holds an instance of the TacViewLib.TacViewLibRepositoryUISpecific repository.
		/// </summary>
		public static TacViewLib.TacViewLibRepositoryUISpecific repo = TacViewLib.TacViewLibRepositoryUISpecific.Instance;

		static ValidateGeoImageImport instance = new ValidateGeoImageImport();

		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public ValidateGeoImageImport()
		{
		}

		/// <summary>
		/// Gets a static instance of this recording.
		/// </summary>
		public static ValidateGeoImageImport Instance
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

			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TacView_TitleBar.View' at Center.", repo.TacView_TitleBar.ViewInfo, new RecordItemIndex(0));
			repo.TacView_TitleBar.View.Click(300);
			Delay.Milliseconds(0);
			
			Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoImage.FormView.MenuItemCADRG_Geo_Image_List' at Center.", repo.GeoImage.FormView.MenuItemCADRG_Geo_Image_ListInfo, new RecordItemIndex(1));
			repo.GeoImage.FormView.MenuItemCADRG_Geo_Image_List.Click(100);
			Delay.Milliseconds(0);
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='C:\\TacViewC2\\DataFiles\\USAAll\\RPF\\A.TOC') on item 'GeoImage.FormCADRG_Geo_Image_List.Row0.CellFilename'.", repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellFilenameInfo, new RecordItemIndex(2));
				Validate.Attribute(repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellFilenameInfo, "Text", "C:\\TacViewC2\\DataFiles\\USAAll\\RPF\\A.TOC", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='CADRG') on item 'GeoImage.FormCADRG_Geo_Image_List.Row0.CellImage_Type'.", repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellImage_TypeInfo, new RecordItemIndex(3));
				Validate.Attribute(repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellImage_TypeInfo, "Text", "CADRG", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='53° 47' 35.17\" N') on item 'GeoImage.FormCADRG_Geo_Image_List.Row0.CellNorth'.", repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellNorthInfo, new RecordItemIndex(4));
				Validate.Attribute(repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellNorthInfo, "Text", "53° 47' 35.17\" N", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='32° 7' 49.87\" N') on item 'GeoImage.FormCADRG_Geo_Image_List.Row0.CellSouth'.", repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellSouthInfo, new RecordItemIndex(5));
				Validate.Attribute(repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellSouthInfo, "Text", "32° 7' 49.87\" N", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='58° 30' 0.00\" W') on item 'GeoImage.FormCADRG_Geo_Image_List.Row0.CellEast'.", repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellEastInfo, new RecordItemIndex(6));
				Validate.Attribute(repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellEastInfo, "Text", "58° 30' 0.00\" W", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			try {
				Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='133° 24' 3.65\" W') on item 'GeoImage.FormCADRG_Geo_Image_List.Row0.CellWest'.", repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellWestInfo, new RecordItemIndex(7));
				Validate.Attribute(repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellWestInfo, "Text", "133° 24' 3.65\" W", Validate.DefaultMessage, false);
				Delay.Milliseconds(100);
			} catch(Exception) { }
			
			Validate_CellZoom_Level();
			Delay.Milliseconds(120);
			
			Validate_CellFilename1();
			Delay.Milliseconds(120);
			
			Validate_CellZoom_Level1();
			Delay.Milliseconds(120);
			
		}

#region Image Feature Data
#endregion
	}
}