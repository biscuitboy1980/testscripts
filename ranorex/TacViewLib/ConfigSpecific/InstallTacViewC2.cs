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

namespace TacViewLib.ConfigSpecific
{
    /// <summary>
    /// The InstallTacViewC2 recording.
    /// </summary>
    [TestModule("71a2b1ee-bd2f-4350-9ff6-e62d88c504a3", ModuleType.Recording, 1)]
    public partial class InstallTacViewC2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewLibRepository repository.
        /// </summary>
        public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

        static InstallTacViewC2 instance = new InstallTacViewC2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InstallTacViewC2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InstallTacViewC2 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2_Install.C2_ButtonNext' at Center.", repo.FormTacViewC2_Install.C2_ButtonNextInfo, new RecordItemIndex(0));
            repo.FormTacViewC2_Install.C2_ButtonNext.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2_Install.C2_ButtonNext' at Center.", repo.FormTacViewC2_Install.C2_ButtonNextInfo, new RecordItemIndex(1));
            repo.FormTacViewC2_Install.C2_ButtonNext.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2_Install.C2_ButtonNext' at Center.", repo.FormTacViewC2_Install.C2_ButtonNextInfo, new RecordItemIndex(2));
            repo.FormTacViewC2_Install.C2_ButtonNext.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2_Install.C2_ButtonInstall' at Center.", repo.FormTacViewC2_Install.C2_ButtonInstallInfo, new RecordItemIndex(3));
            repo.FormTacViewC2_Install.C2_ButtonInstall.Click(220);
            Delay.Milliseconds(280);
            
            WaitWhileInstallingC2();
            Delay.Milliseconds(120);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2_Install.CheckBox681' at Center.", repo.FormTacViewC2_Install.CheckBox681Info, new RecordItemIndex(5));
            repo.FormTacViewC2_Install.CheckBox681.Click(125);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2_Install.CheckBox709' at Center.", repo.FormTacViewC2_Install.CheckBox709Info, new RecordItemIndex(6));
            repo.FormTacViewC2_Install.CheckBox709.Click(125);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2_Install.C2_ButtonFinish' at Center.", repo.FormTacViewC2_Install.C2_ButtonFinishInfo, new RecordItemIndex(7));
            repo.FormTacViewC2_Install.C2_ButtonFinish.Click(125);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
