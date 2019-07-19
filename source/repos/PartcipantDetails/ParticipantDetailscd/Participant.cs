using System;

namespace cs_Participant
{
    public class Participant
    {
        /// <summary>
        /// This is the Participant Case Study with Encapsualtion
        /// </summary>
        //Here are my properties of the Participant Class
        public string particiantName;
        private string _fromOrg;
        public string courseTaken;
        private long _mobileNum;
        private string _email;
        private int Noofassignments;
        private int days;
        private int topics;
        private string v;
        #region CONSTANTS
        public const int totalDays = 140;
        public const int noOfTopics = 12;
        public const int noOfAssignments = 10;
        #endregion
        #region Encapsulatng Properties
        //Here I am encapsualting the private properties of Participant Class
        public string fromOrg
        {
            get
            {
                return _fromOrg;
            }
            set
            {
                _fromOrg = value;
            }
        }
        public long mobileNum
        {
            get; set;
        }
        public string email
        {
            get; set;
        }
        public int Assignmentsno
        {
            get;set;
        }
        public int _Days
        {
            get; set;
        }
        public int topicsCovered
        {
            get;set;
        }
        #endregion
        #region Participant Constructors
        //Here are the constructors of my Participant Class
        public Participant()
        {
            Console.WriteLine("Enter the Participant Name: ");
            this.particiantName = Console.ReadLine();
            Console.WriteLine("Enter the course taken by the Participant: ");
            this.courseTaken = Console.ReadLine();
            this.setContactDetails();
        }
        public Participant(string name, string courseTaken)
        {
            this.particiantName = name;
            this.courseTaken = courseTaken;
            this.setContactDetails();
        }

        public Participant(string name)
        {
            this.mobileNum = 9563871203;
            this.email = "participant@gmail.com";
        }
        #endregion
        private void setContactDetails()
        {
            Console.WriteLine($"Set the contact details for {this.particiantName}");
            Console.WriteLine("Which organization is the participant from: ");
            this.fromOrg = Console.ReadLine();
            Console.WriteLine("Enter praticipant's Mobile Number: ");
            this.mobileNum = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter participant's email: ");
            this.email = Console.ReadLine();
        }
        #region Assignments Details
        public void Getassignments()
        {
            Console.WriteLine("enter the number of assignments completed");
            this.Assignmentsno = Convert.ToInt32(Console.ReadLine());
            Caluculateassipercent(Assignmentsno);
        }
        public void Caluculateassipercent( int Assignmentsno)
        {
            int assipercent = (int)Math.Round((double)(Assignmentsno * 100) / noOfAssignments);
            Console.WriteLine("your assignment percentage" + assipercent);
        }
        #endregion
        #region Attendance
        public void Getdays()
        {
            Console.WriteLine("enter the number of days attended");
            this._Days = Convert.ToInt32(Console.ReadLine());
            Attendencepercent(_Days);
        }
        public void Attendencepercent(int _days)
        {
            int attendencepercent = (int)Math.Round((double)(_Days * 100) / totalDays);
            Console.WriteLine("attendence paercentage is" + attendencepercent);
            Console.ReadLine();
        }

        #endregion
        #region Topics covered
        public void GetTopics()
        {
            Console.WriteLine("enter the number of topics completed");
            topicsCovered = Convert.ToInt32(Console.ReadLine());
            topicsPercentage(topicsCovered);
        }
        public void topicsPercentage(int topicsCovered)
        {
            int topicPer = (int)Math.Round((double)(topicsCovered * 100) / noOfTopics);
            Console.WriteLine("Percentage of Topics Completed: " + topicPer);
        }
        #endregion
    }
    public class courses: Participant
    {
        public void seccourse()
        {
            Console.WriteLine("enter the no.of courses u done");
            int course = Convert.ToInt32(Console.ReadLine());
            Caluculateassipercent(course);
        }
    }
}