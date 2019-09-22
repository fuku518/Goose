using System;
using System.Collections.Generic;
using System.Text;

namespace Goose.Models
{
    public class Item
    {
        public string rendered_body { get; set; }
        public string body { get; set; }
        public bool coediting { get; set; }
        public int comments_count { get; set; }
        public DateTime created_at { get; set; }
        public object group { get; set; }
        public string id { get; set; }
        public int likes_count { get; set; }
        public bool _private { get; set; }
        public int reactions_count { get; set; }
        public Tag[] tags { get; set; }
        public string title { get; set; }
        public DateTime updated_at { get; set; }
        public string url { get; set; }
        public User user { get; set; }
        public object page_views_count { get; set; }
    }

    public class User
    {
        public string description { get; set; }
        public string facebook_id { get; set; }
        public int followees_count { get; set; }
        public int followers_count { get; set; }
        public string github_login_name { get; set; }
        public string id { get; set; }
        public int items_count { get; set; }
        public string linkedin_id { get; set; }
        public string location { get; set; }
        public string name { get; set; }
        public string organization { get; set; }
        public int permanent_id { get; set; }
        public string profile_image_url { get; set; }
        public bool team_only { get; set; }
        public string twitter_screen_name { get; set; }
        public string website_url { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
        public object[] versions { get; set; }
    }
}
