namespace BingoGame
{
    public interface IRange
    {
        int GetStart();
        int GetEnd();
        void SetStart(int start);
        void SetEnd(int end);
    }
}