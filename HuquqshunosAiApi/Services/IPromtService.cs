namespace HuquqshunosAiApi.Services
{
    public interface IPromptService
    {
        Task<string> TriggerOpenAI(string prompt);
    }
}
