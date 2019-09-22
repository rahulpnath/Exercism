module PigLatin

let vowelSounds = ["a"; "e"; "i"; "o"; "u"; "xr"; "yt"]
let specialConsonants = ["squ"; "thr"; "sch"; "qu"; "ch"; "th"; "rh"]

let (|StartsWith|_|) (words: string list) (input:string) =
    words |> List.tryFind input.StartsWith

let translateWord (word:string) = 
    match word with 
    | StartsWith vowelSounds _ -> word + "ay"
    | StartsWith specialConsonants startConsonant  -> 
        word.[startConsonant.Length..] + startConsonant + "ay"
    | _ -> word.[1..] + word.[0].ToString() + "ay"

let translate (input:string) = 
    input.Split(" ")
    |> Array.map translateWord
    |> String.concat " "
