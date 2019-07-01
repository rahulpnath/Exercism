module Isogram
open System

let isIsogram (str:string) = 
    let characters = str |> Seq.filter Char.IsLetter |> Seq.map Char.ToUpper
    characters |> Seq.length = (characters |> Seq.distinct |> Seq.length)