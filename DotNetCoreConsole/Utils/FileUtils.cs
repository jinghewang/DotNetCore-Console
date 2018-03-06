namespace DotNetCoreConsole.Utils
{
    public class FileUtils
    {
        public static string getDirectorySeparatorChar(string path){
            if(string.IsNullOrWhiteSpace(path)){
                return "/";
            }else{
                return path.Substring(0,1);
            }
        }
    }
}