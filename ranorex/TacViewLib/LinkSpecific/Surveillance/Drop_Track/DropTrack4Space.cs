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

namespace TacViewLib.LinkSpecific.Surveillance.Drop_Track
{
    /// <summary>
    /// The DropTrack4Space recording.
    /// </summary>
    [TestModule("9baf2b04-d714-4bd4-863b-febe1124a455", ModuleType.Recording, 1)]
    public partial class DropTrack4Space : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static DropTrack4Space instance = new DropTrack4Space();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DropTrack4Space()
        {
            Connection1 = "";
            spacetracknumber = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DropTrack4Space Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Connection1.
        /// </summary>
        [TestVariable("d3d9802a-6cac-4aa1-ac99-85cd6b115855")]
        public string Connection1
        {
            get { return repo.connection1; }
            set { repo.connection1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable spacetracknumber.
        /// </summary>
        [TestVariable("d7b0db7e-de6c-4f1a-b64b-3c553d50eeef")]
        public string spacetracknumber
        {
            get { return repo.spacetracknumber; }
            set { repo.spacetracknumber = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1500ms.", new RecordItemIndex(0));
            Delay.Duration(1500, false);
            
            DropTrackSequence1();
            Delay.Milliseconds(0);
            
            DropTrackSequence2();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
