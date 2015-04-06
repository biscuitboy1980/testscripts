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

namespace TacViewLib.LinkSpecific.Surveillance.Subsurface.CreateTrack
{
	/// <summary>
	/// The CreateTrack recording.
	/// </summary>
	public partial class CreateNoStatementTOAD1
	{
		public static string ID = "Hostile";
		public static string Plat = "Bomber";
		public static string Act = "Escorting";
		public static string Stype = "F-15 EAGLE";
		
		//*******************************************************************************************//
		//********************Validates previously created track was dropped*************************//
	    //*******************************************************************************************//
		
		public static void ValidateDropTrack()
		{
			if (repo.FormTacViewC2____map__Pacifi1.PictureDropTrack1Info.Exists())
			{
				Delay.Milliseconds(1000, false);
				
				if (repo.FormTacViewC2____map__Pacifi1.PictureDropTrack1Info.Exists())					
				{
				Report.Error("Previous track did not drop attempting to drop again");
				Keyboard.Press(Keys.Escape, 1, 100, 1, false);			
				Keyboard.Press(Keys.Escape, 1, 100, 1, false);
				Keyboard.Press(Keys.Escape, 1, 100, 1, false);
				Keyboard.Press(Keys.Escape, 1, 100, 1, false);
				repo.FormTacViewC2____map__Pacifi1.PictureTrack1.Click(MouseButtons.Right);
				
				if (repo.FormRealView1.MenuItemTOADForDropTrackInfo.Exists())
					{
					repo.FormRealView1.MenuItemTOAD.Click();
					repo.FormTOAD_TrackHash3012.MenuItemDrop_Track.Click();
					repo.FormRealView2.ButtonYes1.Click();
					Delay.Milliseconds(1000, false);
					}
				
					else 
						
//						(repo.FormRealView1.MenuItemDrop_Track1ForDropTrackInfo.Exists())
						{
						repo.FormRealView1.MenuItemDrop_Track1.Click();
						repo.FormRealView2.ButtonYes1.Click();
						Delay.Milliseconds(1000, false);
						}
				}
				
			}
				
//				else return;
//					
		}



		static CreateNoStatementTOAD1()
		{
			//Your recording specific initialization code goes here.
		}

		public static void UserCodeMethod1()
		{
			//Your code here. Code inside this method will not be changed by the code generator.
			
		}

	}
}
