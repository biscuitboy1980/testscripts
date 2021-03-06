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

namespace TacViewLib.Defects.D03968
{
    /// <summary>
    /// The D03968Validate recording.
    /// </summary>
    [TestModule("54d55688-63c2-4b80-b952-0d35df487985", ModuleType.Recording, 1)]
    public partial class D03968Validate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewSustainment_DefectsRepository repository.
        /// </summary>
        public static TacViewLib.TacViewSustainment_DefectsRepository repo = TacViewLib.TacViewSustainment_DefectsRepository.Instance;

        static D03968Validate instance = new D03968Validate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public D03968Validate()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static D03968Validate Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5000ms.", new RecordItemIndex(0));
            Delay.Duration(5000, false);
            
            CreateTrackRepoItems();
            Delay.Milliseconds(0);
            
            RightClickTrack();
            Delay.Milliseconds(0);
            
            ViewTrackProperties();
            Delay.Milliseconds(0);
            
            ValidatePtype();
            Delay.Milliseconds(0);
            
            ValidateAmp();
            Delay.Milliseconds(0);
            
            ValidateSono();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2500ms.", new RecordItemIndex(7));
            Delay.Duration(2500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Reference_Point_TNProp.ButtonCLOSE' at Center.", repo.FormMain__Reference_Point_TNProp.ButtonCLOSEInfo, new RecordItemIndex(8));
            repo.FormMain__Reference_Point_TNProp.ButtonCLOSE.Click(300);
            Delay.Milliseconds(200);
            
            RightClickTrack();
            Delay.Milliseconds(0);
            
            DropTrack();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2000ms.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
            Validate_DropTrack();
            Delay.Milliseconds(0);
            
            ResetPaths();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
