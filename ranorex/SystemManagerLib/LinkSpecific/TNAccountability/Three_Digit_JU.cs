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
    /// The Three_Digit_JU recording.
    /// </summary>
    [TestModule("466d144c-05fc-4ceb-ac4a-d278fdb7909e", ModuleType.Recording, 5)]
    public partial class Three_Digit_JU : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SystemManagerLib.Link_16_Regression repository.
        /// </summary>
        public static SystemManagerLib.Link_16_Regression repo = SystemManagerLib.Link_16_Regression.Instance;

        static Three_Digit_JU instance = new Three_Digit_JU();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Three_Digit_JU()
        {
            UnitNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Three_Digit_JU Instance
        {
            get { return instance; }
        }

#region Variables

        string _UnitNum;

        /// <summary>
        /// Gets or sets the value of variable UnitNum.
        /// </summary>
        [TestVariable("64a562c9-9737-4980-92a6-34d54fb205de")]
        public string UnitNum
        {
            get { return _UnitNum; }
            set { _UnitNum = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TabPageSite_Data' at Center.", repo.FormSystem_Manager___UNCLASS.TabPageSite_DataInfo, new RecordItemIndex(0));
            repo.FormSystem_Manager___UNCLASS.TabPageSite_Data.Click(150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.ListItem__Unit_Numbers' at Center.", repo.FormSystem_Manager___UNCLASS.ListItem__Unit_NumbersInfo, new RecordItemIndex(1));
            repo.FormSystem_Manager___UNCLASS.ListItem__Unit_Numbers.Click(150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TextLink16_11' at Center.", repo.FormSystem_Manager___UNCLASS.TextLink16_11Info, new RecordItemIndex(2));
            repo.FormSystem_Manager___UNCLASS.TextLink16_11.Click(150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, 15, Keyboard.DefaultKeyPressTime, 1, false);
            Delay.Milliseconds(50);
            
            UnitNumber();
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.ButtonApply' at Center.", repo.FormSystem_Manager___UNCLASS.ButtonApplyInfo, new RecordItemIndex(5));
            repo.FormSystem_Manager___UNCLASS.ButtonApply.Click(150);
            Delay.Milliseconds(0);
            
            Validate_TextUnit1();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
