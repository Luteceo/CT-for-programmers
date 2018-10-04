module CategoryTheory
(**
# 1.1 Arrows as functions

```
f :: A -> B
``

**)

val f: 'a -> 'b

(**

```
g :: B -> C
```

**)

val g: 'b -> 'c

(**
# 1.2 Properties of Composition

```
f :: A -> B
g :: B -> C
h :: C -> D
h . (g . f) == (h . g) . f == h . g . f
```

**)

val h: 'c -> 'd