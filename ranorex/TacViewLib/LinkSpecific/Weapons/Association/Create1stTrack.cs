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

namespace TacViewLib.LinkSpecific.Weapons.Association
{
    /// <summary>
    /// The Create1stTrack recording.
    /// </summary>
    [TestModule("5f794978-5655-4f0f-a22a-13af781ec73b", ModuleType.Recording, 1)]
    public partial class Create1stTrack : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewLibWeapons repository.
        /// </summary>
        public static TacViewLib.TacViewLibWeapons repo = TacViewLib.TacViewLibWeapons.Instance;

        static Create1stTrack instance = new Create1stTrack();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Create1stTrack()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Create1stTrack Instance
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
            Mouse.DefaultMoveTime = 31;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 8.0;

            Init();

            GetTrackCount();
            Delay.Milliseconds(0);
            
            RandCoord();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemCreate_Track' at Center.", repo.FormRealView.MenuItemCreate_TrackInfo, new RecordItemIndex(2));
            repo.FormRealView.MenuItemCreate_Track.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCreate_Track.MenuItemTOAD' at Center.", repo.FormCreate_Track.MenuItemTOADInfo, new RecordItemIndex(3));
            repo.FormCreate_Track.MenuItemTOAD.Click(100);
            Delay.Milliseconds(150);
            
            TrackType();
            Delay.Milliseconds(0);
            
            IDval();
            Delay.Milliseconds(0);
            
            Platval();
            Delay.Milliseconds(0);
            
            Actval();
            Delay.Milliseconds(0);
            
            Stypeval();
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
