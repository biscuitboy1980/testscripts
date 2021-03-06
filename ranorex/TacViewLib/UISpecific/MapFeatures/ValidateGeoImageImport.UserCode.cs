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

namespace TacViewLib.UISpecific.MapFeatures
{
	/// <summary>
	/// The ValidateGeoImageImport recording.
	/// </summary>
	public partial class ValidateGeoImageImport
	{
		public bool Defect04758;
		static ValidateGeoImageImport()
		{
			//Your recording specific initialization code goes here.
		}

		public void Validate_CellFilename()
		{
			Report.Info("Validating AttributeEqual (Text='C:\\TacViewC2\\DataFiles\\USA all\\RPF\\A.TOC') on item 'GeoImage.FormCADRG_Geo_Image_List.Row0.CellFilename'.");
			Validate.Attribute(repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellFilenameInfo, "Text", "C:\\TacViewC2\\DataFiles\\USAAll\\RPF\\A.TOC", Validate.DefaultMessage, false);
		}

		public void Validate_CellZoom_Level()
		{
			if(Defect04758)
			{
				Report.Info("Validating AttributeEqual (Text='1:500K') on item 'GeoImage.FormCADRG_Geo_Image_List.Row0.CellZoom_Level'.");
				Validate.Attribute(repo.GeoImage.FormCADRG_Geo_Image_List.Row0.CellZoom_LevelInfo, "Text", "1:500K", Validate.DefaultMessage, false);
			}
		}

		public void Validate_CellFilename1()
		{
			if(Defect04758)
			{
				Report.Info("Validating AttributeEqual (Text='C:\\TacViewC2\\DataFiles\\USA all\\RPF\\A.TOC') on item 'GeoImage.FormCADRG_Geo_Image_List.CellFilename1'.");
				Validate.Attribute(repo.GeoImage.FormCADRG_Geo_Image_List.CellFilename1Info, "Text", "C:\\TacViewC2\\DataFiles\\USAAll\\RPF\\A.TOC", Validate.DefaultMessage, false);
			}
		}

		public void Validate_CellZoom_Level1()
		{
			if(Defect04758)
			{
				Report.Info("Validating AttributeEqual (Text='1:1M') on item 'GeoImage.FormCADRG_Geo_Image_List.CellZoom_Level1'.");
				Validate.Attribute(repo.GeoImage.FormCADRG_Geo_Image_List.CellZoom_Level1Info, "Text", "1:1M", Validate.DefaultMessage, false);
			}
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}
