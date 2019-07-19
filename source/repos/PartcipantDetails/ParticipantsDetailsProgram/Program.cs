using cs_Participant;

namespace ParticipantsDetailsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant pobj = new Participant();
            pobj.Getassignments();
            pobj.Getdays();
            pobj.GetTopics();
            courses cobj = new courses();
            cobj.seccourse();
        }
    }
}
