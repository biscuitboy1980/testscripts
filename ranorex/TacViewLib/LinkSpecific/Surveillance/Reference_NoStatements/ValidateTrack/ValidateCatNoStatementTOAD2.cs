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

namespace TacViewLib.LinkSpecific.Surveillance.Reference_NoStatements.ValidateTrack
{
    /// <summary>
    /// The ValidateCatNoStatementTOAD2 recording.
    /// </summary>
    [TestModule("6eb7e631-8f6f-41d0-897e-9b67c88a0d3c", ModuleType.Recording, 1)]
    public partial class ValidateCatNoStatementTOAD2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewLibRepository repository.
        /// </summary>
        public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

        static ValidateCatNoStatementTOAD2 instance = new ValidateCatNoStatementTOAD2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateCatNoStatementTOAD2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateCatNoStatementTOAD2 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Connection2.
        /// </summary>
        [TestVariable("e53901ca-ca07-4c1b-99d6-2269be5284e7")]
        public string Connection2
        {
            get { return repo.Connection2; }
            set { repo.Connection2 = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1.7m.", new RecordItemIndex(0));
            Delay.Duration(100000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FormTacViewC2.PictureTrackValidate' at Center.", repo.FormTacViewC2.PictureTrackValidateInfo, new RecordItemIndex(1));
            repo.FormTacViewC2.PictureTrackValidate.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemConnection2' at Center.", repo.FormRealView.MenuItemConnection2Info, new RecordItemIndex(2));
            repo.FormRealView.MenuItemConnection2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection2.MenuItemTrack_Properties' at 103;14.", repo.FormConnection2.MenuItemTrack_PropertiesInfo, new RecordItemIndex(3));
            repo.FormConnection2.MenuItemTrack_Properties.Click("103;14");
            Delay.Milliseconds(0);
            
            Validate_ListItemPoint_Type();
            Delay.Milliseconds(250);
            
            Validate_ListItemAmplification();
            Delay.Milliseconds(250);
            
            Validate_ListItemEnviron_Category();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Reference_Point_TN.ButtonCLOSE' at 7;7.", repo.FormMain__Reference_Point_TN.ButtonCLOSEInfo, new RecordItemIndex(7));
            repo.FormMain__Reference_Point_TN.ButtonCLOSE.Click("7;7");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
