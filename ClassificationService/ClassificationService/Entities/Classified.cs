﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassificationService.Entities
{
    public class Classified
    {
        public Classified(string title, string text, string subject, string date, Boolean isClassifiedFake)
        {
            this.Title = title;
            this.Text = text;
            this.Subject = subject;
            this.Date = date;
            this.isClassifiedFake = isClassifiedFake;
        }

        public string Title { get; set; }

        public string Text { get; set; }

        public string Subject { get; set; }

        public string Date { get; set; }

        public bool isClassifiedFake { get; set; }

        public int id { get; set; }
    }
}