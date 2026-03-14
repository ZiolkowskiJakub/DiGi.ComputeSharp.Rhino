using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper;
using Grasshopper.Kernel;
using Grasshopper.Kernel.Data;
using System;
using System.Collections.Generic;

namespace DiGi.ComputeSharp.Geometry.Rhino.Classes
{
    public class Shading : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("34fc9797-1569-481e-9884-f1694e3e6216");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Shading()
          : base("ComputeSharp.Shading", "ComputeSharp.Shading",
              "Calculates Shading",
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
                List<Param> result =
                [
                    new Param(new GooPolygonalFace3DParam() { Name = "PolygonalFace3Ds", NickName = "PolygonalFace3Ds", Description = "PolygonalFace3Ds", Access = GH_ParamAccess.list }, ParameterVisibility.Binding),
                    new Param(new GooVector3DParam() { Name = "Direction", NickName = "Direction", Description = "Direction", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];

                Grasshopper.Kernel.Parameters.Param_Number param_Number = new() { Name = "Tolerance", NickName = "Tolerance", Description = "Tolerance", Access = GH_ParamAccess.item, Optional = true };
                param_Number.SetPersistentData(DiGi.Core.Constans.Tolerance.Distance);
                result.Add(new Param(param_Number, ParameterVisibility.Voluntary));

                return [.. result];
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooPolygonalFace3DParam() { Name = "PolygonalFace3Ds", NickName = "PolygonalFace3Ds", Description = "DiGi PolygonalFace3Ds", Access = GH_ParamAccess.tree }, ParameterVisibility.Binding),
                ];
                return [.. result];
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

            index = Params.IndexOfInputParam("PolygonalFace3Ds");
            List<PolygonalFace3D> polygonalFace3Ds = [];
            if (index == -1 || !dataAccess.GetDataList(index, polygonalFace3Ds) || polygonalFace3Ds == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Direction");
            Vector3D? direction = null;
            if (index == -1 || !dataAccess.GetData(index, ref direction) || direction == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            double tolerance = DiGi.Core.Constans.Tolerance.Distance;
            index = Params.IndexOfInputParam("Tolerance");
            if (index != -1)
            {
                dataAccess.GetData(index, ref tolerance);
            }

            DataTree<GooPolygonalFace3D> dataTree = new();

            index = Params.IndexOfOutputParam("PolygonalFace3Ds");
            if (index != -1)
            {
                List<List<PolygonalFace3D>?>? polygonalFace3Ds_Temp = Spatial.Query.Shading(polygonalFace3Ds, direction, tolerance);
                if (polygonalFace3Ds_Temp is not null)
                {
                    for (int i = 0; i < polygonalFace3Ds_Temp.Count; i++)
                    {
                        List<PolygonalFace3D>? polygonalFace3DsList = polygonalFace3Ds_Temp[i];
                        if (polygonalFace3DsList == null)
                        {
                            continue;
                        }

                        GH_Path gH_Path = new(i);
                        for (int j = 0; j < polygonalFace3DsList.Count; j++)
                        {
                            dataTree.Add(new GooPolygonalFace3D(polygonalFace3DsList[j]), gH_Path);
                        }
                    }
                }
            }

            dataAccess.SetDataTree(index, dataTree);
        }
    }
}