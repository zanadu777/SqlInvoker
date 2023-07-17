using CommandLine.Text;
using CommandLine;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInvokerConsole
{
  public class Options
  {
    [Option('f', "file", Required = true, HelpText = "Sql file")]
    public string File  { get; set; }

    [Option('c', "ConnectionString", Required = true, HelpText = "Database Connection String")]
    public  string ConnectionString { get; set; }
  }
}
