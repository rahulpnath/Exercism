module QueenAttack

let create (x,y) = 
    x >= 0 && x < 8 && y >=0 && y < 8

let canAttack (q1x,q1y) (q2x,q2y) = 
    q1x = q2x ||
    q1y = q2y ||
    abs (q1x - q2x) =  abs (q1y - q2y)