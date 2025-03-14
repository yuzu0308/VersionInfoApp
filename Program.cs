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

            // バージョン情報を取得
            Version version = assemblyName.Version;

            // バージョン情報をコンソールに表示
            Console.WriteLine($"Assembly Version: {version}");

            // Git のコミットハッシュを表示
            string gitCommitHash = ThisAssembly.Git.Commit;
            Console.WriteLine($"Git Commit Hash: {gitCommitHash}");
        }
    }
}
