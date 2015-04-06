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
    /// The CreateRefTrack6016D recording.
    /// </summary>
    [TestModule("a9bf6e27-66b0-4640-89b9-a17ae9535c5f", ModuleType.Recording, 1)]
    public partial class CreateRefTrack6016D : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewLibRepository repository.
        /// </summary>
        public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

        static CreateRefTrack6016D instance = new CreateRefTrack6016D();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateRefTrack6016D()
        {
            Ptype = "Reference Point (General)";
            Amp = "Marshall Point";
            Connection2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateRefTrack6016D Instance
        {
            get { return instance; }
        }

#region Variables

        string _Ptype;

        /// <summary>
        /// Gets or sets the value of variable Ptype.
        /// </summary>
        [TestVariable("6219b4e5-61f5-4cf2-b143-b92fc2cd0711")]
        public string Ptype
        {
            get { return _Ptype; }
            set { _Ptype = value; }
        }

        string _Amp;

        /// <summary>
        /// Gets or sets the value of variable Amp.
        /// </summary>
        [TestVariable("fe94ef79-7aa2-4252-8e04-dc4cf9a44523")]
        public string Amp
        {
            get { return _Amp; }
            set { _Amp = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection1.
        /// </summary>
        [TestVariable("df43c705-3ac9-4eb2-89a2-19da9f82d8e5")]
        public string Connection1
        {
            get { return repo.Connection1; }
            set { repo.Connection1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tracknumber.
        /// </summary>
        [TestVariable("a42b76a2-7ee5-4202-b178-a9f49bc79da2")]
        public string tracknumber
        {
            get { return repo.tracknumber; }
            set { repo.tracknumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection2.
        /// </summary>
        [TestVariable("695e1a09-961f-4be1-bad0-d5624bc6587b")]
        public string Connection2
        {
            get { return repo.Connection2; }
            set { repo.Connection2 = value; }
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
            Mouse.DefaultMoveTime = 31;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 8.0;

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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1.MenuItemReference_Point' at Center.", repo.FormConnection1.MenuItemReference_PointInfo, new RecordItemIndex(4));
            repo.FormConnection1.MenuItemReference_Point.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__Reference_Point_TN.ListItemPoint_Type' at CenterLeft.", repo.FormMain__Reference_Point_TN.ListItemPoint_TypeInfo, new RecordItemIndex(5));
            repo.FormMain__Reference_Point_TN.ListItemPoint_Type.DoubleClick(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            PointType();
            Delay.Milliseconds(0);
            
            Amplification();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormTrackProperties.ListItemBasic_Track_Info' at CenterLeft.", repo.FormTrackProperties.ListItemBasic_Track_InfoInfo, new RecordItemIndex(8));
            repo.FormTrackProperties.ListItemBasic_Track_Info.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormTrackProperties.ListItemPosition_and_Speed' at CenterLeft.", repo.FormTrackProperties.ListItemPosition_and_SpeedInfo, new RecordItemIndex(9));
            repo.FormTrackProperties.ListItemPosition_and_Speed.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormTrackProperties.ListItemPosition_Relative_To_Bul' at CenterLeft.", repo.FormTrackProperties.ListItemPosition_Relative_To_BulInfo, new RecordItemIndex(10));
            repo.FormTrackProperties.ListItemPosition_Relative_To_Bul.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormTrackProperties.ListItemInterface_Info' at CenterLeft.", repo.FormTrackProperties.ListItemInterface_InfoInfo, new RecordItemIndex(11));
            repo.FormTrackProperties.ListItemInterface_Info.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormTrackProperties.ListItemSpecial_Codes' at CenterLeft.", repo.FormTrackProperties.ListItemSpecial_CodesInfo, new RecordItemIndex(12));
            repo.FormTrackProperties.ListItemSpecial_Codes.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormTrackProperties.ListItemIndicators' at CenterLeft.", repo.FormTrackProperties.ListItemIndicatorsInfo, new RecordItemIndex(13));
            repo.FormTrackProperties.ListItemIndicators.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormTrackProperties.ListItemReference_Point_Info' at CenterLeft.", repo.FormTrackProperties.ListItemReference_Point_InfoInfo, new RecordItemIndex(14));
            repo.FormTrackProperties.ListItemReference_Point_Info.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Reference_Point_TN.ListItemRelated_Track_Number' at CenterLeft.", repo.FormMain__Reference_Point_TN.ListItemRelated_Track_NumberInfo, new RecordItemIndex(15));
            repo.FormMain__Reference_Point_TN.ListItemRelated_Track_Number.Click(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            RelatedTN();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Reference_Point_TN.ButtonSave' at Center.", repo.FormMain__Reference_Point_TN.ButtonSaveInfo, new RecordItemIndex(17));
            repo.FormMain__Reference_Point_TN.ButtonSave.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2000ms.", new RecordItemIndex(18));
            Delay.Duration(2000, false);
            
            GetTrackNum();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}