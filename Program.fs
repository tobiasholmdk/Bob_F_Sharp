// Learn more about F# at http://fsharp.org

open System


let bobresponse input = 
    if input = "How are you?" then "Sure"
    elif input = "YELL AT HIM" then "Whoa, chill out!"
    elif input = "HOW ARE YOU?" then "Calm down i know what i'm doing"
    elif input = "" then "Fine. Be that way!"
    else "Whatever"

[<EntryPoint>]
let main argv =
    let keeplooping = true;
    while keeplooping do
        let input = Console.ReadLine();
        let bobstring = bobresponse(input);
        printfn "%s" bobstring
    0 // return an integer exit code
