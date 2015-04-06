/*
 * Created by Ranorex
 * User: gguenther
 * Date: 2/9/2010
 * Time: 4:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Threading;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using Ranorex;
using Ranorex.Core;

namespace ConfigurationWizardLib
{
    class Program
    {
        [STAThread]
        public int Main(string[] args)
        {
            Keyboard.AbortKey = System.Windows.Forms.Keys.Pause;
            int error = 0;

            string logFileName = "Test.rxlog";

            Report.Setup(ReportLevel.Info, logFileName, true);

            try
            {
                //TODO: Code here - for example:
//                Recording1.Start();
            }
            catch (ImageNotFoundException e)
            {
                Report.Error(e.ToString());
                Report.LogData(ReportLevel.Error, "Image not found", e.Feature);
                Report.LogData(ReportLevel.Error, "Searched image", e.Image);
                error = -1;
            }
            catch (RanorexException e)
            {
                Report.Error(e.ToString());
                Report.Screenshot();
                error = -1;
            }
            catch (ThreadAbortException)
            {
                Report.Warn("AbortKey has been pressed");
                Thread.ResetAbort();
            }
            catch (Exception e)
            {
                Report.Error("Unexpected exception occured: " + e.ToString());
                error = -1;
            }

            Report.End();
            return error;
        }
    }
}
