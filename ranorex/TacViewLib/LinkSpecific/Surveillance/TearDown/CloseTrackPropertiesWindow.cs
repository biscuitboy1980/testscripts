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

namespace TacViewLib.LinkSpecific.Surveillance.TearDown
{
    /// <summary>
    /// The CloseTrackPropertiesWindow recording.
    /// </summary>
    [TestModule("89878680-bc06-42ed-80fd-8a95802eb5f5", ModuleType.Recording, 1)]
    public partial class CloseTrackPropertiesWindow : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewLibRepository repository.
        /// </summary>
        public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

        static CloseTrackPropertiesWindow instance = new CloseTrackPropertiesWindow();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseTrackPropertiesWindow()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseTrackPropertiesWindow Instance
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

            Mouse_Click_ButtonCLOSE1();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
