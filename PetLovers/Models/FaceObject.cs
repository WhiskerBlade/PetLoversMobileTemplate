using NcnnDotNet.OpenCV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetLovers.Models
{
    public sealed class FaceObject
    {

        #region Constructors

        public FaceObject()
        {
            this.Rect = new Rect<float>();
        }

        #endregion

        #region Properties

        public Rect<float> Rect
        {
            get;
            set;
        }

        public int Label
        {
            get;
            set;
        }

        public float Prob
        {
            get;
            set;
        }

        #endregion

    }
}
