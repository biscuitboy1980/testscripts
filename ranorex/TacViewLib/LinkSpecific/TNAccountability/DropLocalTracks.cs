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

namespace TacViewLib.LinkSpecific.TNAccountability
{
    /// <summary>
    /// The DropLocalTracks recording.
    /// </summary>
    [TestModule("3f002302-60b2-41f9-a5f9-a3ff28e079d3", ModuleType.Recording, 1)]
    public partial class DropLocalTracks : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static DropLocalTracks instance = new DropLocalTracks();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DropLocalTracks()
        {
            Connection1 = "cPCI_ADSI";
            ownunit = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DropLocalTracks Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Connection1.
        /// </summary>
        [TestVariable("5e585ca4-56c2-4864-a9b1-04f37679fdd9")]
        public string Connection1
        {
            get { return repo.connection1; }
            set { repo.connection1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ownunit.
        /// </summary>
        [TestVariable("e74631fa-3bc4-4f0f-af23-53744d3ba48e")]
        public string ownunit
        {
            get { return repo.ownunit; }
            set { repo.ownunit = value; }
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

        }

#region Image Feature Data
#endregion
    }
}