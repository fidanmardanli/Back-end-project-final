﻿using System.ComponentModel.DataAnnotations;

namespace AASA_Back_End.Models
{
    public class Slider2 : BaseEntity
    {

        public string ImageFirst { get; set; }
        public string ImageSecond { get; set; }
        public string ImageThird { get; set; }
        public string TitleFirst { get; set; }
        public string TitleSecond { get; set; }
        public string TitleThird { get; set; }
        public string DescriptionFirst { get; set; }
        public string DescriptionSecond { get; set; }
        public string DescriptionThird { get; set; }
        public string TextFirst { get; set; }
        public string TextSecond { get; set; }
        public string TextThird { get; set; }


    }
}
