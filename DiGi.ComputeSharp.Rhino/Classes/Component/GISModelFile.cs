using DiGi.Core.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.ComputeSharp.Geometry.Rhino.Classes
{
    public class GISModelFile : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("652f95e1-7e8b-4b02-996b-6993089630bb");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public GISModelFile()
          : base("GIS.GISModelFile", "GIS.GISModelFile",
              "Loads GISModelFile from file",
              "DiGi", "DiGi.GIS")
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
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_FilePath() { Name = "Path", NickName = "Path", Description = "File Path", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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
                result.Add(new Param(new GooGISModelFileParam() { Name = "GISModelFile", NickName = "GISModelFile", Description = "DiGi GIS GISModelFile", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
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

            index = Params.IndexOfInputParam("Path");
            string path = null;
            if (index == -1 || !dataAccess.GetData(index, ref path) || path == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Path? path_Temp = path;

            if (!path_Temp.Value.FileExists)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "File does not exist or is invalid.");
                return;
            }

            GIS.Classes.GISModelFile gISModelFile = new GIS.Classes.GISModelFile(path_Temp.Value);

            index = Params.IndexOfOutputParam("GISModelFile");
            if (index != -1)
            {
                dataAccess.SetData(index, gISModelFile);
            }
        }
    }
}