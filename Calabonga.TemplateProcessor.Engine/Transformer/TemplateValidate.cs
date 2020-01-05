namespace Calabonga.TemplateProcessor.Engine.Transformer
{
    public class TemplateValidate : ITemplateValidate
    {
        public ITemplateTransform Transform()
        {
            return new TemplateTransform();
        }

        public void ThrowError()
        {
            
        }
    }
}