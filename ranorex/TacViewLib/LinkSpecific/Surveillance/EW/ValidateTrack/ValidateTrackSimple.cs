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

namespace TacViewLib.LinkSpecific.Surveillance.EW.ValidateTrack
{
    /// <summary>
    /// The ValidateTrackSimple recording.
    /// </summary>
    [TestModule("07e51a85-e222-4fd8-8318-b51d826ef827", ModuleType.Recording, 1)]
    public partial class ValidateTrackRegression : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static ValidateTrackRegression instance = new ValidateTrackRegression();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateTrackRegression()
        {
            tracknumber = "";
            Connection1 = "";
            Connection2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateTrackRegression Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable tracknumber.
        /// </summary>
        [TestVariable("ce09b6ce-74d5-4bbb-a6f8-81675fa10bb7")]
        public string tracknumber
        {
            get { return repo.tracknumber; }
            set { repo.tracknumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection1.
        /// </summary>
        [TestVariable("b04ae712-5f15-403e-87ad-a9676a8d3957")]
        public string Connection1
        {
            get { return repo.connection1; }
            set { repo.connection1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection2.
        /// </summary>
        [TestVariable("530fddf4-d1d9-4b87-8d8b-2d64afa89078")]
        public string Connection2
        {
            get { return repo.connection2; }
            set { repo.connection2 = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2000ms.", new RecordItemIndex(0));
            Delay.Duration(2000, false);
            
            SetTrackNumberInRepo();
            Delay.Milliseconds(0);
            
            RightClickTrack();
            Delay.Milliseconds(0);
            
            ViewTrackProperties();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2000ms.", new RecordItemIndex(4));
            Delay.Duration(2000, false);
            
            ValidateFoB();
            Delay.Milliseconds(0);
            
            ValidateId();
            Delay.Milliseconds(0);
            
            ValidateEnvCat();
            Delay.Milliseconds(0);
            
            ValidatePlat();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__EW_TN.ButtonCLOSE' at Center.", repo.FormMain__EW_TN.ButtonCLOSEInfo, new RecordItemIndex(9));
            repo.FormMain__EW_TN.ButtonCLOSE.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FormTacViewC2.PictureTrack' at Center.", repo.FormTacViewC2.PictureTrackInfo, new RecordItemIndex(10));
            repo.FormTacViewC2.PictureTrack.Click(System.Windows.Forms.MouseButtons.Right, 300);
            Delay.Milliseconds(0);
            
            DropTrack();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(12));
            Delay.Duration(10000, false);
            
            Validate_DropTrack();
            Delay.Milliseconds(0);
            
            Zoom500();
            Delay.Milliseconds(0);
            
            ResetPaths();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}