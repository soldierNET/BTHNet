using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.Json;

namespace BaiThucHanh3
{
    public partial class Guestbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            ReadComments();
        }
        protected void BtnGui_Click(object sender, EventArgs e)
        {
            string dataPath = Server.MapPath(@"\comment.json");
            Comment comment = new Comment
            {
                name = txtHoTen.Value,
                email = txtEmail.Value,
                title = txtTieuDe.Value,
                comment = txtNoiDung.Value,
                date = DateTime.Now.ToString()
            };
            List<Comment> commentList = GetData();
            if (commentList == null)
                commentList = new List<Comment>();

            commentList.Insert(0, comment);
            string jsonString = JsonSerializer.Serialize(commentList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataPath, jsonString);
            ReadComments();
        }
        protected List<Comment> GetData()
        {
            string dataPath = Server.MapPath(@"\comment.json");
            try
            {
                    string jsonString = File.ReadAllText(dataPath);
                    List<Comment> commentList = JsonSerializer.Deserialize<List<Comment>>(jsonString);
                    return commentList;
            }
            catch (Exception e)
            {
                return null;
            }
        }
            protected void ReadComments()
        {
            List<Comment> commentList = GetData();
            if (commentList == null)
                return;

            commentCount.InnerText = commentList.Count().ToString();
                commentRepeater.DataSource = commentList.AsEnumerable();
                commentRepeater.DataBind();
            }
            
        
    }

    public class Comment
    {
        public string name { get; set; }
        public string email {get; set;}
        public string title {get; set;}
        public string comment {get; set;}
        public string date {get; set;}
    }
}