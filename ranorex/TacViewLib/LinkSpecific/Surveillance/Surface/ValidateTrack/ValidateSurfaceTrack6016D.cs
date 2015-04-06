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

namespace TacViewLib.LinkSpecific.Surveillance.Surface.ValidateTrack
{
    /// <summary>
    /// The ValidateSurfaceTrack6016D recording.
    /// </summary>
    [TestModule("6b71430f-af3e-42c5-972f-50563d2440c6", ModuleType.Recording, 1)]
    public partial class ValidateSurfaceTrack6016D : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewLibRepository repository.
        /// </summary>
        public static TacViewLib.TacViewLibRepository repo = TacViewLib.TacViewLibRepository.Instance;

        static ValidateSurfaceTrack6016D instance = new ValidateSurfaceTrack6016D();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateSurfaceTrack6016D()
        {
            PlatN = "1";
            Plat = "Aircraft Carrier";
            ActN = "1";
            Act = "Air Warfare Support";
            StypeN = "1";
            Stype = "CVN GENERAL (ACFT CARRIER, NUCLEAR)";
            tracknumber = "";
            Connection1 = "";
            Connection2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateSurfaceTrack6016D Instance
        {
            get { return instance; }
        }

#region Variables

        string _PlatN;

        /// <summary>
        /// Gets or sets the value of variable PlatN.
        /// </summary>
        [TestVariable("fdc9ef74-6d36-4a02-93c6-a25ca9f45266")]
        public string PlatN
        {
            get { return _PlatN; }
            set { _PlatN = value; }
        }

        string _Plat;

        /// <summary>
        /// Gets or sets the value of variable Plat.
        /// </summary>
        [TestVariable("71a59741-2a7f-43de-8df3-c5646423def7")]
        public string Plat
        {
            get { return _Plat; }
            set { _Plat = value; }
        }

        string _ActN;

        /// <summary>
        /// Gets or sets the value of variable ActN.
        /// </summary>
        [TestVariable("a330a3ef-ede5-4016-b592-e3a8f5d199e5")]
        public string ActN
        {
            get { return _ActN; }
            set { _ActN = value; }
        }

        string _Act;

        /// <summary>
        /// Gets or sets the value of variable Act.
        /// </summary>
        [TestVariable("7412e05a-b831-4e42-8e60-19ef80feff0e")]
        public string Act
        {
            get { return _Act; }
            set { _Act = value; }
        }

        string _StypeN;

        /// <summary>
        /// Gets or sets the value of variable StypeN.
        /// </summary>
        [TestVariable("158861ca-5d62-4a81-b753-368267aa3ac2")]
        public string StypeN
        {
            get { return _StypeN; }
            set { _StypeN = value; }
        }

        string _Stype;

        /// <summary>
        /// Gets or sets the value of variable Stype.
        /// </summary>
        [TestVariable("6947fe07-ae14-4295-9bac-73be029ecc07")]
        public string Stype
        {
            get { return _Stype; }
            set { _Stype = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable tracknumber.
        /// </summary>
        [TestVariable("2994d39a-145d-4dc3-8007-4f2e2e3572b4")]
        public string tracknumber
        {
            get { return repo.tracknumber; }
            set { repo.tracknumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection1.
        /// </summary>
        [TestVariable("52ae4594-8f9f-4331-98f7-43a0c83d0072")]
        public string Connection1
        {
            get { return repo.Connection1; }
            set { repo.Connection1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection2.
        /// </summary>
        [TestVariable("075e077e-7643-46eb-82ca-779198544767")]
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
            
            ValidateID();
            Delay.Milliseconds(0);
            
            ValidatePlat();
            Delay.Milliseconds(0);
            
            ValidateAct();
            Delay.Milliseconds(0);
            
            ValidateStype();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Surface_TN.ButtonCLOSE' at Center.", repo.FormMain__Surface_TN.ButtonCLOSEInfo, new RecordItemIndex(8));
            repo.FormMain__Surface_TN.ButtonCLOSE.Click();
            Delay.Milliseconds(0);
            
            RightClickTrack();
            Delay.Milliseconds(0);
            
            DropTrack();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2000ms.", new RecordItemIndex(11));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
}
