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
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace SystemManagerLib.LinkSpecific.TNAccountability
{
    /// <summary>
    /// The TNBLKRollover recording.
    /// </summary>
    [TestModule("61f4a35e-84f0-4e0c-b178-5e745c3d9416", ModuleType.Recording, 1)]
    public partial class TNBLKRollover : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SystemManagerLib.Link_16_Regression repository.
        /// </summary>
        public static SystemManagerLib.Link_16_Regression repo = SystemManagerLib.Link_16_Regression.Instance;

        static TNBLKRollover instance = new TNBLKRollover();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TNBLKRollover()
        {
            Available_Tracks = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TNBLKRollover Instance
        {
            get { return instance; }
        }

#region Variables

        string _Available_Tracks;

        /// <summary>
        /// Gets or sets the value of variable Available_Tracks.
        /// </summary>
        [TestVariable("d3d995ca-6831-40a6-95f1-0f9f7d9518c1")]
        public string Available_Tracks
        {
            get { return _Available_Tracks; }
            set { _Available_Tracks = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.1.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.1.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 250;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS' at Center.", repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASSInfo, new RecordItemIndex(0));
            repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS.Click(100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.MenuItemTools' at Center.", repo.FormSystem_Manager___UNCLASS.MenuItemToolsInfo, new RecordItemIndex(1));
            repo.FormSystem_Manager___UNCLASS.MenuItemTools.Click(150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSm.MenuItemClear_Data' at Center.", repo.FormSm.MenuItemClear_DataInfo, new RecordItemIndex(2));
            repo.FormSm.MenuItemClear_Data.Click(150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormReally_clear_C2_Host_dat.ButtonYes' at Center.", repo.FormReally_clear_C2_Host_dat.ButtonYesInfo, new RecordItemIndex(3));
            repo.FormReally_clear_C2_Host_dat.ButtonYes.Click(150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormClear_Data_Succeeded.ButtonOK' at Center.", repo.FormClear_Data_Succeeded.ButtonOKInfo, new RecordItemIndex(4));
            repo.FormClear_Data_Succeeded.ButtonOK.Click(150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TabPageSite_Data' at Center.", repo.FormSystem_Manager___UNCLASS.TabPageSite_DataInfo, new RecordItemIndex(5));
            repo.FormSystem_Manager___UNCLASS.TabPageSite_Data.Click(150);
            Delay.Milliseconds(0);
            
            GetOwnUnit();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.ListItem__Track_Number_Blocks' at CenterLeft.", repo.FormSystem_Manager___UNCLASS.ListItem__Track_Number_BlocksInfo, new RecordItemIndex(7));
            repo.FormSystem_Manager___UNCLASS.ListItem__Track_Number_Blocks.Click(Location.CenterLeft, 150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextTrack_Block_1' at CenterLeft.", repo.FormSystem_Manager___UNCLASS.TextTrack_Block_1Info, new RecordItemIndex(8));
            repo.FormSystem_Manager___UNCLASS.TextTrack_Block_1.Click(Location.CenterLeft, 150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(9));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(50);
            
            EnterLowTNBLK1();
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(11));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(50);
            
            EnterHighTNBLK1();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(13));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(50);
            
            EnterLowTNBLK2();
            Delay.Milliseconds(150);
            
            EnterHighTNBLK2();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.ButtonApplyAll' at Center.", repo.FormSystem_Manager___UNCLASS.ButtonApplyAllInfo, new RecordItemIndex(16));
            repo.FormSystem_Manager___UNCLASS.ButtonApplyAll.Click(150);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}