using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TICKER_TALLY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 0;
        //int b = 0;
        int i = 0;

        static int selectedIndex = 0;

        VizCon vc = new VizCon();
        public void getVizHost()
        {
            var dbName = ConfigurationManager.AppSettings.AllKeys.Where(key => key.StartsWith("VIZ")).Select(key => ConfigurationManager.AppSettings[key]).ToArray();
            cmbVizHost.Items.AddRange(dbName);
            cmbVizHost.SelectedIndex = 0;
        }

        public void getStates()
        {

            string con = ConfigurationManager.AppSettings[tbServerName.Text];
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            SqlCommand cmd = new SqlCommand("select  distinct STATE_ID,STATE_NAME_BENGALI, STOTAL,SPARTY_NO from TBL_ALI_TALLY order by STATE_ID", mycon);
            SqlDataReader myReader = cmd.ExecuteReader();
            listState.Items.Clear();
            while (myReader.Read())
            {
                string scode = myReader.GetString(0);
                string sname = myReader.GetString(1);
                string stotal = myReader.GetString(2).ToString();
                string spartyno = myReader.GetString(3);
                string cmdval = scode + " | " + sname + " | " + stotal + " | " + spartyno;
                listState.Items.Add(cmdval);
            }
            mycon.Close();

        }

        public void getSatateTally()
        {

            string con = ConfigurationManager.AppSettings[tbServerName.Text];
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            SqlCommand cmd = new SqlCommand("SELECT STATE_NAME,SALLIANCE,SEATS,SORT_ID,SPARTY_NO FROM TBL_ALI_TALLY WHERE STATE_ID='" + tbID.Text + "' order by SORT_ID", mycon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvStateTally.DataSource = dt;
            mycon.Close();

        }

        public void getZone3Data()
        {

            string con = ConfigurationManager.AppSettings["DB1"];
            SqlConnection mycon = new SqlConnection(con);
            mycon.Open();
            SqlCommand cmd = new SqlCommand("select upper(state_name) as STATE ,upper(acname) as CONSTITUENCY,party_name as PNAME,candidate_name as CANDIDATE,status STATUS from constituency_updates where STATUS='LEAD'", mycon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvZone3.DataSource = dt;
            mycon.Close();

        }

        public void scrollNext()
        {

            tbZone3State.Text = dgvZone3.Rows[i].Cells[0].Value.ToString();
            tbZone3Cname.Text = dgvZone3.Rows[i].Cells[1].Value.ToString();
            tbZone3Pname.Text = dgvZone3.Rows[i].Cells[2].Value.ToString();
            tbZone3CandName.Text = dgvZone3.Rows[i].Cells[3].Value.ToString();
            tbZone3Status.Text = dgvZone3.Rows[i].Cells[4].Value.ToString();

        }


        public void SendZone3Data()

        {
            string myip = tbIP.Text;
            string dpcmd = "0 RENDERER*FUNCTION*DataPool*Data SET ";
            string zone3sel = dpcmd + "selcat = 1 ";
            string zone3cname = dpcmd + "cname = " + tbZone3Cname.Text + "(" + tbZone3State.Text + ")";
            string zone3Candinfo = dpcmd + "candinfo= " + tbZone3Pname.Text + " - " + tbZone3CandName.Text + " " + "(" + tbZone3Status.Text + ")";
            //string dircmd = "0 RENDERER*STAGE*DIRECTOR*ZONE_3 START";

            string zone3cmd = zone3sel + ";" + zone3cname + ";" + zone3Candinfo;
            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*ZONE_3*ACTION*TRIGGER*KEY*$zone3*VALUE SET " + zone3cmd);
            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*ZONE_3 START");

        }

        public void FillBoxes()
        {
            //tbParty1.Text = "";
            //tbParty2.Text = "";
            //tbParty3.Text = "";
            //tbParty4.Text = "";
            //tbParty5.Text = "";

            //tbSeats1.Text = "0";
            //tbSeats2.Text = "0";
            //tbSeats3.Text = "0";
            //tbSeats4.Text = "0";
            //tbSeats5.Text = "0";
            //tbSTotal.Text = "0";

            if (tbPartyNo.Text == "5")
            {
                tbParty1.Text = dgvStateTally.Rows[0].Cells[1].Value.ToString();
                tbParty2.Text = dgvStateTally.Rows[1].Cells[1].Value.ToString();
                tbParty3.Text = dgvStateTally.Rows[2].Cells[1].Value.ToString();
                tbParty4.Text = dgvStateTally.Rows[3].Cells[1].Value.ToString();
                tbParty5.Text = dgvStateTally.Rows[4].Cells[1].Value.ToString();
                tbParty5.Enabled = true;
                tbParty4.Enabled = true;
                tbParty6.Enabled = false;

                tbSeats1.Text = dgvStateTally.Rows[0].Cells[2].Value.ToString();
                tbSeats2.Text = dgvStateTally.Rows[1].Cells[2].Value.ToString();
                tbSeats3.Text = dgvStateTally.Rows[2].Cells[2].Value.ToString();
                tbSeats4.Text = dgvStateTally.Rows[3].Cells[2].Value.ToString();
                tbSeats5.Text = dgvStateTally.Rows[4].Cells[2].Value.ToString();
                tbSeats5.Enabled = true;
                tbSeats4.Enabled = true;
                tbSeats6.Enabled = false;
            }

            if (tbPartyNo.Text == "6")
            {
                tbParty1.Text = dgvStateTally.Rows[0].Cells[1].Value.ToString();
                tbParty2.Text = dgvStateTally.Rows[1].Cells[1].Value.ToString();
                tbParty3.Text = dgvStateTally.Rows[2].Cells[1].Value.ToString();
                tbParty4.Text = dgvStateTally.Rows[3].Cells[1].Value.ToString();
                tbParty5.Text = dgvStateTally.Rows[4].Cells[1].Value.ToString();
                tbParty6.Text = dgvStateTally.Rows[5].Cells[1].Value.ToString();
                tbParty5.Enabled = true;
                tbParty4.Enabled = true;
                tbParty6.Enabled = true;

                tbSeats1.Text = dgvStateTally.Rows[0].Cells[2].Value.ToString();
                tbSeats2.Text = dgvStateTally.Rows[1].Cells[2].Value.ToString();
                tbSeats3.Text = dgvStateTally.Rows[2].Cells[2].Value.ToString();
                tbSeats4.Text = dgvStateTally.Rows[3].Cells[2].Value.ToString();
                tbSeats5.Text = dgvStateTally.Rows[4].Cells[2].Value.ToString();
                tbSeats6.Text = dgvStateTally.Rows[5].Cells[2].Value.ToString();
                tbSeats5.Enabled = true;
                tbSeats4.Enabled = true;
                tbSeats6.Enabled = true;

            }

            if (tbPartyNo.Text == "4")
            {
                tbParty1.Text = dgvStateTally.Rows[0].Cells[1].Value.ToString();
                tbParty2.Text = dgvStateTally.Rows[1].Cells[1].Value.ToString();
                tbParty3.Text = dgvStateTally.Rows[2].Cells[1].Value.ToString();
                tbParty4.Text = dgvStateTally.Rows[3].Cells[1].Value.ToString();
                tbParty5.Enabled = false;
                tbParty6.Enabled = false;
                tbParty4.Enabled = true;

                tbSeats1.Text = dgvStateTally.Rows[0].Cells[2].Value.ToString();
                tbSeats2.Text = dgvStateTally.Rows[1].Cells[2].Value.ToString();
                tbSeats3.Text = dgvStateTally.Rows[2].Cells[2].Value.ToString();
                tbSeats4.Text = dgvStateTally.Rows[3].Cells[2].Value.ToString();
                tbSeats5.Enabled = false;
                tbSeats6.Enabled = false;
                tbSeats4.Enabled = true;

            }


        }

        public void getSTotal()
        {

            if (tbPartyNo.Text == "5")
            {

                int tot5 = Convert.ToInt32(tbSeats1.Text) + Convert.ToInt32(tbSeats2.Text) + Convert.ToInt32(tbSeats3.Text) + Convert.ToInt32(tbSeats4.Text) + Convert.ToInt32(tbSeats5.Text);
                tbStot.Text = tot5.ToString();


            }

            if (tbPartyNo.Text == "6")
            {

                int tot6 = Convert.ToInt32(tbSeats1.Text) + Convert.ToInt32(tbSeats2.Text) + Convert.ToInt32(tbSeats3.Text) + Convert.ToInt32(tbSeats4.Text) + Convert.ToInt32(tbSeats5.Text) + Convert.ToInt32(tbSeats6.Text);
                tbStot.Text = tot6.ToString();


            }

            if (tbPartyNo.Text == "4")
            {

                int tot4 = Convert.ToInt32(tbSeats1.Text) + Convert.ToInt32(tbSeats2.Text) + Convert.ToInt32(tbSeats3.Text) + Convert.ToInt32(tbSeats4.Text);
                tbStot.Text = tot4.ToString();


            }



        }


        public void Tally4_DataToViz()

        {
            string myip = tbIP.Text;
            string ImgPath = ConfigurationManager.AppSettings["ImgPath"];
            string dpcmd = "0 RENDERER*FUNCTION*DataPool*Data SET ";

            string stateselector = dpcmd + "lsbottomtallyselector = " + tbPartyNo.Text;
            string statename = dpcmd + "lsbottomtallystatename = " + tbSname.Text;

            string sall1 = dpcmd + "lsbottomtallyalliance1 = " + tbParty1.Text;
            string sall2 = dpcmd + "lsbottomtallyalliance2 = " + tbParty2.Text;
            string sall3 = dpcmd + "lsbottomtallyalliance3 = " + tbParty3.Text;
            string sall4 = dpcmd + "lsbottomtallyalliance4 = " + tbParty4.Text;

            string img1 = dpcmd + "Image1 = " + ImgPath + tbParty1.Text;
            string img2 = dpcmd + "Image2 = " + ImgPath + tbParty2.Text;
            string img3 = dpcmd + "Image3 = " + ImgPath + tbParty3.Text;
            string img4 = dpcmd + "Image4 = " + ImgPath + tbParty4.Text;

            string Imgval = img1 + ";" + img2 + ";" + img3 + ";" + img4;

            string sseats1 = dpcmd + "lsbottomtallytotal1 = " + tbSeats1.Text;
            string sseats2 = dpcmd + "lsbottomtallytotal2 = " + tbSeats2.Text;
            string sseats3 = dpcmd + "lsbottomtallytotal3 = " + tbSeats3.Text;
            string sseats4 = dpcmd + "lsbottomtallytotal4 = " + tbSeats4.Text;

            string sTotalVal = dpcmd + "lsbottomtallytotalvalue = " + tbSTotal.Text;
            string sResultVal = dpcmd + " lsbottomtallyresultvalue = " + tbStot.Text;

            string keyval = stateselector + ";" + statename + ";" + sall1 + ";" + sall2 + ";" + sall3 + ";" + sall4 + ";" + sseats1 + ";" + sseats2 + ";" + sseats3 + ";" + sseats4 + ";" + Imgval + ";" + sTotalVal + ";" + sResultVal;

            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*LS_DIR_ELECTION*ACTION*TRIGGER*KEY*$stateplay*VALUE SET " + keyval);
            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*MOVEMENT START");

        }


        public void Tally5_DataToViz()

        {
            string myip = tbIP.Text;
            string ImgPath = ConfigurationManager.AppSettings["ImgPath"];
            string dpcmd = "0 RENDERER*FUNCTION*DataPool*Data SET ";

            string stateselector = dpcmd + "lsbottomtallyselector = " + tbPartyNo.Text;
            string statename = dpcmd + "lsbottomtallystatename = " + tbSname.Text;

            string sall1 = dpcmd + "lsbottomtallyalliance1 = " + tbParty1.Text;
            string sall2 = dpcmd + "lsbottomtallyalliance2 = " + tbParty2.Text;
            string sall3 = dpcmd + "lsbottomtallyalliance3 = " + tbParty3.Text;
            string sall4 = dpcmd + "lsbottomtallyalliance4 = " + tbParty4.Text;
            string sall5 = dpcmd + "lsbottomtallyalliance5 = " + tbParty5.Text;

            string img1 = dpcmd + "Image1 = " + ImgPath + tbParty1.Text;
            string img2 = dpcmd + "Image2 = " + ImgPath + tbParty2.Text;
            string img3 = dpcmd + "Image3 = " + ImgPath + tbParty3.Text;
            string img4 = dpcmd + "Image4 = " + ImgPath + tbParty4.Text;
            string img5 = dpcmd + "Image5 = " + ImgPath + tbParty5.Text;

            string Imgval = img1 + ";" + img2 + ";" + img3 + ";" + img4 + ";"+ img5;

            string sseats1 = dpcmd + "lsbottomtallytotal1 = " + tbSeats1.Text;
            string sseats2 = dpcmd + "lsbottomtallytotal2 = " + tbSeats2.Text;
            string sseats3 = dpcmd + "lsbottomtallytotal3 = " + tbSeats3.Text;
            string sseats4 = dpcmd + "lsbottomtallytotal4 = " + tbSeats4.Text;
            string sseats5 = dpcmd + "lsbottomtallytotal5 = " + tbSeats5.Text;

            string sTotalVal = dpcmd + "lsbottomtallytotalvalue = " + tbSTotal.Text;
            string sResultVal = dpcmd + " lsbottomtallyresultvalue = " + tbStot.Text;

            string keyval = stateselector + ";" + statename + ";" + sall1 + ";" + sall2 + ";" + sall3 + ";" + sall4 + ";" + sall5 + ";" + sseats1 + ";" + sseats2 + ";" + sseats3 + ";" + sseats4 + ";" + sseats5 + ";" + Imgval+ ";" + sTotalVal + ";" + sResultVal;

            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*LS_DIR_ELECTION*ACTION*TRIGGER*KEY*$stateplay*VALUE SET " + keyval);

            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*MOVEMENT START");
        }


        public void Tally6_DataToViz()

        {
            string myip = tbIP.Text;
            string ImgPath = ConfigurationManager.AppSettings["ImgPath"];
            string dpcmd = "0 RENDERER*FUNCTION*DataPool*Data SET ";

            string stateselector = dpcmd + "lsbottomtallyselector = " + tbPartyNo.Text;
            string statename = dpcmd + "lsbottomtallystatename = " + tbSname.Text;

            string sall1 = dpcmd + "lsbottomtallyalliance1 = " + tbParty1.Text;
            string sall2 = dpcmd + "lsbottomtallyalliance2 = " + tbParty2.Text;
            string sall3 = dpcmd + "lsbottomtallyalliance3 = " + tbParty3.Text;
            string sall4 = dpcmd + "lsbottomtallyalliance4 = " + tbParty4.Text;
            string sall5 = dpcmd + "lsbottomtallyalliance5 = " + tbParty5.Text;
            string sall6 = dpcmd + "lsbottomtallyalliance6 = " + tbParty6.Text;

            string img1 = dpcmd + "Image1 = " + ImgPath + tbParty1.Text;
            string img2 = dpcmd + "Image2 = " + ImgPath + tbParty2.Text;
            string img3 = dpcmd + "Image3 = " + ImgPath + tbParty3.Text;
            string img4 = dpcmd + "Image4 = " + ImgPath + tbParty4.Text;
            string img5 = dpcmd + "Image5 = " + ImgPath + tbParty5.Text;
            string img6 = dpcmd + "Image6 = " + ImgPath + tbParty6.Text;

            string Imgval = img1 + ";" + img2 + ";" + img3 + ";" + img4 + ";" + img5 + ";" + img6;

            string sseats1 = dpcmd + "lsbottomtallytotal1 = " + tbSeats1.Text;
            string sseats2 = dpcmd + "lsbottomtallytotal2 = " + tbSeats2.Text;
            string sseats3 = dpcmd + "lsbottomtallytotal3 = " + tbSeats3.Text;
            string sseats4 = dpcmd + "lsbottomtallytotal4 = " + tbSeats4.Text;
            string sseats5 = dpcmd + "lsbottomtallytotal5 = " + tbSeats5.Text;
            string sseats6 = dpcmd + "lsbottomtallytotal6 = " + tbSeats6.Text;

            string sTotalVal = dpcmd + "lsbottomtallytotalvalue = " + tbSTotal.Text;
            string sResultVal = dpcmd + " lsbottomtallyresultvalue = " + tbStot.Text;

            string keyval = stateselector + ";" + statename + ";" + sall1 + ";" + sall2 + ";" + sall3 + ";" + sall4 + ";" + sall5 + ";" + sall6 + ";" + sseats1 + ";" + sseats2 + ";" + sseats3 + ";" + sseats4 + ";" + sseats5 + ";" + sseats6 + ";" + Imgval + ";" + sTotalVal + ";" + sResultVal;

            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*LS_DIR_ELECTION*ACTION*TRIGGER*KEY*$stateplay*VALUE SET " + keyval);
            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*MOVEMENT START");

        }


        public void sendDataToViz()

        {
            string myip = tbIP.Text;

            string ImgPath = ConfigurationManager.AppSettings["ImgPath"];

            vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyselector = " + tbPartyNo.Text);

            if (tbPartyNo.Text == "4")

            {
                //  vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET sbottomtallyselector = " +tbPartyNo.Text);

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance1 = " + tbParty1.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance2 = " + tbParty2.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance3 = " + tbParty3.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance4 = " + tbParty4.Text);

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image1 = " + ImgPath + tbParty1.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image2 = " + ImgPath + tbParty2.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image3 = " + ImgPath + tbParty3.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image4 = " + ImgPath + tbParty4.Text);

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal1 = " + tbSeats1.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal2 = " + tbSeats2.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal3 = " + tbSeats3.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal4 = " + tbSeats4.Text);

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyresultvalue = " + tbStot.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotalvalue = " + tbSTotal.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallystatename = " + tbSname.Text);
                vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*MOVEMENT START");

                if (listState.SelectedIndex != selectedIndex)
                {
                    if (checkBox1.Checked != true)
                    {
                        vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*MOVEMENT START");
                        selectedIndex = listState.SelectedIndex;
                    }
                }


            }

            if (tbPartyNo.Text == "5")

            {

                //string ImgPath = ConfigurationManager.AppSettings["ImgPath"];
                // vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET sbottomtallyselector = 5");

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance1 = " + tbParty1.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance2 = " + tbParty2.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance3 = " + tbParty3.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance4 = " + tbParty4.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance5 = " + tbParty5.Text);

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image1 = " + ImgPath + tbParty1.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image2 = " + ImgPath + tbParty2.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image3 = " + ImgPath + tbParty3.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image4 = " + ImgPath + tbParty4.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image5 = " + ImgPath + tbParty5.Text);

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal1 = " + tbSeats1.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal2 = " + tbSeats2.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal3 = " + tbSeats3.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal4 = " + tbSeats4.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal5 = " + tbSeats5.Text);

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyresultvalue = " + tbStot.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotalvalue = " + tbSTotal.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallystatename = " + tbSname.Text);
            }

            //if (listState.SelectedIndex != selectedIndex)
            //{
            //    if (checkBox1.Checked != true)
            //    {
            //        vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*MOVEMENT START");
            //        selectedIndex = listState.SelectedIndex;
            //    }
            //}
            if (tbPartyNo.Text == "6")

            {
                // vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET sbottomtallyselector = 5");

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance1 = " + tbParty1.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance2 = " + tbParty2.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance3 = " + tbParty3.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance4 = " + tbParty4.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyalliance5 = " + tbParty5.Text);

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image1 = " + ImgPath + tbParty1.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image2 = " + ImgPath + tbParty2.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image3 = " + ImgPath + tbParty3.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image4 = " + ImgPath + tbParty4.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image5 = " + ImgPath + tbParty5.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET Image6 = " + ImgPath + tbParty6.Text);

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal1 = " + tbSeats1.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal2 = " + tbSeats2.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal3 = " + tbSeats3.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal4 = " + tbSeats4.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotal5 = " + tbSeats5.Text);

                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallyresultvalue = " + tbStot.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallytotalvalue = " + tbSTotal.Text);
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET lsbottomtallystatename = " + tbSname.Text);
            }

            //if (listState.SelectedIndex != selectedIndex)
            //{
            //    if (checkBox1.Checked != true)
            //    {
            //        vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*MOVEMENT START");
            //        selectedIndex = listState.SelectedIndex;
            //    }
            //}

        }



        public void SceneLoad()

        {
            string myip = tbIP.Text;

            string myscene = label2.Text.Trim();

            vc.getVizdata(myip, "0 RENDERER SET_OBJECT SCENE*" + myscene);
            vc.getVizdata(myip, "0 RENDERER*STAGE SHOW 0.0");
            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*MOVEMENT START");
            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*TIME CONTINUE");
            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*LIVE CONTINUE");
            // vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*VFI_OPEN START");

            // sendDataToViz();
            if (tbPartyNo.Text == "4")
            {
                Tally4_DataToViz();
            }

            if (tbPartyNo.Text == "5")
            {
                Tally5_DataToViz();
            }

            if (tbPartyNo.Text == "6")
            {
                Tally6_DataToViz();
            }

        }

        private void cmbVizHost_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] host = cmbVizHost.Text.Split('|');
            tbIP.Text = host[1].Trim();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getVizHost();
            rd_MainDB.Checked = true;
            getStates();
            listState.SelectedIndex = 0;
            selectedIndex = listState.SelectedIndex;
            getSatateTally();
            FillBoxes();
            getSTotal();
            // getZone3Data();
            //sendDataToViz();
            label2.Text = ConfigurationManager.AppSettings["Scene1"];

            //tbZone3State.Text = dgvZone3.Rows[0].Cells[0].Value.ToString();
            //tbZone3Cname.Text = dgvZone3.Rows[0].Cells[1].Value.ToString();
            //tbZone3Pname.Text = dgvZone3.Rows[0].Cells[2].Value.ToString();
            //tbZone3CandName.Text = dgvZone3.Rows[0].Cells[3].Value.ToString();
            //tbZone3Status.Text = dgvZone3.Rows[0].Cells[4].Value.ToString();
        }

        private void listState_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] sinfo = listState.Text.Split('|');
            tbID.Text = sinfo[0].Trim();
            tbSname.Text = sinfo[1].Trim();
            tbSTotal.Text = sinfo[2].Trim();
            tbPartyNo.Text = sinfo[3].Trim();            
            getSatateTally();
            FillBoxes();
            getSTotal();
            if (tbPartyNo.Text == "4")
            {
                Tally4_DataToViz();
            }

            if (tbPartyNo.Text == "5")
            {
                Tally5_DataToViz();
            }

            if (tbPartyNo.Text == "6")
            {
                Tally6_DataToViz();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                timer1.Enabled = true;
            }

            else
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            a++;
            int b = listState.Items.Count;
            listState.SelectedIndex = a - 1;
            if (a == b)
            {
                a = 0;
            }

            //sendDataToViz();

            if (tbID.Text.Trim() == "1")
            {
                timer1.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["tripura"].Trim());
            }
            else if (tbID.Text.Trim() == "2")
            {
                timer1.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["meghalaya"].Trim());
            }
            else if (tbID.Text.Trim() == "3")
            {
                timer1.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["nagaland"].Trim());
            }
            //else if (tbID.Text.Trim() == "3")
            //{
            //    timer1.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["goa"].Trim());
            //}
            //else if (tbID.Text.Trim() == "4")
            //{
            //    timer1.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["uttarakhand"].Trim());
            //}

            if (tbPartyNo.Text == "4")
            {
                Tally4_DataToViz();
            }

            if (tbPartyNo.Text == "5")
            {
                Tally5_DataToViz();
            }

            if (tbPartyNo.Text == "6")
            {
                Tally6_DataToViz();
            }
        }

        private void btnSceneLoad_Click(object sender, EventArgs e)
        {
            SceneLoad();
        }

        private void timerZone3_Tick(object sender, EventArgs e)
        {

            i++;
            int j = dgvZone3.RowCount;
            dgvZone3.ClearSelection();
            dgvZone3.Rows[i - 1].Selected = true;
            if (i == j)
            {
                i = 0;
            }
            getZone3Data();
            scrollNext();
            SendZone3Data();
        }

        private void Zone3Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Zone3Check.Checked == true)
            {
                timerZone3.Enabled = true;
            }

            else
            {
                timerZone3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myip = tbIP.Text;
            getZone3Data();
            SendZone3Data();
            vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*ZONE_3 START");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string myip = tbIP.Text;
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET  CHANNEL_BUG_RIYAL_1 = 1");
                vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*LIVE CONTINUE");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string myip = tbIP.Text;
                vc.getVizdata(myip, "0 RENDERER*FUNCTION*DataPool*Data SET  CHANNEL_BUG_RIYAL_1 = 2");
                vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*REC CONTINUE");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string myip = tbIP.Text;
                vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*GPI CONTINUE");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string myip = tbIP.Text;
                vc.getVizdata(myip, "0 RENDERER*STAGE*DIRECTOR*GPI START");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)

            {
                timer2.Enabled = true;
            }

            if (checkBox2.Checked == false)

            {
                timer2.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            getSatateTally();
            FillBoxes();
            sendDataToViz();
            //timer1.Interval = 3000;

             if (tbID.Text.Trim() == "1")
            {
                timer1.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["tripura"].Trim());
            }
            else if (tbID.Text.Trim() == "2")
            {
                timer1.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["meghalaya"].Trim());
            }
            else if (tbID.Text.Trim() == "3")
            {
                timer1.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["nagaland"].Trim());
            }
            //else if (tbID.Text.Trim() == "3")
            //{
            //    timer1.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["goa"].Trim());
            //}
            //else if (tbID.Text.Trim() == "4")
            //{
            //    timer1.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["uttarakhand"].Trim());
            //}

            //if (tbPartyNo.Text == "4")
            //{
            //    Tally4_DataToViz();
            //}

            //if (tbPartyNo.Text == "5")
            //{
            //    Tally5_DataToViz();
            //}

            //if (tbPartyNo.Text == "6")
            //{
            //    Tally6_DataToViz();
            //}


        }

        private void rd_MainDB_CheckedChanged(object sender, EventArgs e)
        {
            tbServerName.Text = "DB";
        }

        private void rd_Backup_CheckedChanged(object sender, EventArgs e)
        {
            tbServerName.Text = "DB_BACKUP";
        }
    }
}

