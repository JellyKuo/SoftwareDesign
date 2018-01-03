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
            // TODO
            XmlNode xmlNode;
            // 使用FileStream讀取XML文件books.xml
            // TODO
            // 將XML文件載入XmlDocment物件xmldoc
            // TODO            
            treeView1.Nodes.Clear();
            // 新增TreeView控制項的根元素，即library
            treeView1.Nodes.Add(// TODO);
            // 取得XML文件的所有book子元素
            xmlNode = // TODO
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
                    xNode = // TODO
                    // 新增TreeView控制項的節點名稱
                    treeNode.Nodes.Add(new TreeNode(// TODO));
                    // 取得TreeNode物件 
                    tNode = treeNode.Nodes[i];
                    AddNode(xNode, tNode);  // 呼叫遞迴函數
                }
            }
            else
            {
                // 沒有子節點，取得節點的文字內容
                treeNode.Text = // TODO
            }
        }
    }
}
