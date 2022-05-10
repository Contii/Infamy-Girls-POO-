using Common;
using System;

namespace Domain.Models.CadastroProduto
{
    public class PecaSuperior : Produto
    {
        #region Constants
        const int MAX_NOTIFICATIONS = 10;
        #endregion

        #region Private fields
        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount = 0;
        #endregion

        #region Properties
        public decimal MedidaBustoMin { get; private set; }
        public decimal MedidaBustoMax { get; private set; }
        public decimal MedidaSubBustoMin { get; private set; }
        public decimal MedidaSubBustoMax { get; private set; }
        #endregion

        #region Constructors
        public PecaSuperior(string nome, decimal valor, Guid categoria, string tamanho, string cor,
            decimal medidaBustoMin, decimal medidaBustoMax, decimal medidaSubBustoMin, decimal medidaSubBustoMax, Guid? produtoID = null)
            : base(nome, valor, categoria, tamanho, cor, produtoID)
        {
            MedidaBustoMin = medidaBustoMin;
            MedidaBustoMax = medidaBustoMax;
            MedidaSubBustoMin = medidaSubBustoMin;
            MedidaSubBustoMax = medidaSubBustoMax;
        }
        #endregion

        #region Methods

        #endregion

        #region Validations Methods
        private void ApplyValidations()
        {
            if (MedidaBustoMin <= 0 || MedidaBustoMax < MedidaBustoMin)
                addNotification(new Notification("MedidaBusto", "não pode ser nula, negativa ou vazia"));

            if (MedidaSubBustoMin <= 0 || MedidaSubBustoMax < MedidaSubBustoMin)
                addNotification(new Notification("MedidaSubBusto", "não pode ser nula, negativa ou vazia"));

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