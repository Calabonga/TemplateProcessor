namespace Calabonga.TemplateProcessor.Engine.Transformer
{
    public interface ITemplateValidate:ITemplateError
    {
        ITemplateTransform Transform();

    }
}