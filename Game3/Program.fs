// Learn more about F# at http://fsharp.org

open System
open MySDL2

[<EntryPoint>]
let main argv =
    MySDL2.Say.hello("foo")
    printfn "Hello World from F#!"
    0 // return an integer exit code
