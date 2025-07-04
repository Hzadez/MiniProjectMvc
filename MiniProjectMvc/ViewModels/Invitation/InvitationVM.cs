﻿namespace MiniProjectMvc.ViewModels.Invitation
{
    public class InvitationVM
    {
        public int Id { get; set; }
        public string EventTitle { get; set; }
        public string PersonName { get; set; }
        public DateTime EventDate { get; set; }
        public string Status { get; set; }
        public DateTime SentAt { get; set; }
        public int PersonId { get; set; }
    }
}
