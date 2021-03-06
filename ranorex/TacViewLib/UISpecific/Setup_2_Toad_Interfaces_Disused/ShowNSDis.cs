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

namespace TacViewLib.UISpecific.Setup_2_Toad_Interfaces_Disused
{
    /// <summary>
    /// The ShowNSDis recording.
    /// </summary>
    [TestModule("2591db78-23b2-4dc3-b538-acfa75ac68a1", ModuleType.Recording, 1)]
    public partial class ShowNSDis : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewLibRepositoryDisusedValues repository.
        /// </summary>
        public static TacViewLib.TacViewLibRepositoryDisusedValues repo = TacViewLib.TacViewLibRepositoryDisusedValues.Instance;

        static ShowNSDis instance = new ShowNSDis();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ShowNSDis()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ShowNSDis Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.File' at Center.", repo.FormTacViewC2.FileInfo, new RecordItemIndex(0));
            repo.FormTacViewC2.File.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormIdle.MenuItemPreferences' at Center.", repo.FormIdle.MenuItemPreferencesInfo, new RecordItemIndex(1));
            repo.FormIdle.MenuItemPreferences.Click(150);
            Delay.Milliseconds(100);
            
            Validate_NS_Is_Enabled();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormPreferences.ButtonClose' at Center.", repo.FormPreferences.ButtonCloseInfo, new RecordItemIndex(3));
            repo.FormPreferences.ButtonClose.Click(150);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
}
