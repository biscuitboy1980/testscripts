/*
 * Created by Ranorex
 * User: kbadura
 * Date: 7/1/2011
 * Time: 2:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Reporting;
using Ranorex.Core.Testing;

namespace Link16_Link11_Regression
{
    class Program
    {  	   	
        [STAThread]
        public static int Main(string[] args)
        {
            Keyboard.AbortKey = System.Windows.Forms.Keys.Pause;
            int error = 0;
            
            try
            {
                error = TestSuiteRunner.Run(typeof(Program), Environment.CommandLine);
            }
            catch (Exception e)
            {
                Report.Error("Unexpected exception occured: " + e.ToString());
                error = -1;
            }
            return error;
        }
    }
}
