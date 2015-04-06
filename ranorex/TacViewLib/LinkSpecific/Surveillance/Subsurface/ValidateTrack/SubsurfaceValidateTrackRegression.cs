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

namespace TacViewLib.LinkSpecific.Surveillance.Subsurface.ValidateTrack
{
    /// <summary>
    /// The SubsurfaceValidateTrackRegression recording.
    /// </summary>
    [TestModule("3e4645a9-b73b-4542-9bf3-79951f816aba", ModuleType.Recording, 1)]
    public partial class SubsurfaceValidateTrackRegression : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static SubsurfaceValidateTrackRegression instance = new SubsurfaceValidateTrackRegression();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SubsurfaceValidateTrackRegression()
        {
            tracknumber = "";
            Connection1 = "";
            Connection2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SubsurfaceValidateTrackRegression Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable tracknumber.
        /// </summary>
        [TestVariable("542b8e89-a5b1-4448-8ec6-0ae64a57b225")]
        public string tracknumber
        {
            get { return repo.tracknumber; }
            set { repo.tracknumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection1.
        /// </summary>
        [TestVariable("69c445d5-9205-4441-b6dd-ac0d50c72011")]
        public string Connection1
        {
            get { return repo.connection1; }
            set { repo.connection1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection2.
        /// </summary>
        [TestVariable("2882e4bf-0fb7-4d0e-be0d-7b8f203c158b")]
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
            
            RightClickTrack();
            Delay.Milliseconds(0);
            
            ViewTrackProperties();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1000ms.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            ValidateID();
            Delay.Milliseconds(0);
            
            ValidatePlat();
            Delay.Milliseconds(0);
            
            ValidateAct();
            Delay.Milliseconds(0);
            
            ValidateStype();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemBasic_Track_Info' at CenterLeft.", repo.FormMainCreate.ListItemBasic_Track_InfoInfo, new RecordItemIndex(9));
            repo.FormMainCreate.ListItemBasic_Track_Info.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            ValidateDepth();
            Delay.Milliseconds(0);
            
            ValidateVelocity();
            Delay.Milliseconds(0);
            
            ValidateCourse();
            Delay.Milliseconds(0);
            
            ValidateMagneticCourse();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemPosition_and_SpeedVelocity' at CenterLeft.", repo.FormMainCreate.ListItemPosition_and_SpeedVelocityInfo, new RecordItemIndex(14));
            repo.FormMainCreate.ListItemPosition_and_SpeedVelocity.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            ValidateReportingUnit();
            Delay.Milliseconds(0);
            
            ValidateHiPriority();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemInterface_Info' at CenterLeft.", repo.FormMainCreate.ListItemInterface_InfoInfo, new RecordItemIndex(17));
            repo.FormMainCreate.ListItemInterface_Info.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            ValidateSPI();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__SubSurface_TN.ListItemIndicators' at CenterLeft.", repo.FormMain__SubSurface_TN.ListItemIndicatorsInfo, new RecordItemIndex(19));
            repo.FormMain__SubSurface_TN.ListItemIndicators.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            ValidateMode1();
            Delay.Milliseconds(0);
            
            ValidateMode2();
            Delay.Milliseconds(0);
            
            ValidateMode3();
            Delay.Milliseconds(0);
            
            ValidateMode4();
            Delay.Milliseconds(0);
            
            ValidateMode5();
            Delay.Milliseconds(0);
            
            ValidateM5Nat();
            Delay.Milliseconds(0);
            
            ValidateM5ID();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemMode_Codes_Special_Codes' at CenterLeft.", repo.FormMainCreate.ListItemMode_Codes_Special_CodesInfo, new RecordItemIndex(27));
            repo.FormMainCreate.ListItemMode_Codes_Special_Codes.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            ValidateConfLevel();
            Delay.Milliseconds(0);
            
            ValidateDepthContact();
            Delay.Milliseconds(0);
            
            ValidateSubSensor();
            Delay.Milliseconds(0);
            
            ValidateAcousticChar();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__SubSurface_TN.ListItemSubsurface_Info' at CenterLeft.", repo.FormMain__SubSurface_TN.ListItemSubsurface_InfoInfo, new RecordItemIndex(32));
            repo.FormMain__SubSurface_TN.ListItemSubsurface_Info.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(100);
            
            ValidateReportType();
            Delay.Milliseconds(0);
            
            ValidateLaunchCap();
            Delay.Milliseconds(0);
            
            ValidateTimeFunction();
            Delay.Milliseconds(0);
            
            ValidateHour();
            Delay.Milliseconds(0);
            
            ValidateMinute();
            Delay.Milliseconds(0);
            
            ValidateIDL();
            Delay.Milliseconds(0);
            
            ValidateTADIL();
            Delay.Milliseconds(0);
            
            ValidateATDL();
            Delay.Milliseconds(0);
            
            ValidateNL1();
            Delay.Milliseconds(0);
            
            ValidateTADILJ();
            Delay.Milliseconds(0);
            
            ValidateExt();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__SubSurface_TN.ButtonCLOSE' at Center.", repo.FormMain__SubSurface_TN.ButtonCLOSEInfo, new RecordItemIndex(44));
            repo.FormMain__SubSurface_TN.ButtonCLOSE.Click();
            Delay.Milliseconds(0);
            
            RightClickTrack();
            Delay.Milliseconds(0);
            
            DropTrack();
            Delay.Milliseconds(0);
            
            Validate_DropTrack();
            Delay.Milliseconds(0);
            
            Zoom500();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
