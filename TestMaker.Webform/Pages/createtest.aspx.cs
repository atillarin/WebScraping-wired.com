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
    public partial class createtest : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            GetArticles();
            AddArticles();
            WelcomeUser();
        }

        List<ArticleVM> articleList;
        protected void AddArticles()     // makale oturumu doluysa ekrana aktar
        {
            if (Session["Articles"] != null & Session["Virgin"] == null)
            {
                articleList = new List<ArticleVM>();
                articleList = (List<ArticleVM>)Session["Articles"];
                foreach (var article in articleList)
                {
                    TitleDDL.Items.Add(article.title);
                }
                TextL.Text = articleList[0].text;
                Session["Virgin"] = "its not virgin";
            }
        }

        protected void GetArticles ()    // wired haberlerini al makale oturumuna taşı.
        {
            CheckSession();
            if (Session["Articles"] == null)
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync("http://localhost:7571/api/Wired/GetArticles").Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    var articleList = JsonConvert.DeserializeObject<List<ArticleVM>>(result);
                    Session["Articles"] = articleList;
                }
            }

        }

        protected void TitleDDL_SelectedIndexChanged(object sender, EventArgs e)  // makale konusu değiştiğinde ekrandaki içeriği güncelle
        {
            articleList = new List<ArticleVM>();
            articleList = (List<ArticleVM>)Session["Articles"];
            TextL.Text =articleList[TitleDDL.SelectedIndex].text ;
        }


        protected void SendExam(ExamVM exam)     //sınav nesnesini iş katmanına gönder
        {
            string loginJson = JsonConvert.SerializeObject(exam);
            StringContent data = new StringContent(loginJson, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                var response = client.PostAsync("http://localhost:7571/api/Exam/Create", data).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                ResponseVM responseVM = JsonConvert.DeserializeObject<ResponseVM>(result);
                if (responseVM.StatusCode == 200)
                {
                    Session["virgin"] = null;
                    Response.Redirect("testlist.aspx");

                }
            }

        }


        protected void CheckSession()               //Kullanıcı aktif mi 
        {
            if (Session["User"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void WelcomeUser()
        {
            welcomeL.Text = ((UserVM)Session["User"]).UserName;
        }

        ExamVM examVm;
        QuestionVM questionVm;
        List<QuestionVM> questionList;
        protected void CreateB_Click(object sender, EventArgs e)   // Sınav nesnesini oluşturan tüm datayı ekrandan al kayıt için gonder.
        {
            CheckSession();

            examVm = new ExamVM();          
            examVm.UserID = ((UserVM)Session["User"]).UserID;
            examVm.Title = TitleDDL.SelectedValue;
            examVm.Text = TextL.Text;
                
            questionList = new List<QuestionVM>();

                questionVm = new QuestionVM();  // soru 1

                questionVm.Question1 = Q1TB.Text;
                questionVm.A = Q1AnswerATB.Text;
                questionVm.B = Q1AnswerBTB.Text;
                questionVm.C = Q1AnswerCTB.Text;
                questionVm.D = Q1AnswerDTB.Text;
                questionVm.Answer = Q1AnswersDDL.SelectedIndex;
                questionList.Add(questionVm);

            questionVm = new QuestionVM(); //soru 2

            questionVm.Question1 = Q2TB.Text;
            questionVm.A = Q2AnswerATB.Text;
            questionVm.B = Q2AnswerBTB.Text;
            questionVm.C = Q2AnswerCTB.Text;
            questionVm.D = Q2AnswerDTB.Text;
            questionVm.Answer = Q2AnswersDDL.SelectedIndex;
            questionList.Add(questionVm);

                questionVm = new QuestionVM(); //soru 3

                questionVm.Question1 = Q3TB.Text;
                questionVm.A = Q3AnswerATB.Text;
                questionVm.B = Q3AnswerBTB.Text;
                questionVm.C = Q3AnswerCTB.Text;
                questionVm.D = Q3AnswerDTB.Text;
                questionVm.Answer = Q3AnswersDDL.SelectedIndex;
                questionList.Add(questionVm);

            questionVm = new QuestionVM(); //soru4

            questionVm.Question1 = Q4TB.Text;
            questionVm.A = Q4AnswerATB.Text;
            questionVm.B = Q4AnswerBTB.Text;
            questionVm.C = Q4AnswerCTB.Text;
            questionVm.D = Q4AnswerDTB.Text;
            questionVm.Answer = Q4AnswersDDL.SelectedIndex;
            questionList.Add(questionVm);

                examVm.QuestionList = questionList;
                SendExam(examVm);

        }

        protected void logoutB_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("login.aspx");
        }

        protected void CancelB_Click(object sender, EventArgs e)
        {
            Session["Virgin"] = null;
            CheckSession();
            Response.Redirect("testlist.aspx");
        }
    }
}