let mutable x = 10
let mutable y = 20
let swap (x:byref<int>) (y:byref<int>) =  
    let temp = x
    x <- y
    y <- temp

swap &x &y
printf "%d %d" x y