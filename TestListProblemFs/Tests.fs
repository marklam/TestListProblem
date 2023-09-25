module TestListProblem.Tests

open System

open Xunit
open FsUnitTyped

[<Theory>]
[<InlineData("1", 1)>]
[<InlineData("2", 2)>]
let ``convert some strings to ints`` (str : string, expected : int) =
    let actual = int str
    actual |> shouldEqual expected
