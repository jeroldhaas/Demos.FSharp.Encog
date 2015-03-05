#load "Scripts/load-project.fsx"
open Demos.FSharp.Encog

let num = Library.hello 42
printfn "%i" num




#r "../../packages/FSharp.Data/lib/net40/FSharp.Data.dll"
open FSharp.Data

[<Literal>]
let stockEx = "http://ichart.finance.yahoo.com/table.csv?s=MSFT"
type ytp = FSharp.Data.CsvProvider<stockEx>
let symbols = [
                "MSFT";
                "YHOO";
                "INTL";
              ]
let results =
    let al s = ytp.AsyncLoad("http://ichart.finance.yahoo.com/table.csv?s=" + s) in
    symbols
    |> List.toSeq
    |> Seq.map al
    |> Async.Parallel
    |> Async.RunSynchronously
    |> Seq.zip symbols




#r "../../packages/encog-dotnet-core/lib/net35/encog-core-cs.dll"
open Encog

