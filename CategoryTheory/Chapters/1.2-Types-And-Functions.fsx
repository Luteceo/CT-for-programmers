open System

(**
# 2.3 What are types

Haskell
```
x :: Integer
```

F#
```
let x: bigint
```

**)

(**

Haskell
```
f :: Bool -> Bool
```

F#
```
val f: bool -> bool
```

**)

(**

```
f :: Bool -> Bool
f x = undefined
```

**)

let f (x: bool) = raise (NotImplementedException())

(**

```
f :: Bool -> Bool
f = undefined
```

**)

let (f':bool -> bool) = raise (NotImplementedException())

(**

2.4 Why Do We Need a Mathematical Model?

**)

(**

```
fact n = product [1..n]
```

**)

let fact n = [1..n] |> List.fold (*) 1