using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Entity.Concrete.Dto;

namespace TestMaker.Bll.Concrete
{
    public class WiredDataManager
    {
        private string mainXpath = "//*[@id='main-content']/div[1]/div[1]/div/div/section[1]/div[1]/div[1]/div/div/div";
        private string subXpath = "//*[@id='main-content']/article/div[2]/div";
        List<ArticleDto> articleList;
        ArticleDto article;

        public List<ArticleDto> GetArticles ()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument mainDocument = web.Load("https://www.wired.com/most-recent/");
            var mainNodes = mainDocument.DocumentNode.SelectNodes(mainXpath);
            articleList = new List<ArticleDto>();
            for (int i = 0; i < mainNodes.Count; i++)
            {
                article = new ArticleDto();
                if (i == 3) continue;
                article.title = mainNodes[i].SelectSingleNode(".//div[2]//a//h3").InnerText;
                article.uri = "https://www.wired.com" + mainNodes[i].SelectSingleNode(".//div[2]//a").Attributes["href"].Value;
                HtmlDocument subDocument = web.Load(article.uri);
                var subNodes = subDocument.DocumentNode.SelectNodes(subXpath);
                article.text = subNodes[0].InnerText;
                articleList.Add(article);
            }
            return articleList;
        }

    }
}
