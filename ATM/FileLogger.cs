using System;
using System.Collections.Generic;
using System.IO;

namespace ATM
{
    public static class FileLogger
    {
        private static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private static List<Log> transActions = new List<Log>();
        private static List<Log> frauds = new List<Log>();


        public static void EndOfDay()
        {

            string fileName = $"EOD_{DateMaker()}.txt";
            string filePath = Path.Combine(desktopPath, fileName);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Bilgilendirme Mesajları:");
                foreach (Log log in transActions)
                {
                    writer.WriteLine(log.Date + " " + log.Message);
                }

                writer.WriteLine();

                writer.WriteLine("Hatalı Denemeler:");
                foreach (Log fraud in frauds)
                {
                    writer.WriteLine(fraud.Date + " " + fraud.Message);
                }
            }

            Console.WriteLine($"EOD file written to {filePath}");
        }

        private static string DateMaker()
        {
            return DateTime.Now.ToString("ddMMyyyy");
        }

        public static void SetTransactionLogs(string islem)
        {
            Log log = new Log(DateMaker(), islem);
            transActions.Add(log);
        }
        public static void SetFraudLogs(string islem)
        {
            Log log = new Log(DateMaker(), islem);
            frauds.Add(log);
        }

    }
}