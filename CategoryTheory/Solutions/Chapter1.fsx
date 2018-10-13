(**
    Implement, as best as you can, the identity function in your fa- vorite language (or the second favorite,
    if your favorite language happens to be Haskell).
**)

let id a = a

(**
    Implement the composition function in your favorite language.
    It takes two functions as arguments and returns a function that is their composition.
**)

// let say composition operator
// let (<.>) (g : 'b -> 'c) (f : 'a -> 'b) = f >> g
let (<.>) (f: 'a -> 'b) (g: 'b -> 'c) a = g(f(a))

// compose two functions
let composed = (fun (x: int) -> float(x) * 2.0) <.> (fun (x: float) -> string(x))

(**
    Write a program that tries to test that your composition function respects identity.
**)

let f = (+) 1
let g = string
let eq a c = g(f(a)) = c
4 |> (id <.> f <.> g) |> eq 4 &&
4 |> (f <.> id <.> g) |> eq 4 &&
4 |> (f <.> g <.> id) |> eq 4



(**
    Q: Is the world-wide web a category in any sense? Are links morphisms?
    
    A: If there is a link from page A to page B and a link from page B to page C,
    it doesn't mean there is link from page A to page C
**)

(**
    Q: Is Facebook a category, with people as objects and friendships as morphisms?
    
    A: Well it would mean that I'm also a frend on mine (like identity function). Although if we see relationship 
       as beeing able to see someone private data it could hold because I can see mine too.
       But also A friend of my friend is not necessarily my friend so the composability doesn't hold
**)

(**
    Q: When is a directed graph a category?
    
    A: When each node has also an edge to itself
**)
    