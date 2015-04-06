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

namespace TacViewLib.LinkSpecific.Surveillance.Space.CreateTrack
{
    /// <summary>
    /// The CreateSpaceTrackL16_L11 recording.
    /// </summary>
    [TestModule("ddf3cd05-2a7b-44a6-81ba-0f92e7aeb936", ModuleType.Recording, 1)]
    public partial class CreateSpaceTrackL16_L11 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static CreateSpaceTrackL16_L11 instance = new CreateSpaceTrackL16_L11();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateSpaceTrackL16_L11()
        {
            Connection2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateSpaceTrackL16_L11 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable connection1.
        /// </summary>
        [TestVariable("5d4e3e56-3172-4cd7-82e9-644dce97207c")]
        public string connection1
        {
            get { return repo.connection1; }
            set { repo.connection1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ownunit.
        /// </summary>
        [TestVariable("ae53e9c2-51e5-48e8-a15d-34d6d9b55ce6")]
        public string ownunit
        {
            get { return repo.ownunit; }
            set { repo.ownunit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection2.
        /// </summary>
        [TestVariable("abd1e28b-2d17-4caa-8e54-349d92559536")]
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

            GetTrackCount();
            Delay.Milliseconds(0);
            
            RandCoord();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemCreate_Track' at Center.", repo.FormRealView.MenuItemCreate_TrackInfo, new RecordItemIndex(2));
            repo.FormRealView.MenuItemCreate_Track.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCreate_Track.MenuItemConnection1' at Center.", repo.FormCreate_Track.MenuItemConnection1Info, new RecordItemIndex(3));
            repo.FormCreate_Track.MenuItemConnection1.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1.MenuItemSpace' at Center.", repo.FormConnection1.MenuItemSpaceInfo, new RecordItemIndex(4));
            repo.FormConnection1.MenuItemSpace.Click(100);
            Delay.Milliseconds(150);
            
            IDval();
            Delay.Milliseconds(0);
            
            PlatVal();
            Delay.Milliseconds(0);
            
            ActVal();
            Delay.Milliseconds(0);
            
            STypeVal();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(9));
            repo.FormMainCreate.ButtonSave.Click(100);
            Delay.Milliseconds(150);
            
            GetTrackNum();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
