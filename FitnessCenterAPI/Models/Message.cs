﻿using System.ComponentModel.DataAnnotations;

namespace FitnessCenterApi.Models;

public class Message
{
    [Key]
    public int IdMessage { get; set; }

    public int IdSender { get; set; }
    public User Sender { get; set; }



    public string Text { get; set; } = string.Empty;

    public bool isDeleted { get; set; } = false;
    public bool isPinned { get; set; } = false;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    
    public int IdConversation { get; set; }
    public Conversation Conversation { get; set; }
}