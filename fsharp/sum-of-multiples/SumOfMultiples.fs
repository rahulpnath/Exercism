module SumOfMultiples

let multiplesUpTo upperBound num  = [num..num..upperBound-1]

let sum (numbers: int list) (upperBound: int): int = 
 numbers
 |> Seq.filter (fun x -> x <> 0)
 |> Seq.collect (multiplesUpTo upperBound)
 |> Seq.distinct
 |> Seq.sum
