using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfac
{
    public interface IEmployee
    {
        string Name
        {
            get;
            set;
        }
        string Designation
        {
            get;
            set;
        }
    }

    public interface IEvaluatedEmployee : IEmployee
    {
        int KPI
        {
            get;
            set;
        }
    }

    public interface IManagementLevelEmployee : IEmployee
    {
        IEvaluatedEmployee EvaluateSubordinate(IEvaluatedEmployee employee);
    }

    public interface ICSuite_Privilege : IEmployee
    {
        bool TerminateEmployee(IEvaluatedEmployee executive);
    }
}
