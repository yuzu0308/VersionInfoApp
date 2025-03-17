using System;
using System.Reflection;

namespace VersionInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 現在のアセンブリの情報を取得
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = assembly.GetName();

            var informationalVersion = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

            Console.WriteLine(informationalVersion);

            // バージョン情報を取得
            Version version = assemblyName.Version;

            // バージョン情報をコンソールに表示
            Console.WriteLine($"Assembly Version: {version}");

           
        }
    }
}
