using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form3 : Form
    {

        List<string> _ogrenciler;
        public Form3(List<string> ogrenciler)
        {
            InitializeComponent();
            _ogrenciler = ogrenciler;
            foreach (string ogrenci in _ogrenciler)
            {
                ogrenciListesi.Items.Add(ogrenci);
            }
            
        }
        
    }
}
