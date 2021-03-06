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

namespace TacViewLib.LinkSpecific.Surveillance.Land.CreateTrack
{
    /// <summary>
    /// The CreateLandTrackL16_L11 recording.
    /// </summary>
    [TestModule("f12279e5-844b-48c7-83d4-ff55ef754132", ModuleType.Recording, 1)]
    public partial class CreateLandTrackL16_L11 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static CreateLandTrackL16_L11 instance = new CreateLandTrackL16_L11();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateLandTrackL16_L11()
        {
            Connection2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateLandTrackL16_L11 Instance
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
        [TestVariable("9654b6c8-6678-4c06-b99d-4868124aec1e")]
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1.MenuItemLand_Point_Track' at Center.", repo.FormConnection1.MenuItemLand_Point_TrackInfo, new RecordItemIndex(4));
            repo.FormConnection1.MenuItemLand_Point_Track.Click(100);
            Delay.Milliseconds(150);
            
            IndVal();
            Delay.Milliseconds(0);
            
            IDval();
            Delay.Milliseconds(0);
            
            PlatVal();
            Delay.Milliseconds(0);
            
            ActVal();
            Delay.Milliseconds(0);
            
            STypeVal();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(10));
            repo.FormMainCreate.ButtonSave.Click(100);
            Delay.Milliseconds(150);
            
            GetTrackNum();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
