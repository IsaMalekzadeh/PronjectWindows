using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsProjectIsa
{
    public partial class frmKortingRunner : Form
    {
        Business _business = new Business();
        
        public frmKortingRunner()
        {
            InitializeComponent();
        }

        private void frmGOKMAARRAAK_Load(object sender, EventArgs e)
        {
            //het vals spelen onmogelijk maken
            pic3.Enabled = false;
            pic4.Enabled = false;
            pic5.Enabled = false;
            pic6.Enabled = false;
            pic7.Enabled = false;
            pic8.Enabled = false;
            pic9.Enabled = false;
            pic10.Enabled = false;
            picEindPlatform.Enabled = false;
        }

        //hoe spelen
        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Onderaan ziet u 10 platformen, de korting runner begint helemaal links. Telkens hebt u 2 platformen om van te kiezen. Kiest u het juiste platform dan zal de korting runner verder kunnen gaan. Kiest u het foute platform dan zal de korting runner tot zijn dood vallen en eindigt het spel.");
        }

        //tegels juiste commando's geven om te kunnen spelen
        private void pic1_Click(object sender, EventArgs e)
        {
            _business.Generator();
            if (1 == _business.V1)
            {
                _business.Korting = _business.Korting + 2;
                picStand1.Visible = true;
                picStandstart.Visible = false;
                pic1.Image = Properties.Resources.green;
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic3.Enabled = true;
                pic4.Enabled = true;

            }
            else
            {
                picStandstart.Visible = false;
                pic1.Visible = false;
                pic2.Visible = false;
                picfall1.Visible = true;
                MessageBox.Show("Jammer genoeg eindigt het spel hier voor u. Toch krijgt u " + _business.Korting + "% korting.");
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            _business.Generator();
            if (2 == _business.V2)
            {
                _business.Korting = _business.Korting + 2;
                picStand2.Visible = true;
                picStandstart.Visible = false;
                pic2.Image = Properties.Resources.green;
                pic1.Enabled = false;
                pic2.Enabled = false;
                pic3.Enabled = true;
                pic4.Enabled = true;
            }
            else
            {
                picStandstart.Visible = false;
                pic1.Visible = false;
                pic2.Visible = false;
                picfall2.Visible = true;
                MessageBox.Show("Jammer genoeg eindigt het spel hier voor u. Toch krijgt u " + _business.Korting + "% korting.");
            }
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            _business.Generator();
            if (1 == _business.V3)
            {
                _business.Korting = _business.Korting + 2;
                picStand3.Visible = true;
                picStand1.Visible = false;
                picStand2.Visible = false;
                pic3.Image = Properties.Resources.green;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = true;
                pic6.Enabled = true;
            }
            else
            {
                picStand1.Visible = false;
                picStand2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                picfall3.Visible = true;
                MessageBox.Show("Jammer genoeg eindigt het spel hier voor u. Toch krijgt u " + _business.Korting + "% korting.");
            }

        }

        private void pic4_Click(object sender, EventArgs e)
        {
            _business.Generator();
            if (2 == _business.V4)
            {
                _business.Korting = _business.Korting + 2;
                picStand4.Visible = true;
                picStand1.Visible = false;
                picStand2.Visible = false;
                pic4.Image = Properties.Resources.green;
                pic3.Enabled = false;
                pic4.Enabled = false;
                pic5.Enabled = true;
                pic6.Enabled = true;
            }
            else
            {
                picStand1.Visible = false;
                picStand2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                picfall4.Visible = true;
                MessageBox.Show("Jammer genoeg eindigt het spel hier voor u. Toch krijgt u " + _business.Korting + "% korting.");
            }
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            _business.Generator();
            if (1 == _business.V5)
            {
                _business.Korting = _business.Korting + 2;
                picStand5.Visible = true;
                picStand3.Visible = false;
                picStand4.Visible = false;
                pic5.Image = Properties.Resources.green;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = true;
                pic8.Enabled = true;
            }
            else
            {
                picStand3.Visible = false;
                picStand4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                picfall5.Visible = true;
                MessageBox.Show("Jammer genoeg eindigt het spel hier voor u. Toch krijgt u " + _business.Korting + "% korting.");
            }
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            _business.Generator();
            if (2 == _business.V6)
            {
                _business.Korting = _business.Korting + 2;
                picStand6.Visible = true;
                picStand3.Visible = false;
                picStand4.Visible = false;
                pic6.Image = Properties.Resources.green;
                pic5.Enabled = false;
                pic6.Enabled = false;
                pic7.Enabled = true;
                pic8.Enabled = true;
            }
            else
            {
                picStand3.Visible = false;
                picStand4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                picfall6.Visible = true;
                MessageBox.Show("Jammer genoeg eindigt het spel hier voor u. Toch krijgt u " + _business.Korting + "% korting.");
            }
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            _business.Generator();
            if (1 == _business.V7)
            {
                _business.Korting = _business.Korting + 2;
                picStand7.Visible = true;
                picStand5.Visible = false;
                picStand6.Visible = false;
                pic7.Image = Properties.Resources.green;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = true;
                pic10.Enabled = true;
            }
            else
            {
                picStand5.Visible = false;
                picStand6.Visible = false;
                pic7.Visible = false;
                pic8.Visible = false;
                picfall7.Visible = true;
                MessageBox.Show("Jammer genoeg eindigt het spel hier voor u. Toch krijgt u " + _business.Korting + "% korting.");
            }
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            _business.Generator();
            if (2 == _business.V8)
            {
                _business.Korting = _business.Korting + 2;
                picStand8.Visible = true;
                picStand5.Visible = false;
                picStand6.Visible = false;
                pic8.Image = Properties.Resources.green;
                pic7.Enabled = false;
                pic8.Enabled = false;
                pic9.Enabled = true;
                pic10.Enabled = true;
            }
            else
            {
                picStand5.Visible = false;
                picStand6.Visible = false;
                pic7.Visible = false;
                pic8.Visible = false;
                picfall8.Visible = true;
                MessageBox.Show("Jammer genoeg eindigt het spel hier voor u. Toch krijgt u " + _business.Korting + "% korting.");
            }
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            _business.Generator();
            if (1 == _business.V9)
            {
                _business.Korting = _business.Korting + 2;
                picStand9.Visible = true;
                picStand7.Visible = false;
                picStand8.Visible = false;
                pic9.Image = Properties.Resources.green;
                pic9.Enabled = false;
                pic10.Enabled = false;
                picEindPlatform.Enabled = true;
            }
            else
            {
                picStand7.Visible = false;
                picStand8.Visible = false;
                pic9.Visible = false;
                pic10.Visible = false;
                picfall9.Visible = true;
                MessageBox.Show("Jammer genoeg eindigt het spel hier voor u. Toch krijgt u " + _business.Korting + "% korting.");
            }
        }

        private void pic10_Click(object sender, EventArgs e)
        {
            _business.Generator();
            if (2 == _business.V10)
            {

                _business.Korting = _business.Korting + 2;
                picStand10.Visible = true;
                picStand7.Visible = false;
                picStand8.Visible = false;
                pic10.Image = Properties.Resources.green;
                pic9.Enabled = false;
                pic10.Enabled = false;
                picEindPlatform.Enabled = true;
                
            }
            else
            {
                picStand7.Visible = false;
                picStand8.Visible = false;
                pic9.Visible = false;
                pic10.Visible = false;
                picfall10.Visible = true;
                MessageBox.Show("Jammer genoeg eindigt het spel hier voor u. Toch krijgt u " + _business.Korting + "% korting.");
            }
        }

        //eindplatform speelbaar maken
        private void picEindPlatform_Click(object sender, EventArgs e)
        {
            picStand9.Visible = false;
            picStand10.Visible = false;
            picStandFinish.Visible = true;
            MessageBox.Show("WOOW u bent tot het einde geraakt, u zal 12% korting krijgen. Of u kunt voor de double or nothing gaan.\nKlik op 'ok' om verder te gaan.");
            btn2x.Visible = true;
            
        }

        //tweemaal zichbaar maken
        private void btn2x_Click(object sender, EventArgs e)
        {
            _business.Generator();
            if (1 == _business.tweemaal)
            {
                MessageBox.Show("WOOOOOW u hebt heel veel geluk!!! U hebt wel liefst 24% korting gekregen!!!");
            }
            else
            {
                MessageBox.Show("Sorry maar u bent verloren. U zal geen korting krijgen.");
            }
            btn2x.Enabled = false;
        }

        

        private void btnrestart_Click(object sender, EventArgs e)
        {
            _business.Korting = 2;
            btn2x.Visible = false;
            //terug op start staan
            picStartPlatform.Visible = false;
            //finish staan weg
            picEindPlatform.Visible = false;
            //staande plekken
            picStandstart.Visible = true;
            picStand1.Visible = false;
            picStand2.Visible = false;
            picStand3.Visible = false;
            picStand4.Visible = false;
            picStand5.Visible = false;
            picStand6.Visible = false;
            picStand7.Visible = false;
            picStand8.Visible = false;
            picStand9.Visible = false;
            picStand10.Visible = false;
            picStandFinish.Visible = false;
            //vallende plekken
            picfall1.Visible = false;
            picfall2.Visible = false;
            picfall3.Visible = false;
            picfall4.Visible = false;
            picfall5.Visible = false;
            picfall6.Visible = false;
            picfall7.Visible = false;
            picfall8.Visible = false;
            picfall9.Visible = false;
            picfall10.Visible = false;
            //alle plekken terug oranje
            pic1.Image = Properties.Resources.Orange;
            pic2.Image = Properties.Resources.Orange;
            pic3.Image = Properties.Resources.Orange;
            pic4.Image = Properties.Resources.Orange;
            pic5.Image = Properties.Resources.Orange;
            pic6.Image = Properties.Resources.Orange;
            pic7.Image = Properties.Resources.Orange;
            pic8.Image = Properties.Resources.Orange;
            pic9.Image = Properties.Resources.Orange;
            pic10.Image = Properties.Resources.Orange;
            //alle plekken zichtbaar maken
            pic1.Visible = true;
            pic2.Visible = true;
            pic3.Visible = true;
            pic4.Visible = true;
            pic5.Visible = true;
            pic6.Visible = true;
            pic7.Visible = true;
            pic8.Visible = true;
            pic9.Visible = true;
            pic10.Visible = true;
            picStartPlatform.Visible = true;
            picEindPlatform.Visible = true;
            //Er voor zorgen dat ze niet kunnen cheaten
            pic3.Enabled = false;
            pic4.Enabled = false;
            pic5.Enabled = false;
            pic6.Enabled = false;
            pic7.Enabled = false;
            pic8.Enabled = false;
            pic9.Enabled = false;
            pic10.Enabled = false;
            picEindPlatform.Enabled = false;
            pic1.Enabled = true;
            pic2.Enabled = true;
            //tweemaal weer activeren
            btn2x.Enabled = true;
        }

        private void lblF3_Click(object sender, EventArgs e)
        {

        }

        private void lblF5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
