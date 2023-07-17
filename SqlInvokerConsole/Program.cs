// See https://aka.ms/new-console-template for more information

using CommandLine;
using SqlInvokerConsole;
using SqlInvokerLib;

Parser.Default.ParseArguments<Options>(args)
  .WithParsed<Options>(o =>
  {
    var connectionStringToUse =File.Exists(o.ConnectionString) ? File.ReadAllText(o.ConnectionString) : o.ConnectionString;
    DdlInvoker.Invoke(connectionStringToUse, File.ReadAllText(o.File)); 
  });

Console.Read();
