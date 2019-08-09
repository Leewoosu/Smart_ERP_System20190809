using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DbContextFactory
    {
        private const string FilePath = @"D:\EF.log";
        private const string DateTimeCustomFormat = "yyyy/MM/dd HH:mm:ss";
        private static readonly string[] PrefixList = { "SELECT", "INSERT", "UPDATE", "DELETE" };

        private static void Write(string log)
        {
            if (PrefixList.All(x => log.StartsWith(x) == false))
                return;

            string contents;

            if (File.Exists(FilePath))
                contents = File.ReadAllText(FilePath);
            else
                contents = "";

            string time = DateTime.Now.ToString(DateTimeCustomFormat);
            string formattedLog = $"[{time}]\r\n{log}\r\n------------------------------\r\n\r\n";

            StringBuilder builder = new StringBuilder(contents);
            builder.Append(formattedLog);
            //contents = formattedLog + contents;
            //File.WriteAllText(FilePath, contents);

            File.WriteAllText(FilePath, builder.ToString());
        }

        public static DbContext Create(string nameOrConnectionString, DbCompiledModel model)
        {
            DbContext context = new DbContext(nameOrConnectionString, model);

            context.Database.Log = Write;

            return context;
        }
    }
}
