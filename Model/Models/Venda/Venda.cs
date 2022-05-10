using Common;
using Domain.Models.CadastroCliente;
using System;
using System.Collections.Generic;

namespace Domain.Models.Venda
{
    public class Venda
    {
        #region Constants
        const int MAX_NOTIFICATIONS = 10;
        #endregion

        #region Private fields
        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount = 0;

        private const int MAX_ITENS = 10;
        private int quantidadeItensVendidos = 0;
        private decimal Total = 0;

        #endregion

        #region Properties
        public Guid? VendaID { get; set; }
        public Guid ClienteID { get; private set; }
        public Cliente Cliente { get; private set; }

        public int NotificationsCount { get { return _notificationsCount; } }
        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        public bool IsValid { get { return _notificationsCount == 0; } }
        public override bool Equals(object obj)
        {
            if (!(obj is Venda)) return false;
            if ((obj as Venda).VendaID.Equals(VendaID)) return true;
            return false;
        }
        public override int GetHashCode()
        {
            return 93 * (VendaID == null ? 1 : VendaID.GetHashCode());
        }
        #endregion

        #region Constructors
        public Venda(Guid clienteID, Guid? vendaID)
        {
            VendaID = (VendaID == null) ? Guid.NewGuid() : vendaID;
            ClienteID = clienteID;
        }
        #endregion

        #region Methods
        public int ObterQuantidadeDeItens() {
            return quantidadeItensVendidos;
        }
        #endregion

        #region Validations Methods
        private void ApplyValidations()
        {

            if (Cliente == null)
                AddNotification(new Notification("Cliente", "não pode ser nulo ou vazio"));

            if (_notificationsCount > 0)
                throw new Exception(" Erros na declaração da classe");
        }

        private void AddNotification(Notification notification)
        {

            if (_notificationsCount == MAX_NOTIFICATIONS)
                throw new Exception("Limite excedido para as notificações");

            _notifications[_notificationsCount] = notification;

        }
        #endregion
    }
}