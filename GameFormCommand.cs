namespace BingoGame
{
    class GameFormCommand : ICommand
    {
        IReciever reciever;

        public GameFormCommand(IReciever reciever)
        {
            this.reciever = reciever;
        }

        public string executeGameOption()
        {
            return this.reciever.GameOptionFormComplete();
        }

        public string executeCardOption()
        {
            return this.reciever.CardsOptionFormComplete();
        }
    }
}
