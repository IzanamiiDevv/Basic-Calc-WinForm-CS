using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Calculator;

namespace Calculator
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int op = Operator.SelectedIndex;
            string arg1 = Input1.Text;
            string arg2 = Input2.Text;

            Display.Text = $"Result: {Script.Calculate(arg1, arg2, op)}";
        }
    }
}

class Script
{
    public static string Calculate(string x, string y, int op)
    {
        string[] opertaros = {"add","sub","mul","divd","mod"};
        try
        {
            return Exec($"calc -x {x} -y {y} -op {opertaros[op]}");
        }
        catch(Exception e)
        {
            return "Error";
        }
    }

    public static string Exec(string command)
    {
        var output = new StringBuilder();
        var errorOutput = new StringBuilder();

        try
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c {command}";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.OutputDataReceived += (sender, e) =>
                {
                    if (e.Data != null)
                    {
                        output.AppendLine(e.Data);
                    }
                };

                process.ErrorDataReceived += (sender, e) =>
                {
                    if (e.Data != null)
                    {
                        errorOutput.AppendLine(e.Data);
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    throw new Exception($"Command failed with exit code {process.ExitCode}:\n{errorOutput}");
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"An error occurred while executing the command: {ex.Message}\n{errorOutput}");
        }

        return output.ToString();
    }
}