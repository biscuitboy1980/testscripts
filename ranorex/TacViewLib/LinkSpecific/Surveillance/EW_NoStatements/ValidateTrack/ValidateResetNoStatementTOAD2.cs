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

namespace TacViewLib.LinkSpecific.Surveillance.EW_NoStatements.ValidateTrack
{
    /// <summary>
    /// The ValidateResetNoStatementTOAD2 recording.
    /// </summary>
    [TestModule("d7f652e1-d2a5-431f-a7cd-74a27d1f662a", ModuleType.Recording, 1)]
    public partial class ValidateResetNoStatementTOAD2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewLibRepository repository.
        /// </summary>
        public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

        static ValidateResetNoStatementTOAD2 instance = new ValidateResetNoStatementTOAD2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateResetNoStatementTOAD2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateResetNoStatementTOAD2 Instance
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

        /// <summary>
        /// Gets or sets the value of variable Connection1.
        /// </summary>
        [TestVariable("df43c705-3ac9-4eb2-89a2-19da9f82d8e5")]
        public string Connection1
        {
            get { return repo.Connection1; }
            set { repo.Connection1 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FormTacViewC2.PictureTrackValidate' at Center.", repo.FormTacViewC2.PictureTrackValidateInfo, new RecordItemIndex(0));
            repo.FormTacViewC2.PictureTrackValidate.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemConnection2' at Center.", repo.FormRealView.MenuItemConnection2Info, new RecordItemIndex(1));
            repo.FormRealView.MenuItemConnection2.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection2.MenuItemTrack_Properties' at 103;14.", repo.FormConnection2.MenuItemTrack_PropertiesInfo, new RecordItemIndex(2));
            repo.FormConnection2.MenuItemTrack_Properties.Click("103;14");
            Delay.Milliseconds(0);
            
            Validate_ListItemPlatform1();
            Delay.Milliseconds(250);
            
            Validate_ListItemActivity1();
            Delay.Milliseconds(100);
            
            Validate_ListItemStype1();
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1m.", new RecordItemIndex(6));
            Delay.Duration(60000, false);
            
            Validate_ListItemPlatform2();
            Delay.Milliseconds(0);
            
            Validate_ListItemActivity2();
            Delay.Milliseconds(0);
            
            Validate_ListItemStype2();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__EW_TN.ButtonCLOSE' at 7;7.", repo.FormMain__EW_TN.ButtonCLOSEInfo, new RecordItemIndex(10));
            repo.FormMain__EW_TN.ButtonCLOSE.Click("7;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FormTacViewC2.PictureTrack1' at Center.", repo.FormTacViewC2.PictureTrack1Info, new RecordItemIndex(11));
            repo.FormTacViewC2.PictureTrack1.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemConnection1' at Center.", repo.FormRealView.MenuItemConnection1Info, new RecordItemIndex(12));
            repo.FormRealView.MenuItemConnection1.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1.MenuItemDrop_Track' at Center.", repo.FormConnection1.MenuItemDrop_TrackInfo, new RecordItemIndex(13));
            repo.FormConnection1.MenuItemDrop_Track.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RealViewDialog.ButtonYes' at 20;8.", repo.RealViewDialog.ButtonYesInfo, new RecordItemIndex(14));
            repo.RealViewDialog.ButtonYes.Click("20;8");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
