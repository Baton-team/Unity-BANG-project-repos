using System;
using System.IO;

using UnityEngine;

namespace Com.BATONteam.mobileBANGonline
{
    public static class LogsManager : Debug
    {
        private static readonly string logFilePath = "Logs/mobileBANGonlineLog.txt";

        ///<summary>
        /// Write here our log. It will be saved in the fixed log.txt
        ///<sumary>
        public static void WriteLog(string message)
        {
            try
                {
                    // Отримати поточну дату та час для логу
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    // Форматування повідомлення логу з датою, часом та переданим повідомленням
                    string logEntry = $"{timestamp} - {message}";

                    // Записати лог у вказаний файл
                    using (StreamWriter writer = new StreamWriter(logFilePath, true))
                    {
                        writer.WriteLine(logEntry);
                    }
                }
                catch (Exception ex)
                {
                    // Обробка помилок запису логу
                    Console.WriteLine($"Помилка запису логу: {ex.Message}");
                }
        }
    }
}