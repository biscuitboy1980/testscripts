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

namespace TacViewLib.LinkSpecific.Surveillance.Surface.ValidateTrack
{
    /// <summary>
    /// The ValidateSurfaceTrackL16_L11 recording.
    /// </summary>
    [TestModule("217b26d6-964e-44cd-8905-9b5ba376e25c", ModuleType.Recording, 1)]
    public partial class ValidateSurfaceTrackL16_L11 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static ValidateSurfaceTrackL16_L11 instance = new ValidateSurfaceTrackL16_L11();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateSurfaceTrackL16_L11()
        {
            tracknumber = "";
            Connection1 = "";
            Connection2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateSurfaceTrackL16_L11 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable tracknumber.
        /// </summary>
        [TestVariable("6ec30747-6645-4c34-b347-5b93560f0df6")]
        public string tracknumber
        {
            get { return repo.tracknumber; }
            set { repo.tracknumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection1.
        /// </summary>
        [TestVariable("1d3138a6-569c-4d19-b04a-613ce9591279")]
        public string Connection1
        {
            get { return repo.connection1; }
            set { repo.connection1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection2.
        /// </summary>
        [TestVariable("ed191fb8-1fc2-4981-908a-a591cfb787b4")]
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
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1000ms.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            RightClickTrack();
            Delay.Milliseconds(0);
            
            ViewTrackProperties();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1000ms.", new RecordItemIndex(5));
            Delay.Duration(1000, false);
            
            ValidateSourceType();
            Delay.Milliseconds(0);
            
            ValidateTrackType();
            Delay.Milliseconds(0);
            
            ValidateSurface();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Surface_TN.ButtonCLOSE' at Center.", repo.FormMain__Surface_TN.ButtonCLOSEInfo, new RecordItemIndex(9));
            repo.FormMain__Surface_TN.ButtonCLOSE.Click();
            Delay.Milliseconds(0);
            
            RightClickTrack();
            Delay.Milliseconds(0);
            
            DropTrack();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(12));
            Delay.Duration(500, false);
            
            Validate_DropTrack();
            Delay.Milliseconds(0);
            
            Zoom500();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
