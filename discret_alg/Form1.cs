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



        int[] _a = new int[16];
        int[] _b = new int[16];
        int[] _c = new int[16];
        int[] _d = new int[16];



        int[] aub = new int[16];
        int[] anb = new int[16];
        int[] aBb = new int[16];
        int[] aUBb = new int[16];

        int[] auc = new int[16];
        int[] anc = new int[16];
        int[] aBc = new int[16];
        int[] aUBc = new int[16];

        int[] aud = new int[16];
        int[] and = new int[16];
        int[] aBd = new int[16];
        int[] aUBd = new int[16];

        int[] buc = new int[16];
        int[] bnc = new int[16];
        int[] bBc = new int[16];
        int[] bUBc = new int[16];

        int[] bud = new int[16];
        int[] bnd = new int[16];
        int[] bBd = new int[16];
        int[] bUBd = new int[16];

        int[] cud = new int[16];
        int[] cnd = new int[16];
        int[] cBd = new int[16];
        int[] cUBd = new int[16];


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button1.BackColor = Color.DarkRed;




            for(int i = 0; i < a.Length; i++)
            {
                _a[i] = revers(a[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox7.Items.Add(_a[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                _b[i] = revers(b[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox8.Items.Add(_b[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                _c[i] = revers(c[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox9.Items.Add(_c[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                _d[i] = revers(d[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox10.Items.Add(_d[i]);
            }



            for (int i = 0; i < a.Length; i++)
             {
                aub[i] = checkElement(a[i] + b[i]);
             }

             for(int i = 0; i < a.Length; i++)
             {
                listBox1.Items.Add(aub[i]);
             }


            for (int i = 0; i < a.Length; i++)
            {
                anb[i] = equally(a[i], b[i], anb[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox2.Items.Add(anb[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                aBb[i] = both(a[i], b[i], aBb[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox3.Items.Add(aBb[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                aUBb[i] = unboth(a[i], b[i], aUBb[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox4.Items.Add(aUBb[i]);
            }



            for (int i = 0; i < a.Length; i++)
            {
                auc[i] = checkElement(a[i] + c[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox5.Items.Add(auc[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                anc[i] = equally(a[i], c[i], anc[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox6.Items.Add(anc[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                aBc[i] = both(a[i], b[i], aBc[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox11.Items.Add(aBc[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                aUBc[i] = unboth(a[i], b[i], aUBc[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox12.Items.Add(aUBc[i]);
            }



            for (int i = 0; i < a.Length; i++)
            {
                aud[i] = checkElement(a[i] + d[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox13.Items.Add(aud[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                and[i] = equally(a[i], c[i], and[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox14.Items.Add(and[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                aBd[i] = both(a[i], b[i], aBd[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox15.Items.Add(aBd[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                aUBd[i] = unboth(a[i], b[i], aUBd[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox16.Items.Add(aUBd[i]);
            }



            for (int i = 0; i < a.Length; i++)
            {
                buc[i] = checkElement(b[i] + c[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox17.Items.Add(buc[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                bnc[i] = equally(a[i], c[i], bnc[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox18.Items.Add(bnc[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                bBc[i] = both(a[i], b[i], bBc[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox19.Items.Add(bBc[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                bUBc[i] = unboth(a[i], b[i], bUBc[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox20.Items.Add(bUBc[i]);
            }



            for (int i = 0; i < a.Length; i++)
            {
                bud[i] = checkElement(b[i] + d[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox21.Items.Add(bud[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                bnd[i] = equally(a[i], c[i], bnd[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox22.Items.Add(bnd[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                bBd[i] = both(a[i], b[i], bBd[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox23.Items.Add(bBd[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                bUBd[i] = unboth(a[i], b[i], bUBd[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox24.Items.Add(bUBd[i]);
            }



            for (int i = 0; i < a.Length; i++)
            {
                cud[i] = checkElement(c[i] + d[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox25.Items.Add(cud[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                cnd[i] = equally(a[i], c[i], cnd[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox26.Items.Add(cnd[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                cBd[i] = both(a[i], b[i], cBd[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox27.Items.Add(cBd[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                cUBd[i] = unboth(a[i], b[i], cUBd[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                listBox28.Items.Add(cUBd[i]);
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

        static int revers(int i)
        {
            if (i < 1)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            return i;
        }

        
        public int both(int a, int b, int ab)
        {
                if (a == b)
            {
                    ab = 1;
                }
                else
                {
                    ab = 0;
                }

            return ab;
        }

        public int unboth(int a, int b, int ab)
        {
            if (a == b)
            {
                ab = 0;
            }
            else
            {
                ab = 1;
            }

            return ab;
        }

        public int equally(int a, int b, int ab)
        {
            
                if (a == 1 && b == 1)
                {
                    ab = 1;
                }
                else
                {
                    ab = 0;
                }
             return ab;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void listBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aa = Convert.ToInt32(textBox1.Text);
            int bb = Convert.ToInt32(textBox2.Text);
            int cc = Convert.ToInt32(textBox3.Text);
            int dd = Convert.ToInt32(textBox4.Text);


            int _aa = revers(aa);
            int _bb = revers(bb);
            int _cc = revers(cc);
            int _dd = revers(dd);

            textBox29.Text = _aa.ToString();
            textBox30.Text = _bb.ToString();
            textBox31.Text = _cc.ToString();
            textBox32.Text = _dd.ToString();


            int aaubb = checkElement(aa + bb);
            int aaucc = checkElement(aa + cc);
            int aaudd = checkElement(aa + dd);
            int bbucc = checkElement(bb + cc);
            int bbudd = checkElement(bb + dd);
            int ccudd = checkElement(cc + dd);

            textBox5.Text = aaubb.ToString();
            textBox9.Text = aaucc.ToString();
            textBox13.Text = aaudd.ToString();
            textBox17.Text = bbucc.ToString();
            textBox21.Text = bbucc.ToString();
            textBox25.Text = ccudd.ToString();


            int aanbb = 0;
            int aancc = 0;
            int aandd = 0;
            int bbncc = 0;
            int bbndd = 0;
            int ccndd = 0;

            aanbb = equally(aa, bb, aanbb);
            aancc = equally(aa, bb, aancc);
            aandd = equally(aa, bb, aandd);
            bbncc = equally(aa, bb, bbncc);
            bbndd = equally(aa, bb, bbndd);
            ccndd = equally(aa, bb, ccndd);

            textBox6.Text = aanbb.ToString();
            textBox10.Text = aancc.ToString();
            textBox14.Text = aandd.ToString();
            textBox18.Text = bbncc.ToString();
            textBox22.Text = bbncc.ToString();
            textBox26.Text = ccndd.ToString();


            int aaBbb = 0;
            int aaBcc = 0;
            int aaBdd = 0;
            int bbBcc = 0;
            int bbBdd = 0;
            int ccBdd = 0;

            aaBbb = both(aa, bb, aaBbb);
            aaBcc = both(aa, bb, aaBcc);
            aaBdd = both(aa, bb, aaBdd);
            bbBcc = both(aa, bb, bbBcc);
            bbBdd = both(aa, bb, bbBdd);
            ccBdd = both(aa, bb, ccBdd);

            textBox7.Text = aaBbb.ToString();
            textBox11.Text = aaBcc.ToString();
            textBox15.Text = aaBdd.ToString();
            textBox19.Text = bbBcc.ToString();
            textBox23.Text = bbBdd.ToString();
            textBox27.Text = ccBdd.ToString();


            int aaUBbb = 0;
            int aaUBcc = 0;
            int aaUBdd = 0;
            int bbUBcc = 0;
            int bbUBdd = 0;
            int ccUBdd = 0;

            aaUBbb = unboth(aa, bb, aaUBbb);
            aaUBcc = unboth(aa, bb, aaUBcc);
            aaUBdd = unboth(aa, bb, aaUBdd);
            bbUBcc = unboth(aa, bb, bbUBcc);
            bbUBdd = unboth(aa, bb, bbUBdd);
            ccUBdd = unboth(aa, bb, ccUBdd);

            textBox8.Text = aaUBbb.ToString();
            textBox12.Text = aaUBcc.ToString();
            textBox16.Text = aaUBdd.ToString();
            textBox20.Text = bbUBcc.ToString();
            textBox24.Text = bbUBdd.ToString();
            textBox28.Text = ccUBdd.ToString();
        }

        private void listBox36_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label135_Click(object sender, EventArgs e)
        {

        }
    }
}
