/*
 * Created by Ranorex
 * User: prve
 * Date: 2/25/2022
 * Time: 11:54 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace UmlautTecDraw
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class GeneralUtilities
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static string filename(string filenamePrefix, string fileExtension)
        {
        	
        	var now = System.DateTime.Now;
            var strTimestamp = now.ToString("yyyyMMdd_HHmmss");
            var filename = filenamePrefix + "_" + strTimestamp + "." + fileExtension;
            Report.Info(filename);
            
            return filename;
        }
        
        
    }
}



