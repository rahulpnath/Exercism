module BeerSong

let reciteLine number = 
    let remaining = match number with 
                    |1 -> "No more bottle" 
                    |2 -> "1 bottle"
                    |_ -> sprintf "%i bottles" (number-1)
    let current = number |> if number = 1 then sprintf "%i bottle" else sprintf "%i bottles" 
    let count = if number = 1 then "it" else "one"
    
    match number with 
    |0 -> [
        "No more bottles of beer on the wall, no more bottles of beer."
        "Go to the store and buy some more, 99 bottles of beer on the wall."
        ]
    |1 -> [
        "1 bottle of beer on the wall, 1 bottle of beer."
        "Take it down and pass it around, no more bottles of beer on the wall." 
        ]
    |_ -> [
        sprintf "%s of beer on the wall, %s of beer." current current
        sprintf "Take %s down and pass it around, %s of beer on the wall." count remaining 
        ]

let recite (startBottles: int) (takeDown: int) = 
    [startBottles-takeDown+1..startBottles] 
    |> List.rev
    |> List.collect (fun x -> "" :: (reciteLine x))
    |> List.tail
 
 

