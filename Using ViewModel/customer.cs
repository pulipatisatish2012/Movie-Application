public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribToNewsLetter { get; set; }
        public MembershipType MembershipTypes { get; set; }
        
    }
}
