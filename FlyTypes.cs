using System.Collections.Generic;

namespace FlyingDutchman
{
    public class FlyTypes : List<IFlyType>
    {
        public FlyTypes()
        {
//            this.Add(new FlyTypeSquare());
            this.Add(new FlyTypePointToTop());
            this.Add(new FlyTypePointToLeft());
            this.Add(new FlyTypePointToBottom());
            this.Add(new FlyTypePointToRight());
        }
    }
}
