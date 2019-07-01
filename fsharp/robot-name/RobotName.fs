module RobotName

let generateName () = 
    let random = System.Random()
    let randomChar1 = ['A'..'Z'].[random.Next(25)]
    let randomChar2 = ['A'..'Z'].[random.Next(25)]
    sprintf "%c%c123" 
        randomChar1 
        randomChar2 

type RobotType = {name:string;}

let mkRobot() = {name = generateName()}

let name robot = robot.name 

let reset robot =   {name = generateName()}