using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robort_Reg
{
    public partial class Form1 : Form
    {
        string dekey = @"<RSAKeyValue><Modulus>zXRigE1lYYiyv6pin5nt7hxkHvbVg3kjzUQpgBN+SCqNZJ4cL03L5vo2F0/gqBds5Xq183SPbD5VD+EgRd8na1QvWypv9mjY2DHyNEBH8cndU3H5apFa3bsqa9PjupxeuGX1WLwOkkXqyoGWSoYvqlUAGIq+95/rglX3YVhX2iE=</Modulus><Exponent>AQAB</Exponent><P>8NVPzzcQUAYX5MbiKJNhzN8AOYD8T62Eb4wagjUeKXEXnn2pvtWMXv40+9HzToJqL8/7ifHn9lVtWx/vKqixFw==</P><Q>2mSz3raYQDuXm8civdBlVr+9dyqkWcqxArWPVh1UvCFuNSRFRQlSbY6rrLNmEKovWfF3fPpjCB/YhWUsUfWhhw==</Q><DP>eIZoYI1wDnxeLNITkLbhdQQNOroAi2eNJb357jvjEl5Usa616pk4nLmfjn7twtalibQOcGSt76ulBLugl7rAlQ==</DP><DQ>QU0TK2jVpX8sGfw1OyRw6Lt0X4l0kxS0UOcQ8OLcT1R/q4wo2jerWe7rDjymLB13AyHcZJZJvkgnaduSoP8dSQ==</DQ><InverseQ>m3cVbDJ2ZoFmA9ZwCCpHZXkYWlvoL02jGAe8QprocgLmGZpgOnNJEfkGaubiiRLM4roVlwpXmUfHW7ygBljdDQ==</InverseQ><D>JNa0frrh7b4cBt/fNSzdi69NiHvLxvomoDyTkGJuZzQyDBOJjDXP1MeSgVWSO7GPlgoNq+x/dvIqQGGmbsDXiUXEb/5kQt8OI37DLvZYQgly+VkiwIwyiOghy/52izxMmti/2hnre6vMWgzQy9yp4Q4AWp8rXEbLM4X/imUefB0=</D></RSAKeyValue>";

        string enkey = @"<RSAKeyValue><Modulus>w5iT80FOe4jERmTYR2rejY1V+jFHE5Sxujoa3ApLe4becAeauEfCdyv1yfNxEtFQDchXUMg+3P7xGvtkt4f785toewkMhYsrCyXsxlR5JzbTUwFvhhZEgPQmcSSK3Ugk5LWE40AihXjeCJ2G8Z4M1Tb5s+38bxZTeu7ewyNWx2k=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";




        public Form1()
        {
            InitializeComponent();
        }

        private void btn_jiemi_Click(object sender, EventArgs e)
        {
            string enstr = this.tb_jiami.Text;

           this.tb_jiemi.Text=  Winner.Framework.Encrypt.RSAProvider.Decrypt(enstr, Encoding.UTF8, false, dekey);
        }

        private void btn_jiami_Click(object sender, EventArgs e)
        {
            string enstr = this.tb_jiemi.Text;

            this.tb_jiami.Text = Winner.Framework.Encrypt.RSAProvider.Encrypt(enstr, Encoding.UTF8, false, enkey);
        }
    }
}
