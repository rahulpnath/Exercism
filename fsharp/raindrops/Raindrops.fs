module Raindrops
let convert (number: int): string = 
    [(3,"Pling");(5,"Plang");(7,"Plong")] 
    |> List.filter (fun (i, _) -> number % i = 0)
    |> List.fold (fun acc (_,t) -> acc + t) ""
    |> fun x -> if x = "" then string number else x