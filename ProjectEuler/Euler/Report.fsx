#load "Euler.fs"

open Euler

[
    sumNums 1000
]
|> List.iteri (fun index -> printfn "Solution #%d:\t%A" (index + 1))

