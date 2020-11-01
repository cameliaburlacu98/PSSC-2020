using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Tema6.Inputs
{
    public class SendAckToQuestionOwnerCmd
    {
        [Required]
        public int ReplyId { get; }

        [Required]
        public int QuestionId { get; }

        [Required]
        public string Answer { get; }

        public SendAckToQuestionOwnerCmd(int replyid, int questionid, string answer)
        {
            ReplyId = replyid;
            QuestionId = questionid;
            Answer = answer;
        }
    }
}
