open System
open FSharp.Configuration

type Yaml = YamlConfig<YamlText = "foo: 22">

[<EntryPoint>]
let main argv =
    let yaml = Yaml()
    printfn "foo = %d" yaml.foo
    
    0
