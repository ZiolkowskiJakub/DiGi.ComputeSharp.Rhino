using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.ComputeSharp.Geometry.Rhino.Classes
{
    public class RhinoInfo : GH_AssemblyInfo
    {
        public override string Name => "DiGi.ComputeSharp.Geometry.Rhino";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("eca86148-a64f-4abf-a46f-c88b6e82ee1f");

        //Return a string identifying you or your company.
        public override string AuthorName => "Jakub Ziolkowski";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}