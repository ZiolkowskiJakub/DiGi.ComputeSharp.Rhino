using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.ComputeSharp.Geometry.Classes
{
    public class GooAdministrativeAreal2D : GooSerializableObject<GIS.Classes.AdministrativeAreal2D>
    {
        public GooAdministrativeAreal2D()
            : base()
        {
        }

        public GooAdministrativeAreal2D(GIS.Classes.AdministrativeAreal2D administrativeAreal2D)
            : base(administrativeAreal2D)
        {

        }

        public GooAdministrativeAreal2D(GooAdministrativeAreal2D gooAdministrativeAreal2D)
            : base(gooAdministrativeAreal2D)
        {

        }

        public override IGH_Goo Duplicate()
        {
            return new GooAdministrativeAreal2D(Value);
        }

    }

    public class GooAdministrativeAreal2DParam : GooPresistentParam<GooAdministrativeAreal2D, GIS.Classes.AdministrativeAreal2D>
    {
        public override Guid ComponentGuid => new Guid("eaccaeae-956d-48e8-8485-280a55ae9c6e");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooAdministrativeAreal2DParam()
            : base()
        {
        }
    }
}
