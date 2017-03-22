using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using IPlug;
using System.Text.RegularExpressions;

namespace PlugsInstance
{
    public partial class WindowForm : Form
    {
        public WindowForm()
        {
            InitializeComponent();
        }

        private void WindowForm_Load(object sender, EventArgs e)
        {
           LoadPlugs();
        }


        private void menuSystemNew_Click(object sender, EventArgs e)
        {
            txtContent.Text = "";
        } 


        #region Load
        private void LoadPlugs()
        {
            string currentPath = Application.StartupPath.TrimEnd('\\');
            string plugsPath = currentPath + "\\Plugs";
            if (!Directory.Exists(plugsPath))
            {
                return;
            }
            string[] plugsList = Directory.GetFiles(plugsPath, "*.dll");
            Type iplus = typeof(IPlugs);
            foreach (var item in plugsList)
            {
                Assembly ass = Assembly.LoadFrom(item);

                Type[] tList = ass.GetExportedTypes();

                foreach (Type t in tList)
                {
                    if (!iplus.IsAssignableFrom(t))
                    {
                        continue;
                    }
                    object[] attr = t.GetCustomAttributes(typeof(IPlug.PlugsNameAttribute), true);
                    ToolStripMenuItem menu = new ToolStripMenuItem();
                    if (attr != null && attr.Length > 0)
                    {
                        PlugsNameAttribute plugsAttr = attr[0] as PlugsNameAttribute;
                        menu.Text = plugsAttr.Name;
                    }
                    else
                    {
                        menu.Text = t.Name;
                    }
                    menu.Click += new EventHandler(menu_Click);
                    IPlugs Instance = Activator.CreateInstance(t) as IPlugs;
                    menu.Tag = Instance;
                    MenuExtent.DropDownItems.Add(menu);

                }
            }
        }


        void menu_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            IPlugs plugs = menu.Tag as IPlugs;
            this.txtContent.Text = plugs.ProcessText(this.txtContent.Text);
        }
        #endregion

    }
}
