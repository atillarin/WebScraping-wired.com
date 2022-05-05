using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestMaker.Webform.ViewModels;

namespace TestMaker.Webform.Pages
{
    public partial class login : System.Web.UI.Page
    {
        LoginVM loginVM = new LoginVM();

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            loginVM.UserName = userNameTB.Text;
            loginVM.Password = passwordTB.Text;
            
            string loginJson = JsonConvert.SerializeObject(loginVM);                                     //login bilgileri mevcutsa test listesi sayfasına yönlendir.
            StringContent data = new StringContent(loginJson, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var response = client.PostAsync("http://localhost:7571/api/User/CheckUser", data).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                ResponseVM<UserVM> responseVM = JsonConvert.DeserializeObject<ResponseVM<UserVM>>(result);

                if (responseVM.StatusCode==200)
                {
                    Session["User"] = responseVM.Data;
                    Response.Redirect("testlist.aspx");
                }
                else
                {
                    dangerL.Visible = true;
                    dangerL.Text = responseVM.Message;
                }
            }
        }
    }
}