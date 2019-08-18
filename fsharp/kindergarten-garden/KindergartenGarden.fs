module KindergartenGarden
open System

type Plant = Grass = 'G' | Clover = 'C' | Radishes = 'R' | Violets = 'V'
let toPlants (plantCodes:string) : Plant [] = 
    plantCodes.ToCharArray()
    |> Array.map (LanguagePrimitives.EnumOfValue)

let children = ["Alice";"Bob";"Charlie";"David";"Eve";"Fred";"Ginny";"Harriet";"Ileana";"Joseph";"Kincaid";"Larry"]
let indexOfChild child = children |> List.findIndex ((=) child)

let plants (diagram: string) student =
    let childIndex = indexOfChild student
    diagram.Split([|"\n"|], StringSplitOptions.RemoveEmptyEntries)
    |> Array.map (fun row -> row.[childIndex*2..childIndex*2+ 1])
    |> Array.collect (toPlants)
    |> Array.toList