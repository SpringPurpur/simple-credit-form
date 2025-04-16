namespace ProiectPAW
{
    [Serializable]
    public class Client : IComparable<Client>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string CNP { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public float CreditScore { get; set; }

        public List<Credit> Credits { get; set; } = [];

        public Client(string LastName, string FirstName, string CNP, string Email, string PhoneNumber, float CreditScore)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.CNP = CNP;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.CreditScore = CreditScore;
        }

        public override string? ToString()
        {
            string format = this.CNP + " - " + this.LastName + " " + this.FirstName;
            return format;
        }

        public int CompareTo(Client? other)
        {
            if (other == null) return 1;
            return this.CNP.CompareTo(other.CNP);
        }

        public string FullInfo()
        {
            string format = "Nume: " + this.LastName + "\nPrenume: " + this.FirstName + "\nCNP: " + this.CNP + "\nEmail: " + this.Email + "\nNumar de telefon: " + this.PhoneNumber;
            return format;
        }
    }
}