namespace Common
{
    public class Notification
    {
        public string Propriedade { get; private set; }
        public string Mensagem { get; private set; }
        public Notification(string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }

        public override string ToString()
        {
            return $"{Propriedade} => {Mensagem}";
        }
    }
}
