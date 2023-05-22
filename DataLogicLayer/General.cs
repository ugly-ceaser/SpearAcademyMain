﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLogicLayer
{
    public static class General
    {
        public static class proccessType
        {

            public static int Login = 1;
            public static int AddressAdd = 2;
            public static int AddressUpdate = 3;


            public static int AddressDelete = 4;
            public static int AdsAdd = 5;
            public static int AdsUpdate = 6;


            public static int AdsDelete = 7;
            public static int CategoryAdd = 8;
            public static int CategoryDelete = 9;
            public static int CategoryUpdate = 10;

            public static int IconAdd = 11;
            public static int IconDelete = 12;
            public static int IconUpdate = 13;


            public static int MetaAdd = 14;
            public static int MetaDelete = 15;
            public static int MetaUpdate = 16;


            public static int SocialAdd = 17;
            public static int SocialDelete = 18;
            public static int SocialUpdate = 19;


            public static int UserAdd = 20;
            public static int UserDelete = 21;
            public static int UserUpdate = 22;


            public static int VideoAdd = 23;
            public static int VideoDelete = 24;
            public static int VideoUpdate = 25;


            public static int PostAdd = 26;
            public static int PostDelete = 27;
            public static int PostUpdate = 28;


            public static int ImageAdd = 29;
            public static int ImageDelete = 30;
            public static int ImageUpdate = 31;



            public static int  TagAdd = 32;
            public static int TAgDelete = 33;
            public static int TagUpdate = 34;


            public static int CommentAdd = 35;
            public static int CommentDelete = 36;
            public static int CommentUpdate = 37;
            public static int CommentApprove = 38;
            public static int CommentRead = 39;

            public static int ContactDelete = 40;
            public static int ContactRead = 41;
        }

        public static class TableName
        {

            public static string Login = "Login";
            public static string Address = "Address";
            public static string Ads = "Ads";

            public static string Category = "Category";
            public static string Icon = "Icon";
            public static string Meta = "Meta";

            public static string Social = "Social";
            public static string User = "User";
            public static string Video = "Video";

            public static string Post = "Post";
            public static string Image = "Image";
            public static string Tag = "Tag";

            public static string Comment = "Comment";
            public static string Contact = "Contact";

        }
        public static class Messages
        {
            public static int AddSuccess = 1;
            public static int UpdateSuccess = 2;
            public static int EmptyArea = 3;

            public static int MissingImage = 4;
            public static int ExtensionError = 5;

            public static int GeneralError = 6;

        }
    }
}
