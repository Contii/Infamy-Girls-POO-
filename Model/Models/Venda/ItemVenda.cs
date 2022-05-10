using Common;
using Domain.Models.CadastroProduto;
using System;
using System.Collections.Generic;

namespace Domain.Models.Venda
{
    public class ItemVenda
    {
        #region Constants
        const int MAX_NOTIFICATIONS = 10;
        #endregion

        #region Private fields
        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount = 0;
        #endregion

        #region Properties
        public Guid? ItemVendaID { get; private set; }
        public Guid ProdutoID { get; private set; }
        public Guid VendaID { get; private set; }
        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public decimal SubTotal { get { return Produto.Valor * Quantidade; } }

        public int NotificationsCount { get { return _notificationsCount; } }
        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        public bool IsValid { get { return _notificationsCount == 0; } }
        #endregion

        #region Constructors
        public ItemVenda(int quantidade, Guid produtoID, Guid vendaID)
        {
            Quantidade = quantidade;
            ProdutoID = produtoID;
            VendaID = vendaID;
        }
        public ItemVenda(int quantidade, Guid produtoID, Guid vendaID, Guid? itemVendaID = null) : this(quantidade, produtoID, vendaID)
        {
            Quantidade = quantidade;

            ItemVendaID = itemVendaID;
        }
        #endregion

        #region Methods

        #endregion

        #region Validations Methods
        private void ApplyValidations()
        {
            if (Produto == null)
                AddNotification(new Notification("Produto", "não pode ser nulo ou vazio"));

            if (Quantidade <= 0)
                AddNotification(new Notification("Quantidade", "não pode ser nula, negativa ou vazia"));

            if (_notificationsCount > 0)
                throw new Exception(" Erros na inserção do item");
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