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
using Ranorex.Core.Repository;

namespace UmlautTecDraw
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LineDoubleClick recording.
    /// </summary>
    [TestModule("294ce3d9-34cf-49ef-a539-68609483e24f", ModuleType.Recording, 1)]
    public partial class LineDoubleClick : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UmlautTecDrawRepository repository.
        /// </summary>
        public static UmlautTecDrawRepository repo = UmlautTecDrawRepository.Instance;

        static LineDoubleClick instance = new LineDoubleClick();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LineDoubleClick()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LineDoubleClick Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable ColorSelection.
        /// </summary>
        [TestVariable("1e2b8a30-b9f0-4098-96ce-a39292274bb1")]
        public string ColorSelection
        {
            get { return repo.ColorSelection; }
            set { repo.ColorSelection = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable LineTypeSelection.
        /// </summary>
        [TestVariable("5e16c311-ccee-4c1a-bc9f-5c92a0a79c0a")]
        public string LineTypeSelection
        {
            get { return repo.LineTypeSelection; }
            set { repo.LineTypeSelection = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable LineWidth.
        /// </summary>
        [TestVariable("1c46164b-33a6-4a48-9f91-1750ea854bf8")]
        public string LineWidth
        {
            get { return repo.LineWidth; }
            set { repo.LineWidth = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.PushButton1' at 26;10.", repo.MainWin.PushButton1Info, new RecordItemIndex(0));
            repo.MainWin.PushButton1.Click("26;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.PushButton1' at 52;13.", repo.MainWin.PushButton1Info, new RecordItemIndex(1));
            repo.MainWin.PushButton1.Click("52;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.Canvas1.CanvasCtrl' at 329;268.", repo.MainWin.Canvas1.CanvasCtrlInfo, new RecordItemIndex(2));
            repo.MainWin.Canvas1.CanvasCtrl.Click("329;268");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.Canvas1.CanvasCtrl' at 556;35.", repo.MainWin.Canvas1.CanvasCtrlInfo, new RecordItemIndex(3));
            repo.MainWin.Canvas1.CanvasCtrl.Click("556;35");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.Canvas1.CanvasCtrl' at 583;276.", repo.MainWin.Canvas1.CanvasCtrlInfo, new RecordItemIndex(4));
            repo.MainWin.Canvas1.CanvasCtrl.Click("583;276");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.Canvas1.CanvasCtrl' at 284;522.", repo.MainWin.Canvas1.CanvasCtrlInfo, new RecordItemIndex(5));
            repo.MainWin.Canvas1.CanvasCtrl.Click("284;522");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.Canvas1.CanvasCtrl' at 522;437.", repo.MainWin.Canvas1.CanvasCtrlInfo, new RecordItemIndex(6));
            repo.MainWin.Canvas1.CanvasCtrl.Click("522;437");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.Canvas1.CanvasCtrl' at 618;356.", repo.MainWin.Canvas1.CanvasCtrlInfo, new RecordItemIndex(7));
            repo.MainWin.Canvas1.CanvasCtrl.Click("618;356");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape}' with focus on 'MainWin.Canvas1.CanvasCtrl'.", repo.MainWin.Canvas1.CanvasCtrlInfo, new RecordItemIndex(8));
            repo.MainWin.Canvas1.CanvasCtrl.PressKeys("{Escape}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MainWin.Canvas1.CanvasCtrl' at 430;164.", repo.MainWin.Canvas1.CanvasCtrlInfo, new RecordItemIndex(9));
            repo.MainWin.Canvas1.CanvasCtrl.DoubleClick("430;164");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LineForm.Open' at 6;8.", repo.LineForm.OpenInfo, new RecordItemIndex(10));
            repo.LineForm.Open.Click("6;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Ff009900' at 72;7.", repo.List1000.Ff009900Info, new RecordItemIndex(11));
            repo.List1000.Ff009900.Click("72;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LineForm.Open1' at 8;9.", repo.LineForm.Open1Info, new RecordItemIndex(12));
            repo.LineForm.Open1.Click("8;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.BrokenDash' at 72;10.", repo.List1000.BrokenDashInfo, new RecordItemIndex(13));
            repo.List1000.BrokenDash.Click("72;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LineForm.Open2' at 6;11.", repo.LineForm.Open2Info, new RecordItemIndex(14));
            repo.LineForm.Open2.Click("6;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ListItem035' at 72;7.", repo.List1000.ListItem035Info, new RecordItemIndex(15));
            repo.List1000.ListItem035.Click("72;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LineForm.BtnOK' at 29;11.", repo.LineForm.BtnOKInfo, new RecordItemIndex(16));
            repo.LineForm.BtnOK.Click("29;11");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
