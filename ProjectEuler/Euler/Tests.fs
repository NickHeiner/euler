﻿module Tests

open Euler

(* I would much rather use NUnit but I haven't figured out how *)

open Microsoft.VisualStudio.TestTools.UnitTesting
open FsUnit.MsTest

[<TestClass>]
type UnitTest() = 
    [<TestMethod>]
    member x.sampleAnswer () = 
        sumNums 10 |> should equal 23

    [<TestMethod>]
    member x.realAnswer () = 
        sumNums 1000 |> should equal 233168

    [<TestMethod>]
    member x.fib () = 
        fibUpTo 90 |> should equal [1; 1; 2; 3; 5; 8; 13; 21; 34; 55; 89]


