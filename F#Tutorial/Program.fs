open System.IO

let deleteFolder (folderPath: string) =

    try

        Directory.Delete(folderPath, true)
        printfn "Directory Deleted"

    with
    | :? DirectoryNotFoundException ->

        printfn "Directory doesnt exist"

    | :? IOException as ex ->

        printfn "Error deleting folder '%s': %s" folderPath ex.Message

let folderPath = "testfolder"
deleteFolder folderPath