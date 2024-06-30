using System.Diagnostics;

namespace StoreManage.Patterns
{
    public class FacadeCMD
    {
        public FacadeCMD() { }
        public void runNotepad()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("notepad.exe");
            Process.Start(processStartInfo);
        }

        public void openGitWeb()

        //@ round string, round data là dữ liệu thô
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://localhost:7199/");
            Process.Start(processStartInfo);
        }
        public void makeFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
