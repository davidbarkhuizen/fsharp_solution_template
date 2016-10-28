module project.program

open System

[<EntryPoint>]
let main (args : string[]) =

    let greeting = "hello world"
   
    printfn "%s" greeting

    0