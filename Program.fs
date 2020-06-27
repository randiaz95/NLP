// Learn more about F# at http://fsharp.org

open System

module NLP = 
    let splitAtSpaces(text: string) = 
        text.Split ' '
        |> Array.toList

    let wordCount text = 
        let words = splitAtSpaces text
        let numWords = words.Length
        let distinctWords = List.distinct words
        let numDups = numWords - distinctWords.Length
        (numWords, numDups)
    
    let showWordCount text = 
        let numWords, numDups = wordCount text
        printfn "--> %d words in the text" numWords
        printfn "--> %d duplicate in the text" numDups

[<EntryPoint>]
let main argv =
    printfn "Quick Test"
    NLP.showWordCount "ninety nine beers on the wall ninety eight bottles of beers"
    0 // return an integer exit code
