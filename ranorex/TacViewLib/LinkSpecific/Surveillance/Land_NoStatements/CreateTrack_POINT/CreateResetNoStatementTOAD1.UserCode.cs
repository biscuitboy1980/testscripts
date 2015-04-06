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

namespace TacViewLib.LinkSpecific.Surveillance.Land_NoStatements.CreateTrack_POINT
{
	/// <summary>
	/// The CreateTrack recording.
	/// </summary>
	
	
		//************************************************************************************//
		//**************Default values to enter for track if csv file not present*************//
		//************************************************************************************//
	
	public partial class CreateResetNoStatementTOAD1
	{
		public static string Ind = "POINT";
		public static string ID = "Pending";
		public static string Plat = "Tank";
		public static string Act = "Moving";
		public static string Stype = "NUCLEAR WEAPONS";
		
		//************************************************************************************//
		//***************************Enters POINT/TRACK Indicator Value************************************//
		//************************************************************************************//
		
		public void Indval()
		{
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
	       	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == Ind )
           		{
            	item.Select();
            	item.Click();
               	break;        
           		}           		
        	}
		}	
        
		//************************************************************************************//
		//********************Gets Identity value from csv file*******************************//
		//************************************************************************************//
		
		public void IDval()
		{
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
	       	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == ID )
           		{
            	item.Select();
            	item.Click();
               	break;        
           		}           		
        	}
		}
		//************************************************************************************//
		//********************Gets Platform value from csv file*******************************//
		//************************************************************************************//
		
		public void Platval()
	{
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
	       	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == Plat )
           		{
            	item.Select();
            	item.Click();
               	break;        
           		}           		
        	}
		}

		//************************************************************************************//
		//********************Gets Activity value from csv file*******************************//
		//************************************************************************************//
		
		public void Actval()
	{
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
	       	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == Act )
           		{
            	item.Select();
            	item.Click();
               	break;        
           		}           		
        	}
		}

		//************************************************************************************//
		//********************Gets Specific Type value from csv file**************************//
		//************************************************************************************//
		
		public void Stypeval()
	{
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
	       	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == Stype )
           		{
            	item.Select();
            	item.Click();
               	break;        
           		}           		
        	}
		}
		//************************************************************************************//
		//********************Validates the created track is dropped**************************//
		//************************************************************************************//
		
		public void ValidateDropTrack()
		{
		Delay.Milliseconds(1500, false);
		if (repo.FormTacViewC2.PictureTrackCreateDropInfo.Exists())
			{
				TacViewLib.LinkSpecific.Surveillance.Drop_Track.DropTrack.Start();
			}
		}

		static CreateResetNoStatementTOAD1()
		{
			//Your recording specific initialization code goes here.
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}
