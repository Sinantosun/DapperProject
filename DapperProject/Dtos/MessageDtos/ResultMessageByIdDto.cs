﻿namespace DapperProject.Dtos.MessageDtos
{
    public class ResultMessageByIdDto
    {
        public int MessageId { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string MessageContent { get; set; }
    }
}