using System.IO;

namespace Calabonga.TemplateProcessor.Engine.Transformer
{
    public class TemplateLoadFromFile : ITemplateLoad
    {
        public ITemplateValidate Validate()
        {
            return new TemplateValidate();
        }
    }
}