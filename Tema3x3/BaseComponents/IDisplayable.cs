namespace Tema3x3.BaseComponents
{
    public interface IDisplayable
    {
        string GetRepresentation(string userInput);
        bool VerifyInput(string userInput);
    }
}