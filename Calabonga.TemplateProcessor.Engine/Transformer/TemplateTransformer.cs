namespace Calabonga.TemplateProcessor.Engine.Transformer
{
    public class TemplateTransformer : ITemplateTransformer
    {
        public ITemplateLoad LoadFromFile()
        {
            return new TemplateLoadFromFile();
        }

        public ITemplateLoad LoadFromString()
        {
            return new TemplateLoadFromFile();
        }
    }
}