using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.AdapteeClasses
{
    // The 'Target' class
    // Class for achieving abstraction
    public abstract class IFilm
    {
        protected int year { get; set; }
        protected string genre { get; set; }
        protected string director { get; set; }

        public abstract void Display();
    }
}
