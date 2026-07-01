## DiGi\.ComputeSharp\.Geometry\.Rhino\.Classes Namespace
### Classes

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.IntersectionResult3D'></a>

## IntersectionResult3D Class

Grasshopper component that calculates the intersection results of 3D meshes using ComputeSharp\.

```csharp
public class IntersectionResult3D : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → IntersectionResult3D
### Constructors

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.IntersectionResult3D.IntersectionResult3D()'></a>

## IntersectionResult3D\(\) Constructor

Initializes a new instance of the SAM\_point3D class\.

```csharp
public IntersectionResult3D();
```
### Properties

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.IntersectionResult3D.ComponentGuid'></a>

## IntersectionResult3D\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.IntersectionResult3D.Exposure'></a>

## IntersectionResult3D\.Exposure Property

Gets the exposure level for this component in the Grasshopper toolbar\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.IntersectionResult3D.Inputs'></a>

## IntersectionResult3D\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.IntersectionResult3D.Outputs'></a>

## IntersectionResult3D\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.IntersectionResult3D.SolveInstance(IGH_DataAccess)'></a>

## IntersectionResult3D\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.IntersectionResult3D.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.RhinoInfo'></a>

## RhinoInfo Class

Provides assembly information for the DiGi\.ComputeSharp\.Geometry\.Rhino Grasshopper library\.

```csharp
public class RhinoInfo
```

Inheritance [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo') → RhinoInfo
### Properties

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.RhinoInfo.AuthorContact'></a>

## RhinoInfo\.AuthorContact Property

Gets the contact details of the author/company\.

```csharp
public override string AuthorContact { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.RhinoInfo.AuthorName'></a>

## RhinoInfo\.AuthorName Property

Gets the name of the author/company\.

```csharp
public override string AuthorName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.RhinoInfo.Description'></a>

## RhinoInfo\.Description Property

Gets the description of this Grasshopper library\.

```csharp
public override string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.RhinoInfo.Icon'></a>

## RhinoInfo\.Icon Property

Gets the 24x24 pixel icon representing this Grasshopper library\.

```csharp
public override System.Drawing.Bitmap? Icon { get; }
```

#### Property Value
[System\.Drawing\.Bitmap](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap 'System\.Drawing\.Bitmap')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.RhinoInfo.Id'></a>

## RhinoInfo\.Id Property

Gets the unique Guid identifying this Grasshopper library\.

```csharp
public override System.Guid Id { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.RhinoInfo.Name'></a>

## RhinoInfo\.Name Property

Gets the name of the Grasshopper assembly\.

```csharp
public override string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.Shading'></a>

## Shading Class

Grasshopper component that calculates the shading of polygonal faces using ComputeSharp\.

```csharp
public class Shading : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Shading
### Constructors

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.Shading.Shading()'></a>

## Shading\(\) Constructor

Initializes a new instance of the SAM\_point3D class\.

```csharp
public Shading();
```
### Properties

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.Shading.ComponentGuid'></a>

## Shading\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.Shading.Exposure'></a>

## Shading\.Exposure Property

Gets the exposure level for this component in the Grasshopper toolbar\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.Shading.Inputs'></a>

## Shading\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.Shading.Outputs'></a>

## Shading\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.Shading.SolveInstance(IGH_DataAccess)'></a>

## Shading\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Rhino.Classes.Shading.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.