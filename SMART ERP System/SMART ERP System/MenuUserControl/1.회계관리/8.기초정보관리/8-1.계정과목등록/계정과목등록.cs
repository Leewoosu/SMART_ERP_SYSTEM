using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.FormHelper;

namespace SMART_ERP_System.MenuUserControl
{
    public partial class 계정과목등록 : UserControl
    {
        List<ClassLibrary.계정과목등록> MenuItems;
        public 계정과목등록()
        {
            InitializeComponent();
            treeView.SetMenuItems(out MenuItems);
        }
    }
}
