using Common;
using System;

namespace Domain.Models.CadastroProduto
{
    public class PecaInferior : Produto
    {
        #region Constants
        const int MAX_NOTIFICATIONS = 10;
        #endregion

        #region Private fields
        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount = 0;
        #endregion

        #region Properties
        public decimal MedidaCinturaMin { get; private set; }
        public decimal MedidaCinturaMax { get; private set; }
        #endregion

        #region Constructors
        public PecaInferior(string nome, decimal valor, Guid categoria, string tamanho, string cor,
            decimal medidaCinturaMin, decimal medidaCinturaMax, Guid? produtoID = null)
            : base(nome, valor, categoria, tamanho, cor, produtoID)
        {
            MedidaCinturaMin = medidaCinturaMin;
            MedidaCinturaMax = medidaCinturaMax;
        }
        #endregion

        #region Methods

        #endregion

        #region Validations Methods
        private void ApplyValidations()
        {
            if (MedidaCinturaMin <= 0 || MedidaCinturaMax < MedidaCinturaMin)
                addNotification(new Notification("MedidaCintura", "não pode ser nula, negativa ou vazia"));

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