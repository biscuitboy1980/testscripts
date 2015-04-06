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
    /// The TNBLKValidate recording.
    /// </summary>
    [TestModule("7771418c-beb5-407f-b46b-1d7a2413df1d", ModuleType.Recording, 1)]
    public partial class TNBLKValidate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static TNBLKValidate instance = new TNBLKValidate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TNBLKValidate()
        {
            TNBLKstart = "";
            track1 = "";
            track2 = "";
            track3 = "";
            track4 = "";
            Connection2 = "";
            tracknumber = "";
            TNreuse = "";
            LocalTN = "";
            ownunit = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TNBLKValidate Instance
        {
            get { return instance; }
        }

#region Variables

        string _TNBLKstart;

        /// <summary>
        /// Gets or sets the value of variable TNBLKstart.
        /// </summary>
        [TestVariable("0598ceef-2503-44ec-9ca8-ba0a895fd1c1")]
        public string TNBLKstart
        {
            get { return _TNBLKstart; }
            set { _TNBLKstart = value; }
        }

        string _track1;

        /// <summary>
        /// Gets or sets the value of variable track1.
        /// </summary>
        [TestVariable("7ab9448e-cca4-46a1-9092-ef6609b4c953")]
        public string track1
        {
            get { return _track1; }
            set { _track1 = value; }
        }

        string _track2;

        /// <summary>
        /// Gets or sets the value of variable track2.
        /// </summary>
        [TestVariable("91666461-edb5-4c6d-9301-287837b52de1")]
        public string track2
        {
            get { return _track2; }
            set { _track2 = value; }
        }

        string _track3;

        /// <summary>
        /// Gets or sets the value of variable track3.
        /// </summary>
        [TestVariable("d7eee6b7-8ed6-41eb-9f3d-93ccdd0454aa")]
        public string track3
        {
            get { return _track3; }
            set { _track3 = value; }
        }

        string _track4;

        /// <summary>
        /// Gets or sets the value of variable track4.
        /// </summary>
        [TestVariable("044e3d75-3636-49fc-829e-b5cf960de6d6")]
        public string track4
        {
            get { return _track4; }
            set { _track4 = value; }
        }

        string _TNreuse;

        /// <summary>
        /// Gets or sets the value of variable TNreuse.
        /// </summary>
        [TestVariable("a8ff8058-0ecc-49a0-8a55-124219f651b8")]
        public string TNreuse
        {
            get { return _TNreuse; }
            set { _TNreuse = value; }
        }

        string _LocalTN;

        /// <summary>
        /// Gets or sets the value of variable LocalTN.
        /// </summary>
        [TestVariable("a4354bfb-c763-4ab3-9605-14a286a9e508")]
        public string LocalTN
        {
            get { return _LocalTN; }
            set { _LocalTN = value; }
        }

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
        [TestVariable("fbc4431b-7bf5-405f-996b-fb5f9e8a4543")]
        public string ownunit
        {
            get { return repo.ownunit; }
            set { repo.ownunit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tracknumber.
        /// </summary>
        [TestVariable("e09ea85c-223c-4c77-ae57-4fef1cdf1599")]
        public string tracknumber
        {
            get { return repo.tracknumber; }
            set { repo.tracknumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection2.
        /// </summary>
        [TestVariable("84b4b472-a4f5-4d12-a50f-b9952c03bfa2")]
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
            Delay.Milliseconds(250);
            
            RandCoord();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemCreate_Track' at Center.", repo.FormRealView.MenuItemCreate_TrackInfo, new RecordItemIndex(2));
            repo.FormRealView.MenuItemCreate_Track.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCreate_Track.MenuItemConnection1' at Center.", repo.FormCreate_Track.MenuItemConnection1Info, new RecordItemIndex(3));
            repo.FormCreate_Track.MenuItemConnection1.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1.MenuItemAir' at Center.", repo.FormConnection1.MenuItemAirInfo, new RecordItemIndex(4));
            repo.FormConnection1.MenuItemAir.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(5));
            repo.FormMainCreate.ButtonSave.Click(100);
            Delay.Milliseconds(150);
            
            GetTrackNum();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleName=$track1) on item 'FormTacViewC2.PictureTrack'.", repo.FormTacViewC2.PictureTrackInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.FormTacViewC2.PictureTrackInfo, "AccessibleName", track1);
            Delay.Milliseconds(100);
            
            GetTrackCount();
            Delay.Milliseconds(250);
            
            RandCoord();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemCreate_Track' at Center.", repo.FormRealView.MenuItemCreate_TrackInfo, new RecordItemIndex(10));
            repo.FormRealView.MenuItemCreate_Track.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCreate_Track.MenuItemConnection1' at Center.", repo.FormCreate_Track.MenuItemConnection1Info, new RecordItemIndex(11));
            repo.FormCreate_Track.MenuItemConnection1.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1.MenuItemAir' at Center.", repo.FormConnection1.MenuItemAirInfo, new RecordItemIndex(12));
            repo.FormConnection1.MenuItemAir.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(13));
            repo.FormMainCreate.ButtonSave.Click(100);
            Delay.Milliseconds(150);
            
            GetTrackNum2();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleName=$track2) on item 'FormTacViewC2.PictureTrack'.", repo.FormTacViewC2.PictureTrackInfo, new RecordItemIndex(15));
            Validate.Attribute(repo.FormTacViewC2.PictureTrackInfo, "AccessibleName", track2);
            Delay.Milliseconds(100);
            
            GetTrackCount();
            Delay.Milliseconds(250);
            
            RandCoord();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemCreate_Track' at Center.", repo.FormRealView.MenuItemCreate_TrackInfo, new RecordItemIndex(18));
            repo.FormRealView.MenuItemCreate_Track.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCreate_Track.MenuItemConnection1' at Center.", repo.FormCreate_Track.MenuItemConnection1Info, new RecordItemIndex(19));
            repo.FormCreate_Track.MenuItemConnection1.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1.MenuItemAir' at Center.", repo.FormConnection1.MenuItemAirInfo, new RecordItemIndex(20));
            repo.FormConnection1.MenuItemAir.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(21));
            repo.FormMainCreate.ButtonSave.Click(100);
            Delay.Milliseconds(150);
            
            GetTrackNum3();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleName=$track3) on item 'FormTacViewC2.PictureTrack'.", repo.FormTacViewC2.PictureTrackInfo, new RecordItemIndex(23));
            Validate.Attribute(repo.FormTacViewC2.PictureTrackInfo, "AccessibleName", track3);
            Delay.Milliseconds(100);
            
            GetTrackCount();
            Delay.Milliseconds(250);
            
            RandCoord();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemCreate_Track' at Center.", repo.FormRealView.MenuItemCreate_TrackInfo, new RecordItemIndex(26));
            repo.FormRealView.MenuItemCreate_Track.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCreate_Track.MenuItemConnection1' at Center.", repo.FormCreate_Track.MenuItemConnection1Info, new RecordItemIndex(27));
            repo.FormCreate_Track.MenuItemConnection1.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1.MenuItemAir' at Center.", repo.FormConnection1.MenuItemAirInfo, new RecordItemIndex(28));
            repo.FormConnection1.MenuItemAir.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(29));
            repo.FormMainCreate.ButtonSave.Click(100);
            Delay.Milliseconds(150);
            
            GetTrackNum4();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleName=$LocalTN) on item 'FormTacViewC2.PiictureTrackLocal'.", repo.FormTacViewC2.PiictureTrackLocalInfo, new RecordItemIndex(31));
            Validate.Attribute(repo.FormTacViewC2.PiictureTrackLocalInfo, "AccessibleName", LocalTN);
            Delay.Milliseconds(100);
            
            SetRepoTN();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FormTacViewC2.PictureTrack' at Center.", repo.FormTacViewC2.PictureTrackInfo, new RecordItemIndex(33));
            repo.FormTacViewC2.PictureTrack.Click(System.Windows.Forms.MouseButtons.Right, 100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemTrackNumber' at Center.", repo.FormRealView.MenuItemTrackNumberInfo, new RecordItemIndex(34));
            repo.FormRealView.MenuItemTrackNumber.Click();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1DropTrack.MenuItemDrop_Track' at Center.", repo.FormConnection1DropTrack.MenuItemDrop_TrackInfo, new RecordItemIndex(35));
            repo.FormConnection1DropTrack.MenuItemDrop_Track.Click();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RealViewDialog.ButtonYes' at Center.", repo.RealViewDialog.ButtonYesInfo, new RecordItemIndex(36));
            repo.RealViewDialog.ButtonYes.Click();
            Delay.Milliseconds(940);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FormTacViewC2.PictureTrack'.", repo.FormTacViewC2.PictureTrackInfo, new RecordItemIndex(37));
            Validate.Exists(repo.FormTacViewC2.PictureTrackInfo, Validate.DefaultMessage, new Validate.Options(Validate.CreateScreenshot.OnFail));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleName=$TNreuse) on item 'FormTacViewC2.PictureTrackTNReuse'.", repo.FormTacViewC2.PictureTrackTNReuseInfo, new RecordItemIndex(38));
            Validate.Attribute(repo.FormTacViewC2.PictureTrackTNReuseInfo, "AccessibleName", TNreuse);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FormTacViewC2.PictureOwnUnit' at Center.", repo.FormTacViewC2.PictureOwnUnitInfo, new RecordItemIndex(39));
            repo.FormTacViewC2.PictureOwnUnit.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemConnection1' at Center.", repo.FormRealView.MenuItemConnection1Info, new RecordItemIndex(40));
            repo.FormRealView.MenuItemConnection1.Click();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1.MenuItemDropLocalTracks' at Center.", repo.FormConnection1.MenuItemDropLocalTracksInfo, new RecordItemIndex(41));
            repo.FormConnection1.MenuItemDropLocalTracks.Click();
            Delay.Milliseconds(1760);
            
        }

#region Image Feature Data
#endregion
    }
}
