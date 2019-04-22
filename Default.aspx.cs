using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace test
{
    public partial class _Default : Page
    {
        


        protected void button_Click_Click(object sender, EventArgs e)
        {
            FileStream fs = File.Create(@"C:\Users\Leo\Documents\fichier.txt");

            //File.WriteAllText(@"C:\Users\Leo\Documents\mtc\test\winp.txt", ListBox1.Text +  "    "+"Motor Series " + Environment.NewLine + TextBox1.Text + "    "+"Motor HP " + Environment.NewLine +  TextBox2.Text + "    " + "Pump HP " + Environment.NewLine +  TextBox3.Text + "    " + "Bottom Hole Temperature " + Environment.NewLine +  TextBox4.Text + "    " + "Pumping Flow Rate " + Environment.NewLine +  TextBox5.Text + "    " + "Well Casing ID  " + Environment.NewLine +  TextBox6.Text + "    " + "Water cut" + Environment.NewLine +  TextBox7.Text+ "    " + "API " + Environment.NewLine +  TextBox8.Text + "    " + "Pump Intake Pressure PSI  " + Environment.NewLine +  TextBox9.Text + "    " + "Bubble Point PSI " + Environment.NewLine +  TextBox10.Text + "    " + "Solution Gas-Oil-Ratio at the intake SCF/STB " + Environment.NewLine +  TextBox11.Text + "    " + "SurfaceGas-Oil-RatioSCF/STB" + Environment.NewLine +  TextBox12.Text + "    " + "Motor Running Frequency", Encoding.Unicode);
            File.WriteAllText(@"C:\Users\Leo\Documents\mtc\test\winp.txt", ListBox1.Text + "    " + "Motor Series " + Environment.NewLine + TextBox1.Text + "    " + "Motor HP " + Environment.NewLine + TextBox2.Text + "    " + "Pump HP " + Environment.NewLine + TextBox3.Text + "    " + "Bottom Hole Temperature " + Environment.NewLine + TextBox4.Text + "    " + "Pumping Flow Rate " + Environment.NewLine + TextBox5.Text + "    " + "Well Casing ID  " + Environment.NewLine + TextBox6.Text + "    " + "Water cut" + Environment.NewLine + TextBox7.Text + "    " + "API " + Environment.NewLine + TextBox8.Text + "    " + "Pump Intake Pressure PSI  " + Environment.NewLine + TextBox9.Text + "    " + "Bubble Point PSI " + Environment.NewLine + TextBox10.Text + "    " + "Solution Gas-Oil-Ratio at the intake SCF/STB " + Environment.NewLine + TextBox11.Text + "    " + "SurfaceGas-Oil-RatioSCF/STB" + Environment.NewLine + TextBox12.Text + "    " + "Motor Running Frequency", Encoding.Unicode);

            fs.Close();
            // Process p = new Process();

            // p.WaitForInputIdle(@"C:\Users\Leo\Documents\winp.txt");
            //p.OutputDataReceived(@"C:\Users\Leo\Documents\wout.txt")
            //Process.Start(@"C:\Users\Leo\Documents\mtc\HRAPC4.exe", @"C: \Users\Leo\Documents\winp.txt");



            //ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Users\Leo\Documents\mtc\HRAPC4.exe");
           // startInfo.WindowStyle = ProcessWindowStyle.Normal;
           // startInfo.Arguments = (@"C: \Users\Leo\Documents\winp.txt"); 
            //Process.Start(startInfo);


            // 
            ProcessStartInfo psi = new ProcessStartInfo();

            psi.FileName = @"C:\Users\Leo\Documents\mtc\test\HRAPC4.exe";
            //psi.FileName = "Notepad++.exe";
            psi.Arguments = @"C:\Users\Leo\Documents\mtc\test\winp.txt";

            Process p = Process.Start(psi);
            p.WaitForExit(5000000);

        }

    }
}