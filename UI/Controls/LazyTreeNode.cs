using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Controls
{
    public class LazyTreeNode : TreeNode
    {
        private int _id;

        public int Id 
        {
            get => _id;
            set 
            {
                // TODO: 쿼리를 통해 찾아와 자식이 있을 경우라면 더미노드를 넣어준다.
                _id = value;

                #region _id값으로 treepath에 쿼리하여 값이 있을 경우 dummynode를 삽입
                #endregion

                // TODO: 찾아온 값이 문서인지 아니면 폴더인지 '어떤' 위치에서 판단해줘야 한다.
            }
        }

        public LazyTreeNode(string text, int id) : base(text)
        {
            Id = id;
        }
    }
}
