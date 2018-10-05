(**
# 1.1 Arrows as functions

```
g . f
```

**)

// example exacutable
let f (a: int) = float(a * 2)
let g (b: float) = b.ToString()

let implicit fandg = f >> g

(**
# 1.2 Properties of Composition

Haskell
```
f :: A -> B
g :: B -> C
h :: C -> D
h . (g . f) == (h . g) . f == h . g . f
```

F#
```
val f: 'a -> 'b
val g: 'b -> 'c
val h: 'c -> 'd
``

**)

let h (c: string) = c + "-A"

// (f >> g) >> h = f >> (g >> h) = f >> g >> h

let comp1 f g h = f >> g >> h
let comp2 f g h = (f >> g) >> h
let comp3 f g h = f >> (g >> h)

comp1 f g h 2
comp2 f g h 2
comp3 f g h 2

(**

identity function

```
id :: a -> a
id x = x
```

**)

let id a = a

(**

```
f . id == f
id . f == f
```

**)

// id >> f = f >> id = f

let idCheck1 = id >> f
let idCheck2 = f >> id
let idCheck3 = f