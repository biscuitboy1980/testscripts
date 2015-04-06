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

namespace SystemManagerLib.UISpecific.SetupSFF
{
    /// <summary>
    /// The SetupSFF recording.
    /// </summary>
    [TestModule("cc37c95c-6dca-4d25-ad10-9d7f5e9661c2", ModuleType.Recording, 1)]
    public partial class SetupSFF : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SystemManagerLib.Link_16_Regression repository.
        /// </summary>
        public static SystemManagerLib.Link_16_Regression repo = SystemManagerLib.Link_16_Regression.Instance;

        static SetupSFF instance = new SetupSFF();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetupSFF()
        {
            LinuxUser = "sff";
            LinuxPass = "password";
            LinuxIP = "999.999.999.999";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetupSFF Instance
        {
            get { return instance; }
        }

#region Variables

        string _LinuxUser;

        /// <summary>
        /// Gets or sets the value of variable LinuxUser.
        /// </summary>
        [TestVariable("73a73353-45f5-4c2c-8573-21db3a26efcf")]
        public string LinuxUser
        {
            get { return _LinuxUser; }
            set { _LinuxUser = value; }
        }

        string _LinuxPass;

        /// <summary>
        /// Gets or sets the value of variable LinuxPass.
        /// </summary>
        [TestVariable("7d732996-6022-47da-947b-c1d36ecf3825")]
        public string LinuxPass
        {
            get { return _LinuxPass; }
            set { _LinuxPass = value; }
        }

        string _LinuxIP;

        /// <summary>
        /// Gets or sets the value of variable LinuxIP.
        /// </summary>
        [TestVariable("b3f5ee2f-6fa6-42b0-8978-d7dab4cc4a2e")]
        public string LinuxIP
        {
            get { return _LinuxIP; }
            set { _LinuxIP = value; }
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

            LoadSite1();
            Delay.Milliseconds(250);
            
            CopySiteFiles();
            Delay.Milliseconds(250);
            
            RemoveAutostart();
            Delay.Milliseconds(0);
            
            LaunchSM();
            Delay.Milliseconds(250);
            
            GetFocusSM();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS' at Center.", repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASSInfo, new RecordItemIndex(5));
            repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS.Click(300);
            Delay.Milliseconds(200);
            
            DataLinkStatus();
            Delay.Milliseconds(250);
            
            ApplicationStatus();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3000ms.", new RecordItemIndex(8));
            Delay.Duration(3000, false);
            
            LoadSite1();
            Delay.Milliseconds(0);
            
            Validate_C2H_Connected();
            Delay.Milliseconds(100);
            
            LoadSite1();
            Delay.Milliseconds(0);
            
            StartStopRestartLinux();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3000ms.", new RecordItemIndex(13));
            Delay.Duration(3000, false);
            
            LoadSite1();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS' at CenterLeft.", repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASSInfo, new RecordItemIndex(15));
            repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS.Click(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FormSystem_Manager___UNCLASS.Cell3011C'.", repo.FormSystem_Manager___UNCLASS.Cell3011CInfo, new RecordItemIndex(16));
            Validate.Exists(repo.FormSystem_Manager___UNCLASS.Cell3011CInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TabPageForwarding' at Center.", repo.FormSystem_Manager___UNCLASS.TabPageForwardingInfo, new RecordItemIndex(17));
            repo.FormSystem_Manager___UNCLASS.TabPageForwarding.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.ListItem__Data_Link_Forwarding' at Center.", repo.FormSystem_Manager___UNCLASS.ListItem__Data_Link_ForwardingInfo, new RecordItemIndex(18));
            repo.FormSystem_Manager___UNCLASS.ListItem__Data_Link_Forwarding.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextEnable_All' at Center.", repo.FormSystem_Manager___UNCLASS.TextEnable_AllInfo, new RecordItemIndex(19));
            repo.FormSystem_Manager___UNCLASS.TextEnable_All.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.ButtonApply' at Center.", repo.FormSystem_Manager___UNCLASS.ButtonApplyInfo, new RecordItemIndex(20));
            repo.FormSystem_Manager___UNCLASS.ButtonApply.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.ListItem__C2_Host_Forwarding' at Center.", repo.FormSystem_Manager___UNCLASS.ListItem__C2_Host_ForwardingInfo, new RecordItemIndex(21));
            repo.FormSystem_Manager___UNCLASS.ListItem__C2_Host_Forwarding.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextEnable_All' at Center.", repo.FormSystem_Manager___UNCLASS.TextEnable_AllInfo, new RecordItemIndex(22));
            repo.FormSystem_Manager___UNCLASS.TextEnable_All.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.ButtonApply' at Center.", repo.FormSystem_Manager___UNCLASS.ButtonApplyInfo, new RecordItemIndex(23));
            repo.FormSystem_Manager___UNCLASS.ButtonApply.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TabPageSystem_Status' at Center.", repo.FormSystem_Manager___UNCLASS.TabPageSystem_StatusInfo, new RecordItemIndex(24));
            repo.FormSystem_Manager___UNCLASS.TabPageSystem_Status.Click(150);
            Delay.Milliseconds(100);
            
            ToggleLink();
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
}