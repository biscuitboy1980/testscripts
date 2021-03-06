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
    /// The ValidateSurfaceTrackSimple recording.
    /// </summary>
    [TestModule("500c0238-fbde-4ca7-97c5-16eb265ac4c5", ModuleType.Recording, 1)]
    public partial class ValidateSurfaceTrackSimple : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static ValidateSurfaceTrackSimple instance = new ValidateSurfaceTrackSimple();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateSurfaceTrackSimple()
        {
            tracknumber = "";
            Connection1 = "";
            Connection2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateSurfaceTrackSimple Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable tracknumber.
        /// </summary>
        [TestVariable("97a46f19-66e4-4733-afdd-a13c8dd7f294")]
        public string tracknumber
        {
            get { return repo.tracknumber; }
            set { repo.tracknumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection1.
        /// </summary>
        [TestVariable("c68327e7-560c-4139-bedb-e0f9164da586")]
        public string Connection1
        {
            get { return repo.connection1; }
            set { repo.connection1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection2.
        /// </summary>
        [TestVariable("6ccef16f-a573-42ce-a8bf-d7208c00681f")]
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
            
            ValidateTrackType();
            Delay.Milliseconds(100);
            
            ValidateID();
            Delay.Milliseconds(0);
            
            DropTrack();
            Delay.Milliseconds(100);
            
            Validate_DropTrack();
            Delay.Milliseconds(100);
            
            Zoom500();
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
}
