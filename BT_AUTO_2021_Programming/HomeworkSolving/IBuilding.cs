﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programming.HomeworkSolving
{
    interface IBuilding
    {
        double ComputingArea();
        int GetNumberOfFloors();
        int GetTotalNumberOfRooms();
        double TotalCapacity();
    }
}
