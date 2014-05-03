using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data.SqlServerCe;
using org.eclipse.wst.wsdl.validation.@internal.resolver;
using org.eclipse.wst.wsdl.validation.@internal;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        public int count = 0;
        string url = "";
        string f = "func_name";
        int i = 0;
        string fname = "";
        static String st = AppDomain.CurrentDomain.BaseDirectory;
        SqlCeConnection conn = new SqlCeConnection("Data Source ="+st+"\\App_Data\\Database1.sdf");
        
        Service1Client.Service1 sc = new Service1Client.Service1();
        
        Dictionary<String, String> myDictionary = new Dictionary<String, String>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {

                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;

                Label16.Visible = false;
                Label17.Visible = false;
                Label18.Visible = false;
                Label19.Visible = false;
                Label20.Visible = false;
                Label21.Visible = false;
                Label22.Visible = false;
                Label23.Visible = false;
                Label24.Visible = false;

                Button1.Visible = false;
                Button2.Visible = false;
                Button3.Visible = false;
                Button4.Visible = false;
            }
  //          conn.Open();
   //         SqlCeCommand cmd = conn.CreateCommand();
//            cmd.CommandText = "INSERT INTO Services VALUES('Find Value','http://venus.eas.asu.edu/WSRepository/Services/BasicThree/Service.asmx?WSDL');";
 //           cmd.ExecuteNonQuery();
    //        cmd.CommandText = "INSERT INTO Functions VALUES('HelloWorld','Find Value','string,double,int','string');";
     //       cmd.ExecuteNonQuery();
      //      cmd.CommandText = "INSERT INTO Functions VALUES('PiValue','Find Value','string,double,int','double');";
       //     cmd.ExecuteNonQuery();
        //    cmd.CommandText = "INSERT INTO Functions VALUES('abs','Find Value','int','int');";
         //   cmd.ExecuteNonQuery();


        }

        protected void wsdl_name_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void b_Click(object sender, EventArgs e)
        {
            WSDLValidator valid = new WSDLValidator();
            IValidationReport ivr = valid.validate(wsdl_name.Text);
            String errMsg=" ";
            HashSet<string> se = new HashSet<string>();

            if (!ivr.isWSDLValid())
            {
                foreach(IValidationMessage msg in ivr.getValidationMessages()){
                     
                    se.Add(msg.getMessage());
                }
                foreach (String str in se)
                {
                    errMsg += str+"</br>";
                   
                }
                Label24.Text = errMsg;
                Label24.Visible = true;

                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;

                Button1.Visible = false;
                Button2.Visible = false;
                Button3.Visible = false;
                Button4.Visible = false;
 
                Label16.Visible = false;
                Label20.Visible = false;
                Label17.Visible = false;
                Label21.Visible = false;
                Label18.Visible = false;
                Label22.Visible = false;
                Label19.Visible = false;
                Label23.Visible = false;
            
            }
            else{
                Label24.Visible = false;
            url = wsdl_name.Text;
            String[] myDictionary = sc.getServiceDetails(url);
            //myDictionary = sc.getServiceDetails(url);
            count = myDictionary.Length;
            Label16.Visible = false;
            Label20.Visible = false;
            Label17.Visible = false;
            Label21.Visible = false;
            Label18.Visible = false;
            Label22.Visible = false;
            Label19.Visible = false;
            Label23.Visible = false;
            
            if (count >= 1)
            {
                Label4.Visible = true;
                Label5.Visible = true;
                Label6.Visible = true;
                Button1.Visible = true;
            }
            else
            {
                Label4.Visible = false;
                Label5.Visible = false;
                Label6.Visible = false;
                Button1.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Button2.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Button3.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Button4.Visible = false;
                }
            if (count >= 2)
            {
                Label7.Visible = true;
                Label8.Visible = true;
                Label9.Visible = true;
                Button2.Visible = true;

            }
            else
            {
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                Button2.Visible = false;
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Button3.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Button4.Visible = false;
                
            }
            if (count >= 3)
            {
                Label10.Visible = true;
                Label11.Visible = true;
                Label12.Visible = true;
                Button3.Visible = true;
            }
            else
            {
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Button3.Visible = false;
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Button4.Visible = false;
                
            }
            if (count >= 4)
            {
                Label13.Visible = true;
                Label14.Visible = true;
                Label15.Visible = true;
                Button4.Visible = true;
            }
            else
            {
                Label13.Visible = false;
                Label14.Visible = false;
                Label15.Visible = false;
                Button4.Visible = false;
                
            }
            foreach (String entry in myDictionary)
            {
                // Label MyLabel = new Label();
                //Assigning the textbox ID name 
                // MyLabel.ID = f + i.ToString();
                // MyLabel.Width = 800;
                // MyLabel.Height = 60;

                //MyLabel.TextMode = TextBoxMode.MultiLine;

                String[] p = entry.Split('!');
                System.Diagnostics.Debug.Write("****************" + p.Length + p);
                if (i == 0)
                {
                    Label4.Text = p[0];
                    Label5.Text = p[2];
                    Label6.Text = p[1];
                }
                if (i == 1)
                {
                    Label7.Text = p[0];
                    Label8.Text = p[2];
                    Label9.Text = p[1];
                }
                if (i == 2)
                {
                    Label10.Text = p[0];
                    Label11.Text = p[2];
                    Label12.Text = p[1];
                }
            ///    Result.Text += "<b>" + "Function" + i.ToString() + "  " + "</b>" + p[0];
                //string io = entry.Value;
                //string[] parameters = io.Split('#');

                //Output.Text += "<b>" + "Output parameters for Fucntion" + i.ToString() + "  " + "</b>" + p[1];
               // Input.Text += "<b>" + "Input parameters for Fucntion" + i.ToString() + "  " + "</b>" + p[2];
                i++;
                // this.Controls.Add(MyLabel);

                //Form.Controls.Add(MyTextBox);

                //  func_name1.Text = entry.Key;
                //string io = entry.Value;
                //  string[] parameters = io.Split('#');
                //  input_name1.Text = parameters[0];
                // output_name1.Text = parameters[1];
            }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            //cmd.CommandText = "INSERT INTO Services VALUES('Find Value','http://venus.eas.asu.edu/WSRepository/Services/BasicThree/Service.asmx?WSDL');";
            //cmd.ExecuteNonQuery();
           // cmd.CommandText = "INSERT INTO Services VALUES('Stock', 'http://www.webservicex.net/stockquote.asmx?WSDL');";
           // Stock.StockQuote s = new Stock.StockQuote();
            //s.
           // cmd.CommandText = "INSERT INTO Functions VALUES('GetQuote','Stock','string','string');";
         
            //cmd.ExecuteNonQuery();
            //cmd.CommandText = "INSERT INTO Services VALUES('Incorrect', 'https://misapi.ercot.com/2007-08/Nodal/eEDS/EWS/?WSDL');";
            //cmd.ExecuteNonQuery();
            cmd.CommandText = "Select Functions.Name FROM Functions where Functions.FunctionName='" + Label4.Text+
                "' AND Functions.Input='"+Label5.Text+"' AND Functions.Output='"+Label6.Text+"';" ;
            System.Diagnostics.Debug.Write("++++"+cmd.CommandText);
            cmd.ExecuteNonQuery();
//            System.Diagnostics.Debug.Write("*********** " + (string)cmd.ExecuteScalar() + " *********** ");          
            if ((string)cmd.ExecuteScalar() != null)
            {
                Label16.Text = "Passed";
                Label16.Visible = true;
            }
            else
            {
                Label20.Text = "Failed";
                Label20.Visible = true;
            }
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select Functions.Name FROM Functions where Functions.FunctionName='" + Label7.Text +
                "' AND Functions.Input='" + Label8.Text + "' AND Functions.Output='" + Label9.Text + "';";
            System.Diagnostics.Debug.Write("++++" + cmd.CommandText);
            cmd.ExecuteNonQuery();
            //System.Diagnostics.Debug.Write("*********** " + (string)cmd.ExecuteScalar() + " *********** ");
            if ((string)cmd.ExecuteScalar() != null)
            {
                Label17.Text = "Passed";
                Label17.Visible = true;
            }
            else
            {
                Label21.Text = "Failed";
                Label21.Visible = true;
            }
            conn.Close();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select Functions.Name FROM Functions where Functions.FunctionName='" + Label10.Text +
                                "' AND Functions.Input='" + Label11.Text + "' AND Functions.Output='" + Label12.Text + "';";
            System.Diagnostics.Debug.Write("++++" + cmd.CommandText);
            cmd.ExecuteNonQuery();
            //System.Diagnostics.Debug.Write("*********** " + (string)cmd.ExecuteScalar() + " *********** ");
            if ((string)cmd.ExecuteScalar() != null)
            {
                Label18.Text = "Passed";
                Label18.Visible = true;

            }
            else
            {
                Label22.Text = "Failed";
                Label22.Visible = true;
            }
            conn.Close();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select Functions.Name FROM Functions where Functions.FunctionName='" + Label13.Text +
                                "' AND Functions.Input='" + Label14.Text + "' AND Functions.Output='" + Label15.Text + "';";
            System.Diagnostics.Debug.Write("++++" + cmd.CommandText);
            cmd.ExecuteNonQuery();
            //System.Diagnostics.Debug.Write("*********** " + (string)cmd.ExecuteScalar() + " *********** ");
            if ((string)cmd.ExecuteScalar() != null)
            {
                Label19.Text = "Passed";
                Label19.Visible = true;
            }
            else
            {
                Label23.Text = "Failed";
                Label23.Visible = true;
            }
            conn.Close();
        }
    }
}