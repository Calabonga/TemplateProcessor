using System;
using System.IO;
using System.Linq;
using Calabonga.TemplateProcessor.Engine.Transformer;

namespace Calabonga.TemplateProcessor.ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var transformer = new TemplateTransformer();

            transformer
                .LoadFromFile()
                .Validate()
                .Transform()
                .Save();

            transformer
                .LoadFromString()
                .Validate()
                .Transform()
                .Save();


            NormalImplementation(args);
        }

        private static void NormalImplementation(string[] args)
        {
            // Calabonga: Key configuration file (2019-12-28 03:42 Program)
            const string entityNameKey = "[ENTITY_NAME]";
            const string controllerNameKey = "[CONTROLLER_NAME]";

            if (!args.Any())
            {
                Console.WriteLine("Arguments not found. Nothing to process");
                return;
            }

            // Calabonga:  (2019-12-28 03:42 Program)
            var entityName = args[0];
            var controllerName = args[1];

            var fileName = "Template.txt";
            var file = Path.Combine(Environment.CurrentDirectory, fileName);

            if (!File.Exists(file))
            {
                Console.WriteLine("Template not found. Nothing to process.");
                return;
            }

            // Calabonga: FileLoader (2019-12-28 03:53 Program)
            var data = File.ReadAllText(file);


            // Calabonga: TemplateProcess (2019-12-28 03:53 Program)
            data = data
                .Replace(entityNameKey, entityName)
                .Replace(controllerNameKey, controllerName);

            // Calabonga: Output Service (2019-12-28 03:53 Program)
            File.WriteAllText("output.txt", data);

            Console.WriteLine("Done");
        }
    }
}
