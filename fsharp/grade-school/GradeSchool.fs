module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let add (student: string) (grade: int) (school: School): School = 
    match school.TryFind(grade) with
    | None -> school.Add(grade, [student])
    | Some students -> school.Add(grade, (student :: students) |> List.sort)

let roster (school: School): string list = 
    school |> Map.toSeq |> Seq.fold (fun acc (_, students) -> acc @ students) []

let grade (number: int) (school: School): string list = 
    match school.TryFind number with
    | None -> []
    | Some students -> students
