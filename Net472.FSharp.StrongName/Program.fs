// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "%s" (MathNet.Numerics.Control.Describe ())
    0 // return an integer exit code
