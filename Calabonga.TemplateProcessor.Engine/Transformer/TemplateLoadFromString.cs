namespace Calabonga.TemplateProcessor.Engine.Transformer
{
    public class TemplateLoadFromString : ITemplateLoad
    {
        public ITemplateValidate Validate()
        {
            return new TemplateValidate();
        }

        public void ThrowError()
        {
            
        }
    }
}