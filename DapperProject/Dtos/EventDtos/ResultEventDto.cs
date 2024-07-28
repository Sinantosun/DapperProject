﻿namespace DapperProject.Dtos.EventDtos
{
    public class ResultEventDto
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string TopDescription { get; set; }
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }
        public string BottomDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}