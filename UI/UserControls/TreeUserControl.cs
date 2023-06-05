using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Controls;

namespace UI.UserControls
{
    public partial class TreeUserControl : UserControl
    {
        public TreeUserControl()
        {
            InitializeComponent();
            // 필요하다면 각 노드에 더미데이터를 집어넣어 준다.
            // 각 노드에 이벤트를 할당하여 실행시켜야 함.

            #region 테스트용으로 노드 집어넣기
            treeView.Nodes.Add(new LazyTreeNode("2021년", 0));
            treeView.Nodes.Add(new LazyTreeNode("2021년", 1));
            treeView.Nodes.Add(new LazyTreeNode("2021년", 2));
            treeView.Nodes.Add(new LazyTreeNode("2021년", 3));
            
            treeView.Nodes[0].Nodes.Add("1월");
            treeView.Nodes[0].Nodes.Add("2월");
            treeView.Nodes[0].Nodes.Add("5월");

            treeView.Nodes[1].Nodes.Add("3월");
            treeView.Nodes[1].Nodes.Add("7월");
            treeView.Nodes[1].Nodes.Add("12월");

            treeView.Nodes[2].Nodes.Add(new DummyTreeNode());
            #endregion

            #region 1. 강재성적서가 등록된 각 연도를 검색해와 컨트롤로 추가 필요
            #endregion
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0] is DummyTreeNode) 
            {
                e.Node.Nodes.Clear();
                int id = ((LazyTreeNode)e.Node).Id;
                // TODO: WCF 서비스를 통해 필요한 데이터를 찾아와 삽입해준다.
            }
        }

        private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = IconType.Opened;
            e.Node.SelectedImageIndex = IconType.Opened;
        }

        private void treeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = IconType.Closed;
            e.Node.SelectedImageIndex = IconType.Closed;
        }
    }
}
