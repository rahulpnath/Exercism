module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }
type Instruction = Right = 'R' | Left = 'L' | Advance = 'A' 

let create direction position = { direction = direction; position = position }

let advance { direction = direction; position = (x, y) } = 
    let newPosition = match direction with
                      | North -> x, y + 1
                      | East -> x + 1, y
                      | South -> x, y - 1
                      | West -> x - 1, y
                      | _ -> x, y

    create direction newPosition

let turnRight { direction = direction; position = position } =
    let newDirection = match direction with 
                       | North  -> East
                       | East -> South
                       | South -> West
                       | West -> North
    { direction = newDirection; position = position }

let turnLeft { direction = direction; position = position } = 
    let newDirection = match direction with 
                       | North  -> West
                       | East -> North
                       | South -> East
                       | West -> South
    { direction = newDirection; position = position }

let moveSingle robot instruction  = 
    match instruction with 
    | Instruction.Advance -> advance robot
    | Instruction.Right -> turnRight robot
    | Instruction.Left -> turnLeft robot
    | _ -> robot

let move (instructions: string) robot = 
    instructions.ToCharArray()
    |> Array.map LanguagePrimitives.EnumOfValue 
    |> Array.fold moveSingle robot