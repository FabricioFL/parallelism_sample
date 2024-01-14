public class FileManager()
{
    Task<string> writeFile = Task.Run(() => {
        // todo : handle write file logic
        return "cannot write this file, you may not have permission";
    });

    Task<string> readFile = Task.Run(() => {
        // todo: read file logic
        return "cannot write this file, you may not have permission";
    }); 
}