﻿using System;
using System.Collections.Generic;
using System.Text;
using Access.Primitives.IO;
using Tema6.Inputs;
using Tema6.Outputs;
using static PortExt;

namespace Tema6
{
    public static class BoundedContext
    {
        public static Port<ValidateReplyResult.IValidateReplyResult> ValidateReply(int authorId, int questionId,
            string text)
        => NewPort<ValidateReplyCmd, ValidateReplyResult.IValidateReplyResult>(new ValidateReplyCmd(authorId, questionId, text));

        public static Port<CheckLanguageResult.ICheckLanguageResult> CheckLanguage(string text)
        => NewPort<CheckLanguageCmd, CheckLanguageResult.ICheckLanguageResult>(new CheckLanguageCmd(text));

        public static Port<SendAckToQuestionOwnerResult.ISendAckToQuestionOwnerResult> SendAckToQuestionOwner(int replyid, int questionid, string answer)
        => NewPort<SendAckToQuestionOwnerCmd, SendAckToQuestionOwnerResult.ISendAckToQuestionOwnerResult>(new SendAckToQuestionOwnerCmd(replyid, questionid, answer));

        public static Port<SendAckToReplyAuthorResult.ISendAskToReplyAuthorResult> SendAckToReplyAuthor(int replyid, int questionid, string answer)
        => NewPort<SendAckToReplyAuthorCmd, SendAckToReplyAuthorResult.ISendAskToReplyAuthorResult>(new SendAckToReplyAuthorCmd(replyid, questionid, answer));
    }
}
