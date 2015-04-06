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

namespace SystemManagerLib.DLR
{
    /// <summary>
    /// The DLR_NTDS recording.
    /// </summary>
    [TestModule("94d38151-ab53-4fe5-96e7-ca0ff4d0165b", ModuleType.Recording, 1)]
    public partial class DLR_NTDS : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SystemManagerLib.V15SmokeTestRepository repository.
        /// </summary>
        public static SystemManagerLib.V15SmokeTestRepository repo = SystemManagerLib.V15SmokeTestRepository.Instance;

        static DLR_NTDS instance = new DLR_NTDS();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DLR_NTDS()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DLR_NTDS Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TabPageSystem_Configuration' at Center.", repo.FormSystem_Manager___UNCLASS.TabPageSystem_ConfigurationInfo, new RecordItemIndex(0));
            repo.FormSystem_Manager___UNCLASS.TabPageSystem_Configuration.Click(300);
            Delay.Milliseconds(700);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.ButtonAdd_Link' at Center.", repo.FormSystem_Manager___UNCLASS.ButtonAdd_LinkInfo, new RecordItemIndex(1));
            repo.FormSystem_Manager___UNCLASS.ButtonAdd_Link.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(2));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfigure_Link.PictureGraphic' at Center.", repo.FormConfigure_Link.PictureGraphicInfo, new RecordItemIndex(3));
            repo.FormConfigure_Link.PictureGraphic.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfigure_Link.ButtonNext_' at Center.", repo.FormConfigure_Link.ButtonNext_Info, new RecordItemIndex(4));
            repo.FormConfigure_Link.ButtonNext_.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormConfigure_Link.TextADSI' at Center.", repo.FormConfigure_Link.TextADSIInfo, new RecordItemIndex(5));
            repo.FormConfigure_Link.TextADSI.DoubleClick(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{RShiftKey down}NTDS{RShiftKey up}'.", new RecordItemIndex(6));
            Keyboard.Press("{RShiftKey down}NTDS{RShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfigure_Link.ButtonNext_' at Center.", repo.FormConfigure_Link.ButtonNext_Info, new RecordItemIndex(7));
            repo.FormConfigure_Link.ButtonNext_.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfigure_Link.RadioButtonOther' at CenterLeft.", repo.FormConfigure_Link.RadioButtonOtherInfo, new RecordItemIndex(8));
            repo.FormConfigure_Link.RadioButtonOther.Click(Location.CenterLeft, 300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfigure_Link.TextSelect' at Center.", repo.FormConfigure_Link.TextSelectInfo, new RecordItemIndex(9));
            repo.FormConfigure_Link.TextSelect.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next}{Next}'.", new RecordItemIndex(10));
            Keyboard.Press("{Next}{Next}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSm.ListItemLink_11___NTDS' at Center.", repo.FormSm.ListItemLink_11___NTDSInfo, new RecordItemIndex(11));
            repo.FormSm.ListItemLink_11___NTDS.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfigure_Link.ButtonNext_' at Center.", repo.FormConfigure_Link.ButtonNext_Info, new RecordItemIndex(12));
            repo.FormConfigure_Link.ButtonNext_.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfigure_Link.ButtonNext_2' at Center.", repo.FormConfigure_Link.ButtonNext_2Info, new RecordItemIndex(13));
            repo.FormConfigure_Link.ButtonNext_2.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfigure_Link.ButtonNext_2' at Center.", repo.FormConfigure_Link.ButtonNext_2Info, new RecordItemIndex(14));
            repo.FormConfigure_Link.ButtonNext_2.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfigure_Link.ButtonFinish' at Center.", repo.FormConfigure_Link.ButtonFinishInfo, new RecordItemIndex(15));
            repo.FormConfigure_Link.ButtonFinish.Click(300);
            Delay.Milliseconds(200);
            
            Link11PopUp();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
