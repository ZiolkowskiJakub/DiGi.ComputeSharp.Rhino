using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.ComputeSharp.Geometry.Rhino.Classes
{
    public class IntersectionResult3D : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("68f17db5-2053-4ee7-97dc-74c3d0d296ad");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public IntersectionResult3D()
          : base("ComputeSharp.IntersectionResult3D", "ComputeSharp.IntersectionResult3D",
              "Creates IntersectionResult3D",
              "DiGi", "DiGi.ComputeSharp")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooMesh3DParam() { Name = "Mesh3D", NickName = "Mesh3D", Description = "Mesh3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooMesh3DParam() { Name = "Mesh3Ds", NickName = "Mesh3Ds", Description = "Mesh3Ds", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));


                Grasshopper.Kernel.Parameters.Param_Integer param_Integer = new Grasshopper.Kernel.Parameters.Param_Integer() { Name = "Solid", NickName = "Solid", Description = "Are meshes solid?", Access = GH_ParamAccess.item, Optional = true };
                param_Integer.SetPersistentData(true);
                result.Add(new Param(param_Integer, ParameterVisibility.Voluntary));

                Grasshopper.Kernel.Parameters.Param_Number param_Number = new Grasshopper.Kernel.Parameters.Param_Number() { Name = "Tolerance", NickName = "Tolerance", Description = "Tolerance", Access = GH_ParamAccess.item, Optional = true };
                param_Number.SetPersistentData(DiGi.Core.Constans.Tolerance.Distance);
                result.Add(new Param(param_Number, ParameterVisibility.Voluntary));
                
                return result.ToArray();
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooIntersectionResult3DParam() { Name = "IntersectionResult3D", NickName = "IntersectionResult3D", Description = "DiGi IntersectionResult3D", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                return result.ToArray();
            }
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("Mesh3D");
            Mesh3D mesh3D = null;
            if (index == -1 || !dataAccess.GetData(index, ref mesh3D) || mesh3D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Mesh3Ds");
            List<Mesh3D> mesh3Ds = new List<Mesh3D>();
            if (index == -1 || !dataAccess.GetDataList(index, mesh3Ds) || mesh3Ds == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            bool solid = true;
            index = Params.IndexOfInputParam("Solid");
            if (index != -1)
            {
                dataAccess.GetData(index, ref solid);
            }

            double tolerance = DiGi.Core.Constans.Tolerance.Distance;
            index = Params.IndexOfInputParam("Tolerance");
            if (index != -1)
            {
                dataAccess.GetData(index, ref tolerance);
            }

            DiGi.Geometry.Spatial.Classes.IntersectionResult3D intersectionResult3D = Spatial.Create.IntersectionResult3D(mesh3D, mesh3Ds, solid, System.Convert.ToSingle(tolerance));

            index = Params.IndexOfOutputParam("IntersectionResult3D");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooIntersectionResult3D(intersectionResult3D));
            }
        }
    }
}