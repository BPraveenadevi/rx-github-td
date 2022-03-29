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
    ///The GraphicProperty_Validation recording.
    /// </summary>
    [TestModule("291f4662-d042-4b7e-8429-6c1eb6156d0d", ModuleType.Recording, 1)]
    public partial class GraphicProperty_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UmlautTecDrawRepository repository.
        /// </summary>
        public static UmlautTecDrawRepository repo = UmlautTecDrawRepository.Instance;

        static GraphicProperty_Validation instance = new GraphicProperty_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public GraphicProperty_Validation()
        {
            GPColour = "ff009900";
            GPLineType = "Broken-dash";
            GPLineWidth = "0.35";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static GraphicProperty_Validation Instance
        {
            get { return instance; }
        }

#region Variables

        string _GPColour;

        /// <summary>
        /// Gets or sets the value of variable GPColour.
        /// </summary>
        [TestVariable("891436db-84c8-4884-af62-510c5773cc3b")]
        public string GPColour
        {
            get { return _GPColour; }
            set { _GPColour = value; }
        }

        string _GPLineType;

        /// <summary>
        /// Gets or sets the value of variable GPLineType.
        /// </summary>
        [TestVariable("a5064374-1f78-4591-a30e-7f9f3600640c")]
        public string GPLineType
        {
            get { return _GPLineType; }
            set { _GPLineType = value; }
        }

        string _GPLineWidth;

        /// <summary>
        /// Gets or sets the value of variable GPLineWidth.
        /// </summary>
        [TestVariable("ae921103-680e-475b-8263-dd3f9570bc9a")]
        public string GPLineWidth
        {
            get { return _GPLineWidth; }
            set { _GPLineWidth = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GPColour) on item 'MainWin.Property.ToolStripComboBoxControl'.", repo.MainWin.Property.ToolStripComboBoxControlInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.MainWin.Property.ToolStripComboBoxControlInfo, "Text", GPColour);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GPLineType) on item 'MainWin.Property.ToolStripComboBoxControl1'.", repo.MainWin.Property.ToolStripComboBoxControl1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MainWin.Property.ToolStripComboBoxControl1Info, "Text", GPLineType);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GPLineWidth) on item 'MainWin.Property.ToolStripComboBoxControl2'.", repo.MainWin.Property.ToolStripComboBoxControl2Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MainWin.Property.ToolStripComboBoxControl2Info, "Text", GPLineWidth);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}