
using System;
using System.Collections.Generic;
using System.IO;
using ULSPack;

namespace WorkflowAnalyzer
{
    public class UlsEntryListGenerator
    {
        public UlsEntryListGenerator(string ulsLogs)
        {
            PluginHelper.UlsLogEntries = new List<IULSLogEntry>();

            using (StringReader stringReader = new StringReader(ulsLogs))
            {
                string line = string.Empty;

                //Get rid of the header line
                stringReader.ReadLine();

                do
                {
                    line = stringReader.ReadLine();
                    if (line != null)
                    {
                        string[] bufferedEntry = new string[9];
                        string[] entry = line.Split('\t');

                        entry.CopyTo(bufferedEntry, 0);

                        try
                        {
                            PluginHelper.UlsLogEntries.Add(new ULSLogEntry(bufferedEntry));
                        }
                        catch (Exception e)
                        {
                            var test = e;
                        }
                    }

                } while (line != null);
            }
        }
    }
}
