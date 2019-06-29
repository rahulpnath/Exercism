module Bob
open System

let hasWords (input: string) = input |> Seq.filter Char.IsLetter |> Seq.length > 0
let isFullCaps (input:string) = hasWords input && input.ToUpper() = input
let isQuestion (input:string) = input.Trim().EndsWith("?")

let response (input: string): string = 
 match input with
 | x when String.IsNullOrWhiteSpace x -> "Fine. Be that way!"
 | x when isFullCaps x && isQuestion x -> "Calm down, I know what I'm doing!"
 | x when isFullCaps x -> "Whoa, chill out!"
 | x when isQuestion x -> "Sure."
 | _ -> "Whatever."