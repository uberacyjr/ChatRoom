﻿using System.Collections.Generic;

namespace ChatRoom.Domain.Models
{
    public class ChatReportDto
    {
        public string AggregationLevel { get; set; }
        public string Description { get; set; }
        public List<string> Descriptions { get; set; }
    }
}