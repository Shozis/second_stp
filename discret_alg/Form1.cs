using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discret_alg
{
    public partial class Form1 : Form
    {

        int[] a = {0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1};
        int[] b = {0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1};
        int[] c = {0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1};
        int[] d = {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1};

        int[] aub = new int[16];
        int[] anb = new int[16];

        int[] auc = new int[16];
        int[] anc = new int[16];

        int[] aud = new int[16];
        int[] and = new int[16];

        int[] buc = new int[16];
        int[] bnc = new int[16];

        int[] bud = new int[16];
        int[] bnd = new int[16];

        int[] cud = new int[16];
        int[] cnd = new int[16];


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             for(int i = 0; i < a.Length; i++)
             {
                aub[i] = checkElement(a[i] + b[i]);
             }

             for(int i = 0; i < aub.Length; i++)
             {
                listBox1.Items.Add(aub[i]);
             }
            
        }

        static int checkElement(int i)
        {
            if (i > 1)
            {
                i = 1;
            }
           return i;
        }
    }
}
