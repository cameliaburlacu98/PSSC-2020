using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tema6.Inputs
{
    public class ValidateReplyCmd
    {
        [Required]
        public int AuthorId { get; }

        [Required]
        public int QuestionId { get; }

        [Required]
        public string Text { get; }

        public ValidateReplyCmd(int authorid,int questionid,string text)
        {
            AuthorId = authorid;
            QuestionId = questionid;
            Text = text;
        }


    }
}
