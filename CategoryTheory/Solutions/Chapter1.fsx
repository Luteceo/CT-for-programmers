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

(**
    Write a program that tries to test that your composition function respects identity.
**)

let testFunction a = a + 1

let h1 = compose id testFunction
let h2 = compose testFunction id

h1 4
h2 4

(**
    Q: Is the world-wide web a category in any sense? Are links morphisms?
    
    A: If there is a link from page A to page B and a link from page B to page C,
    it doesn't mean there is link from page A to page C
**)

(**
    Q: Is Facebook a category, with people as objects and friendships as morphisms?
    
    A: Well it would mean that I'm also a frend on mine (like identity function)
**)

(**
    Q: When is a directed graph a category?
    
    A: When each node has also an edge to itself
**)
    