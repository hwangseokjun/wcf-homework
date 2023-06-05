using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Models;

namespace UI.UserControls
{
    public partial class TreeUserControl : UserControl
    {
        public TreePath TreePath { get; set; }

        public TreeUserControl()
        {
            InitializeComponent();
            // 필요하다면 각 노드에 더미데이터를 집어넣는다.
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // 더미 데이터를 삭제한다.
            // 노드를 새롭게 생성해 넣어주고 펼친다.
            // 새롭게 생성된 각 노드에 필요하다면 더미데이터를 집어넣는다.
            // 캐싱을 통해 두 번 작동하지 않도록 처리가 필요하다.
        }
    }
}
