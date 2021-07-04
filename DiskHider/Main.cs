using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;

namespace DiskHider
{
    public partial class Main : Form
    {
        [Flags]
        public enum DriveIds
        {
            Empty = 0,
            A = 1,
            B = 2,
            C = 4,
            D = 8,
            E = 16,
            F = 32,
            G = 64,
            H = 128,
            I = 256,
            J = 512,
            K = 1024,
            L = 2048,
            M = 4096,
            N = 8192,
            O = 16384,
            P = 32768,
            Q = 65536,
            R = 131072,
            S = 262144,
            T = 524288,
            U = 1048576,
            V = 2097152,
            W = 4194304,
            X = 8388608,
            Y = 16777216,
            Z = 33554432,
        }
        public Main()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            object value = key == null ? null : key.GetValue("NoDrives");
            DriveIds hiddenDrives = value == null ? DriveIds.Empty : (DriveIds)value;
            InitializeComponent();
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                string letter = drive.Name.Remove(1);
                bool has = hiddenDrives.HasFlag((DriveIds)Enum.Parse(hiddenDrives.GetType(), letter));
                drivesList.Items.Add(letter, has);
            }
        }
        private void applyButton_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
            DriveIds drives = DriveIds.Empty;
            foreach(string letter in drivesList.CheckedItems)
            {
                drives |= (DriveIds)Enum.Parse(drives.GetType(), letter);
            }
            key.SetValue("NoDrives", (int)drives);
            if(MessageBox.Show("Чтобы изменения вступили в силу нужно перезапустить проводник. Перезапустить проводник?", "Перезапуск проводника", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                foreach(Process p in Process.GetProcessesByName("explorer"))
                {
                    p.Kill();
                }
                Process.Start("explorer.exe");
            }
        }

        private void hideAllDrives_Click(object sender, EventArgs e)
        {
            for(int i = 0 ; i < drivesList.Items.Count ; i++)
                drivesList.SetItemChecked(i, true);
            applyButton_Click(sender, e);
        }

        private void showAllDrives_Click(object sender, EventArgs e)
        {
            for(int i = 0 ; i < drivesList.Items.Count ; i++)
                drivesList.SetItemChecked(i, false);
            applyButton_Click(sender, e);
        }
    }


    public class CommandLink : Button
    {
        const int BS_COMMANDLINK = 0x0000000E;

        public CommandLink()
        {
            FlatStyle = FlatStyle.System;
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cParams = base.CreateParams;
                cParams.Style |= BS_COMMANDLINK;
                return cParams;
            }
        }
    }
}
