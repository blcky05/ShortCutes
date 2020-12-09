﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

using System.CodeDom.Compiler;
using System.Diagnostics;
using Microsoft.CSharp;
using System.Text.RegularExpressions;
using IWshRuntimeLibrary;

namespace ShortCutes
{
    public partial class ShortCutes : Form
    {
        readonly List<Emulator> emus = Emulators.emus;
        public ShortCutes()
        {
            InitializeComponent();

            foreach(var emu in emus)
                emulatorcb.Items.Add(emu.Name);
        }

        //Permite arrastrar el formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBorderStyle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        readonly private string path = Path.GetTempPath();

        private int emuindex = -1;
        private void Emulatorcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int lastemuindex = emuindex;

            if (emulatorcb.SelectedItem != null)
                emuindex = emulatorcb.SelectedIndex;

            if (lastemuindex != emuindex)
            {
                Edirbox.Text = null;
                Gdirbox.Text = null;
            }
        }

        private void CreateShortCute_Click(object sender, EventArgs e)
        {
            string emulatorpath = Edirbox.Text;
            if (!emulatorpath.EndsWith("\\"))
                emulatorpath += @"\";

            string code = Emulator(Gdirbox.Text, emulatorpath);

            if (code == "false")
                return;
            else
            {
                if (!Image)
                {
                    Error("Select a picture to continue.");
                    return;
                }
                Regex containsABadCharacter = new Regex("["
                + Regex.Escape(new string(Path.GetInvalidPathChars()))
                + "]");
                if (containsABadCharacter.IsMatch(Shortcutbox.Text))
                {
                    char[] invalidFileChars = Path.GetInvalidFileNameChars();

                    Error("Invalid filename!\n Cannot contain: " + string.Join(", ", invalidFileChars));
                    return;
                }
                Compile(code, emulatorpath, Shortcutbox.Text);
                if (OpenShortFolderCheck.Checked)
                    System.Diagnostics.Process.Start("explorer.exe", emulatorpath + @"ShortCutes");

                ICOpic.Image = null;
                Image = false;
                Edirbox.Text = emulatorpath;
                Gdirbox.Text = null;
                Shortcutbox.Text = null;
                return;
            }
        }

        private void Compile(string code, string emupath, string Filename)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            //ICodeCompiler icc = codeProvider.CreateCompiler();

            emupath += @"ShortCutes";
            if (!Directory.Exists(emupath))
                Directory.CreateDirectory(emupath);
            emupath += @"\";

            string Output = emupath + Shortcutbox.Text + ".exe";

            CompilerParameters parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll", "System.dll" })
            {
                CompilerOptions = "-win32icon:" + path + "temp.ico",
                //Make sure we generate an EXE, not a DLL
                GenerateExecutable = true,
                OutputAssembly = Output
            };
            CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, code);

            if (results.Errors.Count > 0)
            {
                string errors = null;
                foreach (CompilerError CompErr in results.Errors)
                {
                    errors = errors +
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine;
                }
                Error(errors);
            }
            else
            {
                if (DesktopCheck.Checked)
                {
                    object shDesktop = (object)"Desktop";
                    WshShell shell = new WshShell();
                    string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\" + Filename + ".lnk";
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                    shortcut.Description = "ShortCute for " + Filename;
                    shortcut.TargetPath = Output;
                    shortcut.WorkingDirectory = emupath;
                    shortcut.Save();
                }

                if (Success("Shortcut created!\nExecute shortcut?") == DialogResult.Yes)
                {
                    var starto = new Process();
                    starto.StartInfo.FileName = Output;
                    starto.StartInfo.WorkingDirectory = emupath;
                    starto.Start();
                }
            }
        }

        private string Emulator(string gamedir, string emulatordir)
        {
            string gamechecker = gamedir;

            StringComparison comp = StringComparison.OrdinalIgnoreCase;
            if (gamedir.Contains(emulatordir, comp))
            {
                gamedir = gamedir.Replace(emulatordir, @"");
                gamedir = gamedir.Replace(@"\", @"\\");
            }
            else
            {
                if (Success("Emulator and games folder must be in the same path for better working.\n\nWanna continue without the same path? (still working)", "Warning") == DialogResult.Yes)
                    gamedir = gamedir.Replace(@"\", @"\\");
                else
                    return "false";
            }

            if(emuindex == -1)
            {
                Error("Please select a emulator!");
                return "false";
            }

            string code = "using System;\n" +
                          "using System.Diagnostics;\n" +
                          "namespace Emulator_ShortCutes\n" +
                          "{\n" +
                            "class Program\n" +
                            "{\n" +
                                "static void Main()\n" +
                                "{\n" +
                                    "Console.WriteLine(\"Emulator ShortCutes UwU \\nDesign by Haruki1707.  \\nExecuting ShortCute...\");\n" +
                                    "Process ShortCute = new Process();\n" +
                                    "ShortCute.StartInfo.WorkingDirectory = \"..\\\\\";\n" +
                                    "ShortCute.StartInfo.FileName = \"..\\\\" + emus[emuindex].Exe + "\";\n" +
                                    "ShortCute.StartInfo.Arguments =" + emus[emuindex].Arguments(gamedir) + ";\n" +
                                    "ShortCute.Start();\n" + 
                                "}\n" +
                            "}\n" +
                          "}\n";

            if (!System.IO.File.Exists(emulatordir + emus[emuindex].Exe))
            {
                Error("Emulator don't exist in the specified path\nCheck if path or selected emulator is correct");
                return "false";
            }

            if (!System.IO.File.Exists(gamechecker))
            {
                Error("Game file don't exist in the specified path");
                return "false";
            }

            return code;
        }

        private void Info(string message)
        {
            MessageBox.Show(message, "Fix", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Error(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private DialogResult Success(string message, string header = "Success")
        {
            DialogResult result = MessageBox.Show(message, header, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            return result;
        }

        private void EmuBrow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (Edirbox.Text != @"")
                    dialog.InitialDirectory = Edirbox.Text;
                else
                    dialog.InitialDirectory = "C:\\";

                dialog.Filter = "Executable File (*.exe)|*.exe";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bool exists = false;
                    int currentindex = 0;
                    foreach (var emu in emus)
                    {
                        if (emu.Exe.ToLower() == dialog.SafeFileName.ToLower())
                        {
                            emulatorcb.SelectedIndex = currentindex;
                            Edirbox.Text = Path.GetDirectoryName(dialog.FileName);
                            exists = true;
                            break;
                        }
                        currentindex++;
                    }

                    if (exists == false)
                    {
                        Info("Emulator not supported yet. You can contribute to make it supported on GitHub (Haruki1707/ShortCutes repository)\n\n" +
                            "!!!Also this could appear cause you change the emulator executable name. Make sure you are using the original emulator name!!!");
                    }
                }
            }
        }

        private void GameBrow_Click(object sender, EventArgs e)
        {
            string filter;
            if (emuindex != -1)
                filter = emus[emuindex].Gamesfilters;
            else
            {
                Info("First select or browse and emulator!!!");
                return;
            }

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (Edirbox.Text != @"")
                    dialog.InitialDirectory = Edirbox.Text;
                else
                    dialog.InitialDirectory = "C:\\";

                dialog.Filter = filter;
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Gdirbox.Text = dialog.FileName;
                }
            }
        }

        private static bool Image = false;
        private void ICOpic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "Downloads");
                dialog.Filter = "PNG/JPG Image (*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ImagingHelper.ConvertToIcon(dialog.FileName, path + @"temp.ico");
                    ICOpic.Image = ImagingHelper.ICONbox;
                    Image = true;
                }
            }
        }
        private void ShortCutes_Paint(object sender, PaintEventArgs e)
        {
            Program.ToDraw(this.Controls, e);
        }

        private void notfocus_Enter(object sender, EventArgs e)
        {
            Shortcutbox.Focus();
        }
    }

    public static class StringExtensions
    {
        public static bool Contains(this String str,
                                    String substr,
                                    StringComparison cmp)
        {
            if (substr == null)
                throw new ArgumentNullException("substring substring",
                                                " cannot be null.");

            else if (!Enum.IsDefined(typeof(StringComparison), cmp))
                throw new ArgumentException("comp is not a member of",
                                            "StringComparison, comp");

            return str.IndexOf(substr, cmp) >= 0;
        }
    }
}
