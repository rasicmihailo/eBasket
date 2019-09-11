using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public enum UserStatus //user status
    {
        Offline = 1,
        Active = 2,
        InTraining = 3
    }

    public enum UserType
    {
        Coach = 1,
        Player = 2
    }

    public enum UserLevel
    {
        Introductory = 1, // 3 - 8 god
        Foundational = 2, //8 - 13 god
        Advanced = 3, //12 - 17 god
        Senior = 4 //15 - 18+
    }

    public enum TrainingStatus
    {
        Created = 1,
        Playing = 2,
        Finished = 3
    }

    public enum JerseyTop
    {
        Plain = 1,
        Hoops = 2, 
        Stripes = 3
    }

}
