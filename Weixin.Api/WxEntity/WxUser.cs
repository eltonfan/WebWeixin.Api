﻿using System;

namespace Weixin.Api.Entity
{
    public class WxUser
    {
        public long Uin { get; set; }
        /// <summary>
        /// 1个@是用户，2个@是群组
        /// </summary>
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string HeadImgUrl { get; set; }
        public string RemarkName { get; set; }
        public string PYInitial { get; set; }
        public string PYQuanPin { get; set; }
        public string RemarkPYInitial { get; set; }
        public string RemarkPYQuanPin { get; set; }
        public int HideInputBarFlag { get; set; }
        public int StarFriend { get; set; }
        public int Sex { get; set; }
        public string Signature { get; set; }
        public int AppAccountFlag { get; set; }
        public int VerifyFlag { get; set; }
        public int ContactFlag { get; set; }
        public int WebWxPluginSwitch { get; set; }
        public int HeadImgFlag { get; set; }
        public int SnsFlag { get; set; }
    }
}