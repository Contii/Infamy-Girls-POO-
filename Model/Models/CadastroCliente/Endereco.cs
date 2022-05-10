using Common;
using System;
using System.Collections.Generic;

namespace Domain.Models.CadastroCliente
{
    public class Endereco
    {
        #region Constants
        const int MAX_NOTIFICATIONS = 10;
        #endregion

        #region Private fields
        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount = 0;
        #endregion

        #region Properties
        public Guid EnderecoID { get; set; }
        public string Estado { get; private set; }
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Cep { get; private set; }

        public int NotificationsCount { get { return _notificationsCount; } }
        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        public bool IsValid { get { return _notificationsCount == 0; } }
        public override int GetHashCode()
        {
            return 93 * (EnderecoID == null ? 1 : EnderecoID.GetHashCode());
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Endereco)) return false;
            if ((obj as Endereco).EnderecoID.Equals(EnderecoID)) return true;
            return false;
        }
        #endregion

        #region Constructors
        public Endereco(string estado, string cidade, string bairro, string rua, string numero, string cep)
        {
            Estado  = estado;
            Cidade  = cidade;
            Bairro  = bairro;
            Rua     = rua;
            Numero  = numero;
            Cep     = cep;
        }
        public Endereco(string estado, string cidade, string bairro, string rua, string numero, string cep, Guid enderecoID) : this(estado, cidade, bairro, rua, numero, cep)
        {
            EnderecoID = Guid.NewGuid();
        }
        #endregion

        #region Methods
        public void AtualizarEndereco(string estado, string cidade, string bairro, string rua, string numero, string cep)
        {
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
            Cep = cep;
        }
        #endregion

        #region Validations Methods
        private void ApplyValidations()
        {

            if (Estado == null || Estado.Trim().Length == 0)
                addNotification(new Notification("Estado", "não pode ser nulo ou vazio"));

            if (Cidade == null || Cidade.Trim().Length == 0)
                addNotification(new Notification("Cidade", "não pode ser nulo ou vazio"));

            if (Bairro == null || Bairro.Trim().Length == 0)
                addNotification(new Notification("Bairro", "não pode ser nulo ou vazio"));

            if (Rua == null || Rua.Trim().Length == 0)
                addNotification(new Notification("Rua", "não pode ser nulo ou vazio"));

            if (Numero == null || Numero.Trim().Length == 0)
                addNotification(new Notification("Numero", "não pode ser nulo ou vazio"));

            if (Cep == null || Cep.Trim().Length == 0)
                addNotification(new Notification("CEP", "não pode ser nulo ou vazio"));

            if (_notificationsCount > 0)
                throw new Exception(" Erros na declaração da classe");
        }

        private void addNotification(Notification notification)
        {

            if (_notificationsCount == MAX_NOTIFICATIONS)
                throw new Exception("Limite excedido para as notificações");

            _notifications[_notificationsCount] = notification;

        }
        #endregion
    }
}
