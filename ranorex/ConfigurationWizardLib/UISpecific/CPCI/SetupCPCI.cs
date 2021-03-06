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

namespace ConfigurationWizardLib.UISpecific.CPCI
{
    /// <summary>
    /// The SetupCPCI recording.
    /// </summary>
    [TestModule("2cef3cf4-de46-457c-9dd3-d5dce2e12fc6", ModuleType.Recording, 1)]
    public partial class SetupCPCI : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ConfigurationWizardLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static ConfigurationWizardLib.Link_16_RegressionRepository repo = ConfigurationWizardLib.Link_16_RegressionRepository.Instance;

        static SetupCPCI instance = new SetupCPCI();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetupCPCI()
        {
            LinuxIP = "999.999.999.999";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetupCPCI Instance
        {
            get { return instance; }
        }

#region Variables

        string _LinuxIP;

        /// <summary>
        /// Gets or sets the value of variable LinuxIP.
        /// </summary>
        [TestVariable("e68bf8a9-e71a-42ab-b9a2-39669d3599e2")]
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

            KillUltraProcesses();
            Delay.Milliseconds(250);
            
            CopyConfigFiles();
            Delay.Milliseconds(250);
            
            GetWinIP();
            Delay.Milliseconds(0);
            
            CfgWizState();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSelect_Configuration_Fil.ListItemCPCI_SUT_xml' at CenterLeft.", repo.FormSelect_Configuration_Fil.ListItemCPCI_SUT_xmlInfo, new RecordItemIndex(4));
            repo.FormSelect_Configuration_Fil.ListItemCPCI_SUT_xml.Click(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSelect_Configuration_Fil.ButtonOpen' at Center.", repo.FormSelect_Configuration_Fil.ButtonOpenInfo, new RecordItemIndex(5));
            repo.FormSelect_Configuration_Fil.ButtonOpen.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfiguration_Wizard.ButtonNext' at Center.", repo.FormConfiguration_Wizard.ButtonNextInfo, new RecordItemIndex(6));
            repo.FormConfiguration_Wizard.ButtonNext.Click(150);
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfiguration_Wizard.RadioButtonIPv4' at Center.", repo.FormConfiguration_Wizard.RadioButtonIPv4Info, new RecordItemIndex(7));
            repo.FormConfiguration_Wizard.RadioButtonIPv4.Click(150);
            Delay.Milliseconds(720);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(8));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, 15, Keyboard.DefaultKeyPressTime, 1, false);
            Delay.Milliseconds(990);
            
            EnterWinIP();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfiguration_Wizard.ButtonNext' at Center.", repo.FormConfiguration_Wizard.ButtonNextInfo, new RecordItemIndex(10));
            repo.FormConfiguration_Wizard.ButtonNext.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'FormConfiguration_Wizard.RadioButtonIPv4' at Center.", repo.FormConfiguration_Wizard.RadioButtonIPv4Info, new RecordItemIndex(11));
            repo.FormConfiguration_Wizard.RadioButtonIPv4.MoveTo(150);
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(720);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(12));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, 15, Keyboard.DefaultKeyPressTime, 1, false);
            Delay.Milliseconds(990);
            
            EnterLinuxIP();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfiguration_Wizard.ButtonNext' at Center.", repo.FormConfiguration_Wizard.ButtonNextInfo, new RecordItemIndex(14));
            repo.FormConfiguration_Wizard.ButtonNext.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfiguration_Wizard.ButtonNext' at Center.", repo.FormConfiguration_Wizard.ButtonNextInfo, new RecordItemIndex(15));
            repo.FormConfiguration_Wizard.ButtonNext.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfiguration_Wizard.ButtonStart_Hardware_Check' at Center.", repo.FormConfiguration_Wizard.ButtonStart_Hardware_CheckInfo, new RecordItemIndex(16));
            repo.FormConfiguration_Wizard.ButtonStart_Hardware_Check.Click(100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FormConfiguration_Wizard.TextEthernet'.", repo.FormConfiguration_Wizard.TextEthernetInfo, new RecordItemIndex(17));
            Validate.Exists(repo.FormConfiguration_Wizard.TextEthernetInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfiguration_Wizard.ButtonNext' at Center.", repo.FormConfiguration_Wizard.ButtonNextInfo, new RecordItemIndex(18));
            repo.FormConfiguration_Wizard.ButtonNext.Click(150);
            Delay.Milliseconds(990);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfiguration_Wizard.ButtonFinish' at Center.", repo.FormConfiguration_Wizard.ButtonFinishInfo, new RecordItemIndex(19));
            repo.FormConfiguration_Wizard.ButtonFinish.Click(150);
            Delay.Milliseconds(100);
            
            CloseExist();
            Delay.Milliseconds(0);
            
            MaximizeExist();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConfiguration_Wizard.ButtonAccept_Configuration' at Center.", repo.FormConfiguration_Wizard.ButtonAccept_ConfigurationInfo, new RecordItemIndex(22));
            repo.FormConfiguration_Wizard.ButtonAccept_Configuration.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Configuration File Distribution Finished.') on item 'FormAccept_Configuration.TextConfiguration_File_Distr'.", repo.FormAccept_Configuration.TextConfiguration_File_DistrInfo, new RecordItemIndex(23));
            Validate.Attribute(repo.FormAccept_Configuration.TextConfiguration_File_DistrInfo, "Text", "Configuration File Distribution Finished.");
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormAccept_Configuration.ButtonOk' at Center.", repo.FormAccept_Configuration.ButtonOkInfo, new RecordItemIndex(24));
            repo.FormAccept_Configuration.ButtonOk.Click(150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Qkey}{LControlKey up}'.", new RecordItemIndex(25));
            Keyboard.Press("{LControlKey down}{Qkey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormUnsaved_Changes.ButtonNo' at Center.", repo.FormUnsaved_Changes.ButtonNoInfo, new RecordItemIndex(26));
            repo.FormUnsaved_Changes.ButtonNo.Click(150);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
}
