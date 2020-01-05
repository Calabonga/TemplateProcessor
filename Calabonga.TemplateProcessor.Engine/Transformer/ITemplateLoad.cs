namespace Calabonga.TemplateProcessor.Engine.Transformer
{
    public interface ITemplateLoad: ITemplateError
    {
        ITemplateValidate Validate();
    }
}