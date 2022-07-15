using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemVisitor
{
    public partial class FileSystemVisitorForm : Form
    {
        FileSystemVisitor _visitor;
        string _path;
        public FileSystemVisitorForm()
        {
            InitializeComponent();
        }
        private void FolderChooseButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    _path = fbd.SelectedPath;
                    ShowAllFilesAndFolders(_path);
                }
            }
        }

        void CreateFileSystemVisitor()
        {
            var pattern = textBox.Text;
            _visitor = string.IsNullOrWhiteSpace(pattern)
                        ? new FileSystemVisitor()
                        : new FileSystemVisitor(path =>
                        {
                            var regex = new Regex(pattern);
                            return regex.IsMatch(path);
                        });

            _visitor.TraversionStatusEventHandler += UpdatedTraversionStatusEventHandler;
        }

        private void ShowAllFilesAndFolders(string path)
        {
            fileSystemPanel.Controls.Clear();
            UpdateChosenFolderText(path);
            CreateFileSystemVisitor();
            var fileSystemEntries = _visitor.GetFileSystemEntries(path);
            fileSystemPanel.Controls.AddRange(fileSystemEntries.Select(x => new Label()
            {
                Text = x,
                AutoSize = true
            }).ToArray());
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_path))
                ShowAllFilesAndFolders(_path);
        }

        private void UpdateChosenFolderText(string path)
        {
            chosenFolder.Text = path;
            chosenFolder.Visible = true;
        }

        private void UpdatedTraversionStatusEventHandler(object sender, TraversionStatusEventArgs e)
        {
            traversionStatusMessage.Text = e.Message;
            traversionStatusFiles.Text = e.FoundFiles;
            Refresh();
        }
    }
}
