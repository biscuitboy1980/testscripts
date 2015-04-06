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
using Microsoft.Win32;
using System.Diagnostics;
using Microsoft.VisualBasic;

using Ranorex;
using Ranorex.Core;

namespace TacViewLib.UISpecific.Setup_2_Toad_Interfaces_Disused
{
	/// <summary>
	/// The Setup recording.
	/// </summary>
	public partial class SetupDisusedv15		
	{
		public static string ip2csv = "999.999.999.999";
		public static string ipval2;
		
		//**************************************************************************************//
		//************************Checks for Existing Registry Key Before Deleting It***********//
		//**************************************************************************************//
		
		public static void RegClear()
		{	
			string regKey="Software\\Ultra Electronics Inc\\TacViewC2";
			using (RegistryKey key = Registry.CurrentUser.OpenSubKey(regKey, true))
			{
			if (key != null)
			{
				//MessageBox.Show("Deleting TacView Registry SubKey", "SubKey Deletion");
				Registry.CurrentUser.DeleteSubKeyTree(regKey);
			}
			}

		}
		
		//**************************************************************************************//
		//************************Selects no Open GL if the prompt appears**********************//
		//**************************************************************************************//
		
		public static void GLButtonOK()
		{
			Report.Info("Validating Exists on item 'FormSelect_Configuration.ButtonOK1'.");
			
			if (repo.FormSelect_Configuration.ButtonOK1Info.Exists())
			{
				repo.FormSelect_Configuration.ButtonOK1.Click("37;11");
			}
		}
	
		//**************************************************************************************//
		//******Opens pacific map if available, if not closes the map selection dialogue********//
		//**************************************************************************************//
		
		public static void MapDialogue()
			
		{
			Report.Info("Validating Exists on item 'FormOpen.ListItemPacificWorldMap'.");
			    
			if (repo.FormOpen.ButtonOpen1Info.Exists())

			{
				if (repo.FormOpen.ListItemMapInfo.Exists())					
				{
					repo.FormOpen.ListItemMap.DoubleClick("center");
				}
			
				else
				{
					repo.FormOpen.ButtonCancel.Click("center");
				}
			}
				
		}

		//**************************************************************************************//
		//*************************Populates TOAD 1 Delta interface*****************************//
		//**************************************************************************************//
		
		public static void TOAD1ip()
		{
			if (ip2csv == "999.999.999.999")
			{	
				Report.Info("Key sequence 'ipval1'.");
				Keyboard.Press(ipval2);	
			}
			else
			{	
				Report.Info("Key sequence 'ip1csv'.");
				Keyboard.Press(ip2csv);
			}
		
		}
		
        //**************************************************************************************//
		//**********************Validates TOAD1 Delta interface goes OPER***********************//
		//**************************************************************************************//
		
		public static void ValTOAD1()
		{
			Report.Info("Validating TOAD1 Connection");
			if (repo.FormTacViewC2____map__Pacifi1.TableCCustomReportControl2.CellConnected_0_.Text=="NO")
			{
				MessageBox.Show("Not Conected to TOAD1 Interface - Terminating Program", "TOAD1 Interface Error");
				Environment.Exit(-1);
			}
			
		}

		static SetupDisusedv15()
		{
			//Your recording specific initialization code goes here.
		}

}
}