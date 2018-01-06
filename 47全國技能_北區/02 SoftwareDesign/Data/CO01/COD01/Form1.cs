using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO; 

namespace COD01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 建立XmlDocment物件xmldoc
            var ofd = new OpenFileDialog()
            {
                Filter="XML File(*.xml)|*.xml"
            };
            if (ofd.ShowDialog()!=DialogResult.OK)
            {
                return;
            }
            var xmldoc = new XmlDocument();
            xmldoc.Load(ofd.FileName);

            XmlNode xmlNode;
            // 使用FileStream讀取XML文件books.xml
            // 將XML文件載入XmlDocment物件xmldoc
            treeView1.Nodes.Clear();
            // 新增TreeView控制項的根元素，即library
            treeView1.Nodes.Add(new TreeNode(xmldoc.DocumentElement.Name));
            // 取得XML文件的所有book子元素
            xmlNode = xmldoc.DocumentElement;
            TreeNode treeNode;
            treeNode = treeView1.Nodes[0];
            // 呼叫遞迴函數來新增節點
            AddNode(xmlNode, treeNode);
        }

        private void AddNode(XmlNode xmlNode, TreeNode treeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i = 0;
            if (xmlNode.HasChildNodes)  // 是否有子節點
            {
                // 取得子節點清單的XmlNodeList物件
                nodeList = xmlNode.ChildNodes;
                // 一一取出XmlNodeList物件的節點
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    // 取得每一個子節點XmlNode物件
                    xNode = nodeList[i];
                    // 新增TreeView控制項的節點名稱
                    treeNode.Nodes.Add(new TreeNode(xNode.Name));
                    // 取得TreeNode物件 
                    tNode = treeNode.Nodes[i];
                    AddNode(xNode, tNode);  // 呼叫遞迴函數
                }
            }
            else
            {
                // 沒有子節點，取得節點的文字內容
                treeNode.Text = xmlNode.Value;
            }
        }

        private void upBtn_Click(object sender, EventArgs e)
        {
            var sel = treeView1.SelectedNode;
            if (sel.Text != "book")
            {
                MessageBox.Show("選擇的節點不是書!");
                return;
            }
            //TODO Error Handling
            var selInd = treeView1.Nodes[0].Nodes.IndexOf(sel);
            var upNode = treeView1.Nodes[0].Nodes[selInd - 1];
            treeView1.Nodes[0].Nodes.RemoveAt(selInd - 1);
            treeView1.Nodes[0].Nodes.RemoveAt(selInd-1);
            treeView1.Nodes[0].Nodes.Insert(selInd - 1, sel);
            treeView1.Nodes[0].Nodes.Insert(selInd, upNode);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text != "book")
            {
                upBtn.Enabled = false;
                downBtn.Enabled = false;
                delBtn.Enabled = false;
                return;
            }
            else
            {
                upBtn.Enabled = true;
                downBtn.Enabled = true;
                delBtn.Enabled = true;
            }
            if (treeView1.Nodes[0].Nodes.IndexOf(treeView1.SelectedNode) == 0)
            {
                upBtn.Enabled = false;
            }
            else
            {
                upBtn.Enabled = true;
            }
            if (treeView1.Nodes[0].Nodes.IndexOf(treeView1.SelectedNode) == treeView1.Nodes[0].Nodes.Count-1)
            {
                downBtn.Enabled = false;
            }
            else
            {
                downBtn.Enabled = true;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode.Text != "book")
            {
                MessageBox.Show("請選擇一本書!");
                return;
            }
            if(MessageBox.Show(string.Format("確定要移除  {0}({1}) 的書嗎?", treeView1.SelectedNode.Nodes[1].Nodes[0].Text, treeView1.SelectedNode.Nodes[0].Nodes[0].Text),"確定",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) ==DialogResult.OK)
             treeView1.SelectedNode.Remove();
            else return;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                Filter = "XML File (*.xml)|*.xml"
            };
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            var xmldoc = new XmlDocument();
            xmldoc.Load(ofd.FileName);
            XmlNode xNode = xmldoc.DocumentElement;
           
            
        }
    }
}
