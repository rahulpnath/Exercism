module RobotName
type RobotType = {name:string;}

let mkRobot() = {name = "HK123"}

let name robot = robot.name 

let reset robot =   {name = "HG134"}