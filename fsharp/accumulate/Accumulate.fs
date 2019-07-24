module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    [ for item in input do yield (func item) ]