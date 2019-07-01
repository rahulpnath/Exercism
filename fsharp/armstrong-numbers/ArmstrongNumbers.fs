module ArmstrongNumbers

let chartoint n = ((n |> int) - ('0' |> int))

let isArmstrongNumber (number: int): bool = 
    let numberString = number.ToString()
    let sumOfDigits = 
        numberString.ToCharArray()
        |> Seq.map chartoint
        |> Seq.sumBy (fun n -> pown n numberString.Length)

    sumOfDigits = number