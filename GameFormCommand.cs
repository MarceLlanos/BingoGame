namespace BingoGame
{
    class GameFormCommand : ICommand
    {
        IInputForm reciever;

        public GameFormCommand(IInputForm reciever)
        {
            this.reciever = reciever;
        }

        public string executeInputOption()
        {
            return reciever.OptionInput();
        }
    }
}
