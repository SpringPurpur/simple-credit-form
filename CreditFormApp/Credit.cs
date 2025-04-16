namespace ProiectPAW
{
    [Serializable]
    public class Credit
    {
        public double Ammount { get; set; }
        public int TermMonths { get; set; }
        public double InterestRate { get; set; }
        public DateTime StartDate { get; set; }

        public Credit()
        {

        }
        public Credit(double Ammount, int TermMonths, double InterestRate, DateTime StartDate)
        {
            this.Ammount = Ammount;
            this.TermMonths = TermMonths;
            this.InterestRate = InterestRate;
            this.StartDate = StartDate;
        }

        public override string? ToString()
        {
            string format = this.StartDate + " - " + this.Ammount + " RON - " + this.InterestRate / 100 + "%";
            return format;
        }
    }
}