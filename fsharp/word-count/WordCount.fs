module WordCount

open System;

let countWords (phrase: string) = 
    phrase.Split([|" "; ","; "\\n"|], StringSplitOptions.RemoveEmptyEntries)
    |> Array.groupBy id
    |> Array.map (fun (a,b) -> (a, b.Length))
    |> Map.ofArray
    