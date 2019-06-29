module Pangram
open System

let isPangram (input: string): bool = 
 let distinctLettersInInput = 
    input.ToLower()
    |> Seq.distinct 
    |> Seq.filter Char.IsLetter
    
 distinctLettersInInput |> Seq.sort |> Seq.toList = ['a' .. 'z']


