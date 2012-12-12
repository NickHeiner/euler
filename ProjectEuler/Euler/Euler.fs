module Euler

    (* If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
       The sum of these multiples is 23.

       Find the sum of all the multiples of 3 or 5 below 1000. *)
    let sumNums upperBound =
        seq { 0 .. upperBound - 1 }
        |> Seq.filter (fun i -> i % 3 = 0 || i % 5 = 0)
        |> Seq.sum