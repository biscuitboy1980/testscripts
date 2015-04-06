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
using System.Windows.Forms;

using Ranorex;
using Ranorex.Core;

namespace TacViewLib.UISpecific.ATOUpgrade.Import_Test
{
    /// <summary>
    /// The ValidateATO2 recording.
    /// </summary>
    public partial class ValidateATO2
    {
        public TacViewLib.ATOUpgradeRepository repo = TacViewLib.ATOUpgradeRepository.Instance;

        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "2.3.8")]
        public void Start()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            ValidateATO2.ValidateFile();
            Delay.Milliseconds(150);
            ValidateATO2.ValidateRecords();
            Delay.Milliseconds(150);
            Report.Info("Mouse Left Click item 'FormImport_Records_From_File.ButtonOK' at Center.");
            repo.FormImport_Records_From_File.ButtonOK.Click();
            Delay.Milliseconds(0);
            ValidateATO2.CloseDialog();
            Delay.Milliseconds(0);
            Report.Info("Mouse Left Click item 'FormTacViewC2____map__Defaul.MenuItemATO' at Center.");
            repo.FormTacViewC2.MenuItemATO.Click();
            Delay.Milliseconds(0);
            Report.Info("Mouse Left Click item 'FormATO.MenuItemView_Database' at Center.");
            repo.FormATO.MenuItemView_Database.Click();
            Delay.Milliseconds(0);
            ValidateATO2.Validate_TreeItemATO();
            Delay.Milliseconds(150);
            Report.Info("Mouse Left Click item 'FormATO_Database___C2_HOST.ButtonCLOSE' at Center.");
            repo.FormATO_Database___C2_HOST.ButtonCLOSE.Click();
            Delay.Milliseconds(0);
        }

#region Image Feature Data
#endregion
    }
}