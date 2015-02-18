using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayProject
{
    public abstract class RailwayItem
    {
        protected int _numberOfJoints;

        protected int _jointsEngaged;
        protected int JointsEngaged
        {
            get
            {
                return _jointsEngaged;
            }
            set
            {
                if (value >= 0 && value <= this._numberOfJoints)
                {
                    _jointsEngaged = value;
                }
                else
                {
                    throw new Exception("Exception in \"JointsEngaged\" property, the value of engaged joints is out of permitted range");
                }
            }
        }

        public bool Join(RailwayItem item)
        {
            if (this == item)
            {
                throw new Exception("An item cannot be joined with itself");
            }
            if (this.HasNonEngagedJoints() && item.HasNonEngagedJoints())
            {
                this.JointsEngaged++;
                item.JointsEngaged++;
                return true;
            }
            return false;
        }

        public bool HasNonEngagedJoints()
        {
            return this.JointsEngaged < this._numberOfJoints;
        }
    }
}
