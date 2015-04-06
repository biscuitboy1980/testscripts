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

namespace SystemManagerLib.TabSpecific.SystemStatusTab
{
    /// <summary>
    /// The HostLink recording.
    /// </summary>
    [TestModule("fe177a8f-67a6-460c-8b91-a8724e969c62", ModuleType.Recording, 1)]
    public partial class HostLink : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SystemManagerLib.SytemMangerRegression repository.
        /// </summary>
        public static SystemManagerLib.SytemMangerRegression repo = SystemManagerLib.SytemMangerRegression.Instance;

        static HostLink instance = new HostLink();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public HostLink()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static HostLink Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FormSystem_Manager___UNCLASS.ContainerHost_Link'.", repo.FormSystem_Manager___UNCLASS.ContainerHost_LinkInfo, new RecordItemIndex(0));
            Validate.Exists(repo.FormSystem_Manager___UNCLASS.ContainerHost_LinkInfo);
            Delay.Milliseconds(0);
            
            HostLinkOPER();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
