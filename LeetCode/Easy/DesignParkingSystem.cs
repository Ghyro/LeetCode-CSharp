using System;
using System.Collections.Generic;
using System.Text;

namespace Easy
{
  class DesignParkingSystem
  {
      private int big;
      private int medium;
      private int small;
      public DesignParkingSystem(int big, int medium, int small)
      {
        this.big = big;
        this.medium = medium;
        this.small = small;
      }

      public bool AddCar(int carType)
      {
        if (carType < 1 || carType > 3)
          return false;
        switch (carType)
        {
          case 1:
            if (this.big <= 0)
              return false;
            this.big--;
            return true;
          case 2:
            if (this.medium <= 0)
              return false;
            this.medium--;
            return true;
          case 3:
            if (this.small <= 0)
              return false;
            this.small--;
            return true;
        }
        return false;
      }
  }
}
