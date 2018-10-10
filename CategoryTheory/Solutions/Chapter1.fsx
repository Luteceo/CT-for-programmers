(**
    Implement, as best as you can, the identity function in your fa- vorite language (or the second favorite,
    if your favorite language happens to be Haskell).
**)

let id a = a

(**
    Implement the composition function in your favorite language.
    It takes two functions as arguments and returns a function that is their composition.
**)

let compose f g a = g(f(a))

// compose two functions
let g = compose (fun (x: int) -> float(x) * 2.0) (fun x -> x.ToString())