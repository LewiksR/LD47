using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACatppella.Domain
{
    public class Track
    {
        public Track(Instrument instrument, int[] notes)
        {
            Instrument = instrument;
            Notes = notes;
        }

        public Instrument Instrument { get; }
        public int[] Notes { get; }
    }
}
