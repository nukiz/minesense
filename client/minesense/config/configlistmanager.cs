using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.minesense.config
{
    public class configlistmanager
    {      
        public static void Populate(ListBox lsb, string folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(folder);
            FileInfo[] files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in files)
            {
                lsb.Items.Add(file.Name);
            }
        }
    }
}
