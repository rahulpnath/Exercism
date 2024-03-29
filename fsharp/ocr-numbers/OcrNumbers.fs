module OcrNumbers

let matchNumber number = 
    match number with
    | " _ | ||_|   " -> "0"
    | "     |  |   " -> "1"
    | " _  _||_    " -> "2"
    | " _  _| _|   " -> "3"
    | "   |_|  |   " -> "4"
    | " _ |_  _|   " -> "5"
    | " _ |_ |_|   " -> "6"
    | " _   |  |   " -> "7"
    | " _ |_||_|   " -> "8"
    | " _ |_| _|   " -> "9"
    | _ -> "?"

let chunkStringBySize size str =
    let rec loop (s:string) accum =
        if  size < s.Length 
        then loop (s.[size..]) (s.[0..size-1]::accum)
        else s::accum
    (loop str []) |> List.rev

let parseNumberBlock (input: string list) = 
    input |> String.concat "" |> matchNumber

let parseLine (line: string list) =
    line 
    |> List.map (chunkStringBySize 3)
    |> List.transpose
    |> List.map parseNumberBlock
    |> String.concat ""

let parse (input: string list) = 
    input 
    |> List.chunkBySize 4
    |> List.map parseLine
    |> String.concat ","

let convert (input: string list) = 
    let hasExpectedLineSize = input.Length % 4 = 0
    let hasExpectedColumnSize = 
        input |> List.forall (fun x -> x.Length % 3 = 0)
    if hasExpectedLineSize && hasExpectedColumnSize 
    then Some (parse input)
    else None