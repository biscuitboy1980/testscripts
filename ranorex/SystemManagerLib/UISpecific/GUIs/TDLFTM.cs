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

namespace SystemManagerLib.UISpecific.GUIs
{
    /// <summary>
    /// The TDLFTM recording.
    /// </summary>
    [TestModule("13c1f9fb-74d7-45b0-ac47-9adc1670aa79", ModuleType.Recording, 1)]
    public partial class TDLFTM : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SystemManagerLib.V15SmokeTestRepository repository.
        /// </summary>
        public static SystemManagerLib.V15SmokeTestRepository repo = SystemManagerLib.V15SmokeTestRepository.Instance;

        static TDLFTM instance = new TDLFTM();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TDLFTM()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TDLFTM Instance
        {
            get { return instance; }
        }

#region Variables

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
            repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+LMenu' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.LMenu | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'T' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.T, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSm.MenuItemTDL_FTM' at 86;9.", repo.FormSm.MenuItemTDL_FTMInfo, new RecordItemIndex(3));
            repo.FormSm.MenuItemTDL_FTM.Click("86;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FormTDL_FTM_Client.TitleBarTDL_FTM_Client1'.", repo.FormTDL_FTM_Client.TitleBarTDL_FTM_Client1Info, new RecordItemIndex(4));
            Validate.Exists(repo.FormTDL_FTM_Client.TitleBarTDL_FTM_Client1Info);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}