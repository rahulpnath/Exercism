module Clock

type Clock = { hours:int; minutes:int }

let correctMinutes minutes = 
    if minutes < 0
    then 1440 + (minutes % 1440)
    else minutes

let createFromMinutes minutes =
    let corrected = correctMinutes minutes
    let (h,m) = System.Math.DivRem(corrected,60)
    {hours=h%24;minutes=m}

let create hours minutes = createFromMinutes (hours*60 + minutes)

let add minutes {hours=h;minutes=m} = 
    createFromMinutes (minutes + (h *60) + m)

let subtract minutes {hours=h;minutes=m} =
    createFromMinutes ((h*60) + m - minutes)

let display {hours=h;minutes=m} = sprintf "%02i:%02i" h m