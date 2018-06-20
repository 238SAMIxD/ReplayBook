﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROFLPlayer.Lib
{
    public class MainWindowManager
    {
        public static void Load(Form form)
        {
            form.Controls.Find("GeneralGameTextBox", true)[0].Text = RoflSettings.Default.LoLExecLocation;
        }

        public static void CloseWindow(Form form)
        {
            // Save and Exit form
            RoflSettings.Default.LoLExecLocation = form.Controls.Find("GeneralGameTextBox", true)[0].Text;
            RoflSettings.Default.Save();
            Environment.Exit(1);
        }

        public static string ShowFileDialog()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Executable files (*.exe)|*.exe";
            dialog.Multiselect = false;
            dialog.Title = "Select League of Legends executable";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
