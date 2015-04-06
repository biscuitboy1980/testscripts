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

namespace SystemManagerLib.UISpecific
{
    /// <summary>
    /// The SiteData recording.
    /// </summary>
    [TestModule("28aa3538-b09a-4ff2-8848-6c8a184ae563", ModuleType.Recording, 1)]
    public partial class SiteData : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SystemManagerLib.V15SmokeTestRepository repository.
        /// </summary>
        public static SystemManagerLib.V15SmokeTestRepository repo = SystemManagerLib.V15SmokeTestRepository.Instance;

        static SiteData instance = new SiteData();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SiteData()
        {
            siteFileName1 = "Site1.site";
            siteFileName2 = "Site2.site";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SiteData Instance
        {
            get { return instance; }
        }

#region Variables

        string _siteFileName1;

        /// <summary>
        /// Gets or sets the value of variable siteFileName1.
        /// </summary>
        [TestVariable("121abda0-d1c8-4dac-98b7-3211fcc5243b")]
        public string siteFileName1
        {
            get { return _siteFileName1; }
            set { _siteFileName1 = value; }
        }

        string _siteFileName2;

        /// <summary>
        /// Gets or sets the value of variable siteFileName2.
        /// </summary>
        [TestVariable("6b5c917d-6d8d-4118-840f-ca9e61b20df8")]
        public string siteFileName2
        {
            get { return _siteFileName2; }
            set { _siteFileName2 = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5000ms.", new RecordItemIndex(0));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS' at Center.", repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASSInfo, new RecordItemIndex(1));
            repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS.Click(300);
            Delay.Milliseconds(1780);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TabPageSite_Data' at Center.", repo.FormSystem_Manager___UNCLASS.TabPageSite_DataInfo, new RecordItemIndex(2));
            repo.FormSystem_Manager___UNCLASS.TabPageSite_Data.Click(300);
            Delay.Milliseconds(840);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.ButtonLoad_Site' at Center.", repo.FormSystem_Manager___UNCLASS.ButtonLoad_SiteInfo, new RecordItemIndex(3));
            repo.FormSystem_Manager___UNCLASS.ButtonLoad_Site.Click();
            Delay.Milliseconds(910);
            
            SiteFileWarning();
            Delay.Milliseconds(1150);
            
            LoadSite();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSite_to_Load.ButtonOpen' at Center.", repo.FormSite_to_Load.ButtonOpenInfo, new RecordItemIndex(6));
            repo.FormSite_to_Load.ButtonOpen.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(7));
            Delay.Duration(10000, false);
            
        }

#region Image Feature Data
#endregion
    }
}