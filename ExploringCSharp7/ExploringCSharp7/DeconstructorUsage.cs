using System.Diagnostics;
using System.Security.AccessControl;
using ExploringCSharp7.Interfaces;

namespace ExploringCSharp7
{
    public class DeconstructorUsage : IDeconstructor
    {
        int ENo;
        string Ename, EDesig;
        double ESal;

        public DeconstructorUsage(int ENo, string EName, string EDesig, double ESal)
        {
            this.ENo = ENo;
            this.Ename = EName;
            this.EDesig = EDesig;
            this.ESal = ESal;
        }

        public void Deconstruct(out int ENo, out string EName, out string EDesig, out double ESal)
        {
            ENo = this.ENo;
            EName = this.Ename;
            EDesig = this.EDesig;
            ESal = this.ESal;
        }
    }
}
