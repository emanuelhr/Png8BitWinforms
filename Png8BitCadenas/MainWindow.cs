using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;


namespace Png8BitCadenas
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();          
        }

        private void listBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void listBoxFiles_DragDrop(object sender, DragEventArgs e)
        {
            lbl_dropFiles.Visible = false;
            //get all pulled folders/files
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                bool exists = false;
                if (lst_foldersFiles.Items.Count !=0)
                {
                    //loop trough each file in list and compare it with pulled files,
                    //if it is already existing dont add anything
                    foreach (var item in lst_foldersFiles.Items)
                    {
                        if (file == (string)item)
                        {
                            exists = true;                            
                        }
                                             
                    }
                    if (exists==false)
                    {
                        lst_foldersFiles.Items.Add(file);
                    }
                    else
                    {
                        MessageBox.Show("Already added", "Error");
                    }
                }
                else
                {
                    lst_foldersFiles.Items.Add(file);
                }
                
            }
        }

        private async Task ConvertAsync()
        {
            var width = Convert.ToInt32(tbox_width.Text);
            var height = Convert.ToInt32(tbox_height.Text);
            
            tbox_output.Clear();
            
            string output = "";
            var files = lst_foldersFiles.Items;
            //Add filters
            var filters = new List<string>();
            if (chk_jpg.Checked == true) filters.Add("jpg");
            if (chk_png.Checked == true) filters.Add("png");
            if (chk_bmp.Checked == true) filters.Add("bmp");
            foreach (var item in lst_formats.Items)
            {
                filters.Add(item.ToString());
            }
            //Loop trough each file/folder in drop list
            int count = 0;
            foreach (var file in files)
            {
                //if it is a directory use directory convert
                if (Directory.Exists((string)file))
                {
                    string[] allFiles = Directory.GetFiles((string)file + "\\", "*.*", SearchOption.AllDirectories);
                    var filteredList = new FilteredList(allFiles, filters);

                    foreach (var item in await filteredList.FilterPaths())
                    {
                        
                        if (await PictureManipulation.ConvertPicture(item,width,height))
                        {
                            output += "Converted: " + item + "\n";
                            count++;
                        }
                    }
                }
                //if it is a file use file convert
                if (File.Exists((string)file))
                {
                    if (await PictureManipulation.ConvertPicture((string)file, width, height))
                    {
                        output += "Converted: " + file + "\n";
                        count++;
                    }
                }
                if (output.Length == 0)
                {
                    output += "No files were converted";
                } 
            }

            tbox_output.Text = output + "\n Pictures converted: "+count;

        }




        private async void btn_convert_Click(object sender, EventArgs e)
        {
         await   Task.Factory.StartNew(() =>ConvertAsync());
         //  await ConvertAsync();
        }

        private void btn_removeFromList_Click(object sender, EventArgs e)
        {
            lst_foldersFiles.Items.Remove(lst_foldersFiles.SelectedItem);
                }

        private void btn_addFormat_Click(object sender, EventArgs e)
        {
            bool exists = false;
            foreach (var item in lst_formats.Items)
            {
                if (item.ToString() == tbox_additionalFormats.Text)
                {
                    MessageBox.Show("Format already added","Error");
                    exists = true;
                    break;
                }
            }
            if (!String.IsNullOrWhiteSpace(tbox_additionalFormats.Text) & !exists)
            {
                lst_formats.Items.Add(tbox_additionalFormats.Text);
            }
            
        }

        private void btn_removeFormat_Click(object sender, EventArgs e)
        {
            lst_formats.Items.Remove(lst_formats.SelectedItem);
        }

        private void tbox_width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tbox_width.Text.Length > 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbox_height_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (tbox_height.Text.Length > 3 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbl_repotBug_Click(object sender, EventArgs e)
        {
            string email = "e.hrskanovic@cadenas.de";

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = $"mailto:{email}?subject=Png8Bit bug&body=";
            proc.Start();
        }

    }
}
