using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.ComputeSharp.Geometry.Rhino.Classes
{
    /// <summary>
    /// Provides assembly information for the DiGi.ComputeSharp.Geometry.Rhino Grasshopper library.
    /// </summary>
    public class RhinoInfo : GH_AssemblyInfo
    {
        /// <summary>
        /// Gets the name of the Grasshopper assembly.
        /// </summary>
        public override string Name => "DiGi.ComputeSharp.Geometry.Rhino";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        /// <summary>
        /// Gets the 24x24 pixel icon representing this Grasshopper library.
        /// </summary>
        public override Bitmap? Icon => null;

        //Return a short string describing the purpose of this GHA library.
        /// <summary>
        /// Gets the description of this Grasshopper library.
        /// </summary>
        public override string Description => "";

        /// <summary>
        /// Gets the unique Guid identifying this Grasshopper library.
        /// </summary>
        public override Guid Id => new("eca86148-a64f-4abf-a46f-c88b6e82ee1f");

        //Return a string identifying you or your company.
        /// <summary>
        /// Gets the name of the author/company.
        /// </summary>
        public override string AuthorName => "Jakub Ziolkowski";

        //Return a string representing your preferred contact details.
        /// <summary>
        /// Gets the contact details of the author/company.
        /// </summary>
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}