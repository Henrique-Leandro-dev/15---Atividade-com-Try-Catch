using System;
using System.IO;
namespace trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Permissao app = new Permissao();
            app.Autorizar();
            try{
                using (StreamReader sr = File.OpenText("data.txt"))
                {
                    System.Console.WriteLine($"A primeira linha do arquivo é: \n {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException)
            {
                System.Console.WriteLine($"O arquivo não foi encontrado.");
            }
            catch (DirectoryNotFoundException){
                System.Console.WriteLine($"O diretório não foi encontrado.");
            }
            catch (IOException)
            {
                System.Console.WriteLine($"O arquivo não pode ser aberto.");
            }
        }
    }
}
