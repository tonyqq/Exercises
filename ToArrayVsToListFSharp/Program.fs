    open System
    open System.Collections.Generic
    open System.Diagnostics
    open System.Linq
     
//     Comparing .ToList() vs. ToArray() speed
    let seqLength = 100000
     
    let items = seq { for i = 1 to seqLength do yield i }
     
    let runTest (name, f) =
        let sw = Stopwatch()
        sw.Start()
        for i = 1 to 100 do f()
        sw.Stop()
        sw.ElapsedMilliseconds
     
    let tests = [| "ToList", (fun () -> items.ToList() |> ignore)
                   "ToArray", (fun () -> items.ToArray() |> ignore) |]
     
    tests
    |> Seq.map (fun (name, exec) -> name, runTest(name, exec))
    |> Seq.iter (fun (name, timeMs) -> printfn "%8s  %Oms" name timeMs)

    System.Console.ReadKey() |> ignore