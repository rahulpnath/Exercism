module Hamming

let distance (strand1: string) (strand2: string): int option = 
    if (strand1.Length <> strand2.Length)
    then None
    else
    let items1 = strand1.ToCharArray() |> Seq.indexed
    let items2 = strand2.ToCharArray() |> Seq.indexed
    let length = Seq.concat [items1;items2] |> Seq.distinct |> Seq.length
    Some (System.Math.Abs(strand1.Length - length))