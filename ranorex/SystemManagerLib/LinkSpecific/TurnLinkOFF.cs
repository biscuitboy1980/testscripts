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

namespace SystemManagerLib.LinkSpecific
{
    /// <summary>
    /// The TurnLinkOFF recording.
    /// </summary>
    [TestModule("50c7b2e5-623f-4f9b-89fd-803d3997c3ec", ModuleType.Recording, 1)]
    public partial class TurnLinkOFF : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SystemManagerLib.V15SmokeTestRepository repository.
        /// </summary>
        public static SystemManagerLib.V15SmokeTestRepository repo = SystemManagerLib.V15SmokeTestRepository.Instance;

        static TurnLinkOFF instance = new TurnLinkOFF();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TurnLinkOFF()
        {
            currentLinkNum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TurnLinkOFF Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable currentLinkNum.
        /// </summary>
        [TestVariable("bf08113f-779e-4a03-80ed-6e6124c47330")]
        public string currentLinkNum
        {
            get { return repo.currentLinkNum; }
            set { repo.currentLinkNum = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS' at CenterLeft.", repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASSInfo, new RecordItemIndex(0));
            repo.FormSystem_Manager___UNCLASS.TitleBarSystem_Manager___UNCLASS.Click(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            TurnOFFLink();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}