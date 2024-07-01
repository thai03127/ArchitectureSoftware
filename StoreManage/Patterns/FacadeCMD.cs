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

        public void openWeb(string web)

        //@ round string, round data là dữ liệu thô
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo(@"C:\Program Files\Google\Chrome\Application\chrome.exe", web);
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
