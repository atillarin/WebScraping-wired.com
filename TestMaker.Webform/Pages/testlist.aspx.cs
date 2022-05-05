using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestMaker.Webform.ViewModels;

namespace TestMaker.Webform.Pages
{
    public partial class testlist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshTable();
            WelcomeUser();
        }

        protected void testlistgrid_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        
        protected void testlistgrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            List<TestVM> testListVM = new List<TestVM>();
            testListVM = (List<TestVM>)Session["Tests"];
            TestVM testVm = testListVM[e.RowIndex];


            string loginJson = JsonConvert.SerializeObject(testVm);
            StringContent data = new StringContent(loginJson, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var response = client.PostAsync("http://localhost:7571/api/Test/DeleteRow", data).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                ResponseVM responseVM = JsonConvert.DeserializeObject<ResponseVM>(result);
                if (responseVM.StatusCode == 200)
                {
                    RefreshTable();
                }
  
            }


        }

        protected void RefreshTable ()
        {
            CheckSession();

                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync("http://localhost:7571/api/Test/GetAll").Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    var responseVM = JsonConvert.DeserializeObject<ResponseListVM<TestVM>>(result);

                    testlistgrid.DataSource = responseVM.Data;
                    Session["Tests"] = responseVM.Data;
                    testlistgrid.DataBind();
                }
           
        }

        protected void CheckSession ()
        {
            if (Session["User"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }


        protected void createtestB_Click(object sender, EventArgs e)
        {
            CheckSession();
            Response.Redirect("createtest.aspx");
        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("login.aspx");
        }


        protected void WelcomeUser()
        {
            welcomeL.Text = ((UserVM)Session["User"]).UserName;
        }
    }
}