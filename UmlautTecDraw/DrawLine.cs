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
    ///The DrawLine recording.
    /// </summary>
    [TestModule("24289aa4-a0c6-4288-b0b4-0c6a761b3bb2", ModuleType.Recording, 1)]
    public partial class DrawLine : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UmlautTecDrawRepository repository.
        /// </summary>
        public static UmlautTecDrawRepository repo = UmlautTecDrawRepository.Instance;

        static DrawLine instance = new DrawLine();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DrawLine()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DrawLine Instance
        {
            get { return instance; }
        }

#region Variables

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
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Middle Click item 'MainWin.Canvas1.CanvasCtrl' at 753;194.", repo.MainWin.Canvas1.CanvasCtrlInfo, new RecordItemIndex(10));
            //repo.MainWin.Canvas1.CanvasCtrl.Click(System.Windows.Forms.MouseButtons.Middle, "753;194");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LineForm.Open' at 5;11.", repo.LineForm.OpenInfo, new RecordItemIndex(11));
            repo.LineForm.Open.Click("5;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LineForm.Close' at -37;87.", repo.LineForm.CloseInfo, new RecordItemIndex(12));
            repo.LineForm.Close.Click("-37;87");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LineForm.GbxPoint2' at -6;-48.", repo.LineForm.GbxPoint2Info, new RecordItemIndex(13));
            repo.LineForm.GbxPoint2.Click("-6;-48");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LineForm.CmbLineType' at 57;47.", repo.LineForm.CmbLineTypeInfo, new RecordItemIndex(14));
            repo.LineForm.CmbLineType.Click("57;47");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LineForm.GbxVisuals' at 241;80.", repo.LineForm.GbxVisualsInfo, new RecordItemIndex(15));
            repo.LineForm.GbxVisuals.Click("241;80");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ListItem06' at 27;8.", repo.List1000.ListItem06Info, new RecordItemIndex(16));
            repo.List1000.ListItem06.Click("27;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LineForm.BtnOK' at 30;13.", repo.LineForm.BtnOKInfo, new RecordItemIndex(17));
            repo.LineForm.BtnOK.Click("30;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.Canvas1.CanvasCtrl' at 483;160.", repo.MainWin.Canvas1.CanvasCtrlInfo, new RecordItemIndex(18));
            repo.MainWin.Canvas1.CanvasCtrl.Click("483;160");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.Canvas1.CanvasCtrl' at 455;139.", repo.MainWin.Canvas1.CanvasCtrlInfo, new RecordItemIndex(19));
            repo.MainWin.Canvas1.CanvasCtrl.Click("455;139");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Ff0000ff' at 74;5.", repo.List1000.Ff0000ffInfo, new RecordItemIndex(20));
            repo.List1000.Ff0000ff.Click("74;5");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}