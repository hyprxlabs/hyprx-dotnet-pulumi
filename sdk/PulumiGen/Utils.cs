
namespace PulumiGen;

public static class Utils
{
    public static string GetProjectRoot()
    {
        var dir = Environment.CurrentDirectory;
        var gi = Path.Join(dir, ".git");
        while (!Directory.Exists(gi))
        {
            dir = Path.GetDirectoryName(dir);
            if (dir == null)
            {
                break;
            }

            gi = Path.Join(dir, ".git");
        }

        if (dir == null)
        {
            throw new Exception("Could not find project root");
        }

        return dir;
    }
}