using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HtmlCssAspKontrolleri.Asp_Kontrolleri
{
    public partial class textBoxKontrolu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_tikla_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text="Yazdığınız Şey: " + tb_metin.Text;
        }
    }
}