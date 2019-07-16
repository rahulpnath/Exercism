module IsbnVerifier
open System
open System.Text.RegularExpressions

let isbnSum (isbn:string) = 
    isbn.ToCharArray()
    |> Array.indexed
    |> Array.sumBy (fun x -> match x with
                             | (_, 'X') -> 10
                             | (i, a) -> (10-i) * (int)(a.ToString()))

let normalize (isbn:string) = isbn.Replace("-","")

let isValidFormat (isbn:string) = 
    let regex = @"^\d{9}[\d|X]$"
    Regex.IsMatch(isbn, regex)

let isValid (isbn:string) = 
    let  isbn = isbn.Replace("-", "")
    if isValidFormat isbn
    then 
        let sum = isbnSum isbn
        sum % 11 = 0
    else false
        
