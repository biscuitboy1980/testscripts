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

namespace TacViewLib.LinkSpecific.Surveillance.Reference.CreateTrack
{
    /// <summary>
    /// The ReferenceCreateSpaceTrackRegression recording.
    /// </summary>
    [TestModule("731c34f7-c01f-4482-b053-1cdac121910e", ModuleType.Recording, 1)]
    public partial class ReferenceCreateSpaceTrackRegression : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static ReferenceCreateSpaceTrackRegression instance = new ReferenceCreateSpaceTrackRegression();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ReferenceCreateSpaceTrackRegression()
        {
            Connection2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ReferenceCreateSpaceTrackRegression Instance
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
        [TestVariable("32d6ae66-4f62-47d7-ae00-a8840f7ac727")]
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
            repo.FormRealView.MenuItemCreate_Track.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCreate_Track.MenuItemConnection1' at Center.", repo.FormCreate_Track.MenuItemConnection1Info, new RecordItemIndex(3));
            repo.FormCreate_Track.MenuItemConnection1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1.MenuItemSpace' at Center.", repo.FormConnection1.MenuItemSpaceInfo, new RecordItemIndex(4));
            repo.FormConnection1.MenuItemSpace.Click();
            Delay.Milliseconds(0);
            
            IdVal();
            Delay.Milliseconds(0);
            
            PlatVal();
            Delay.Milliseconds(0);
            
            ActVal();
            Delay.Milliseconds(0);
            
            STypeVal();
            Delay.Milliseconds(0);
            
            AltVal();
            Delay.Milliseconds(0);
            
            VelVal();
            Delay.Milliseconds(0);
            
            CrsVal();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(12));
            repo.FormMainCreate.ButtonSave.Click();
            Delay.Milliseconds(0);
            
            GetTrackNum();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
