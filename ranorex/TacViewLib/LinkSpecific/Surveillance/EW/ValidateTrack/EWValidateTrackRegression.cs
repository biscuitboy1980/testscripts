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

namespace TacViewLib.LinkSpecific.Surveillance.EW.ValidateTrack
{
    /// <summary>
    /// The EWValidateTrackRegression recording.
    /// </summary>
    [TestModule("dc10c10b-d010-4914-a964-860a90ca04c3", ModuleType.Recording, 1)]
    public partial class EWValidateTrackRegression : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static EWValidateTrackRegression instance = new EWValidateTrackRegression();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EWValidateTrackRegression()
        {
            tracknumber = "";
            Connection1 = "";
            Connection2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EWValidateTrackRegression Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable tracknumber.
        /// </summary>
        [TestVariable("20168c34-4523-4b56-a5c7-851147f938d8")]
        public string tracknumber
        {
            get { return repo.tracknumber; }
            set { repo.tracknumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection1.
        /// </summary>
        [TestVariable("08a3252b-b643-4fc3-b6f1-5c0649c609bf")]
        public string Connection1
        {
            get { return repo.connection1; }
            set { repo.connection1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection2.
        /// </summary>
        [TestVariable("95c624a8-5fe6-42e7-84b5-7347029d3f04")]
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
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2000ms.", new RecordItemIndex(4));
            Delay.Duration(2000, false);
            
            ValidateFoB();
            Delay.Milliseconds(0);
            
            ValidateId();
            Delay.Milliseconds(0);
            
            ValidateEnvCat();
            Delay.Milliseconds(0);
            
            ValidatePlat();
            Delay.Milliseconds(0);
            
            ValidateSType();
            Delay.Milliseconds(0);
            
            ValidateElAng();
            Delay.Milliseconds(0);
            
            ValidateAltVelCrs();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__EW_TN.ListItemBasic_Track_Info' at CenterLeft.", repo.FormMain__EW_TN.ListItemBasic_Track_InfoInfo, new RecordItemIndex(12));
            repo.FormMain__EW_TN.ListItemBasic_Track_Info.DoubleClick(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            ValidateHiPriority();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__EW_TN.ListItemPosition_and_SpeedVelocity' at CenterLeft.", repo.FormMain__EW_TN.ListItemPosition_and_SpeedVelocityInfo, new RecordItemIndex(14));
            repo.FormMain__EW_TN.ListItemPosition_and_SpeedVelocity.DoubleClick(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            ValidateSPI();
            Delay.Milliseconds(0);
            
            ValidateHR();
            Delay.Milliseconds(0);
            
            ValidateMN();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__EW_TN.ListItemInterface_Info' at CenterLeft.", repo.FormMain__EW_TN.ListItemInterface_InfoInfo, new RecordItemIndex(18));
            repo.FormMain__EW_TN.ListItemInterface_Info.DoubleClick(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__EW_TN.ListItemIndicators' at CenterLeft.", repo.FormMain__EW_TN.ListItemIndicatorsInfo, new RecordItemIndex(19));
            repo.FormMain__EW_TN.ListItemIndicators.DoubleClick(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            ValidateBear();
            Delay.Milliseconds(0);
            
            ValidateEmitNI();
            Delay.Milliseconds(0);
            
            ValidateEmitNum();
            Delay.Milliseconds(0);
            
            ValidateEmitCon();
            Delay.Milliseconds(0);
            
            ValidateWRM();
            Delay.Milliseconds(0);
            
            ValidatePEC();
            Delay.Milliseconds(0);
            
            ValidateFRI();
            Delay.Milliseconds(0);
            
            ValidateFreq1();
            Delay.Milliseconds(0);
            
            ValidateFreq1U();
            Delay.Milliseconds(0);
            
            ValidateFreq2();
            Delay.Milliseconds(0);
            
            ValidateFreq2U();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__EW_TN.ListItemTactical_EW_Info' at CenterLeft.", repo.FormMain__EW_TN.ListItemTactical_EW_InfoInfo, new RecordItemIndex(31));
            repo.FormMain__EW_TN.ListItemTactical_EW_Info.DoubleClick(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            ValidateAOP();
            Delay.Milliseconds(0);
            
            ValidateIDL();
            Delay.Milliseconds(0);
            
            ValidateTADIL();
            Delay.Milliseconds(0);
            
            ValidateATDIL();
            Delay.Milliseconds(0);
            
            ValidateNL1();
            Delay.Milliseconds(0);
            
            ValidateTADILJ();
            Delay.Milliseconds(0);
            
            ValidateExt();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__EW_TN.ButtonCLOSE' at Center.", repo.FormMain__EW_TN.ButtonCLOSEInfo, new RecordItemIndex(39));
            repo.FormMain__EW_TN.ButtonCLOSE.Click();
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
