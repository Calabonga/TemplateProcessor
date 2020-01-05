namespace Calabonga.TemplateProcessor.Engine.Transformer
{
    public interface ITemplateTransformer
    {
        ITemplateLoad LoadFromFile();

        ITemplateLoad LoadFromString();

    }
}
