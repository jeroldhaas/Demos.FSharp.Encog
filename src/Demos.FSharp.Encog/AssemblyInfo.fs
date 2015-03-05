namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Demos.FSharp.Encog")>]
[<assembly: AssemblyProductAttribute("Demos.FSharp.Encog")>]
[<assembly: AssemblyDescriptionAttribute("Encog with F#")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
