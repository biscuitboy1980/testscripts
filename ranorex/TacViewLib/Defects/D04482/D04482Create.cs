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

namespace TacViewLib.Defects.D04482
{
    /// <summary>
    /// The D04482Create recording.
    /// </summary>
    [TestModule("bd20819a-6db9-44ee-bcbb-887752692696", ModuleType.Recording, 1)]
    public partial class D04482Create : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewSustainment_DefectsRepository repository.
        /// </summary>
        public static TacViewLib.TacViewSustainment_DefectsRepository repo = TacViewLib.TacViewSustainment_DefectsRepository.Instance;

        static D04482Create instance = new D04482Create();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public D04482Create()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static D04482Create Instance
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

            GetListValues();
            Delay.Milliseconds(0);
            
            GetTrackCount();
            Delay.Milliseconds(0);
            
            RandCoord();
            Delay.Milliseconds(0);
            
            TrackTypeval();
            Delay.Milliseconds(0);
            
            Strengthval();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain.ButtonSave' at Center.", repo.FormMain.ButtonSaveInfo, new RecordItemIndex(5));
            repo.FormMain.ButtonSave.Click(300);
            Delay.Milliseconds(200);
            
            GetTrackNum();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
