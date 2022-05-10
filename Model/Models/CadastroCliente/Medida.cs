using Common;
using System;
using System.Collections.Generic;

namespace Domain.Models.CadastroCliente
{
    public class Medida
    {
        #region Constants
        const int MAX_NOTIFICATIONS = 10;
        #endregion

        #region Private fields
        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount = 0;
        #endregion

        #region Properties
        public Guid MedidaID { get; set; }
        public decimal MedidaBusto { get; private set; }
        public decimal MedidaSubBusto { get; private set; }
        public decimal MedidaCintura { get; private set; }

        public int NotificationsCount { get { return _notificationsCount; } }
        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        public bool IsValid { get { return _notificationsCount == 0; } }
        public override int GetHashCode()
        {
            return 93 * (MedidaID == null ? 1 : MedidaID.GetHashCode());
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Medida)) return false;
            if ((obj as Medida).MedidaID.Equals(MedidaID)) return true;
            return false;
        }
        #endregion

        #region Constructors
        public Medida(decimal medidaBusto, decimal medidaSubBusto, decimal medidaCintura)
        {
            MedidaBusto = medidaBusto;
            MedidaSubBusto = medidaSubBusto;
            MedidaCintura = medidaCintura;
        }
        public Medida(decimal medidaBusto, decimal medidaSubBusto, decimal medidaCintura, Guid medidaID) : this(medidaBusto, medidaSubBusto, medidaCintura)
        {
            MedidaID = Guid.NewGuid();
        }
        #endregion

        #region Methods
        public void AtualizarMedida(decimal medidaBusto, decimal medidaSubBusto, decimal medidaCintura)
        {
            MedidaBusto = medidaBusto;
            MedidaSubBusto = medidaSubBusto;
            MedidaCintura = medidaCintura;
        }
        #endregion

        #region Validations Methods
        private void ApplyValidations()
        {

            if (MedidaBusto <= 0)
                addNotification(new Notification("MedidaBusto", "não pode ser nula, negativa ou vazia"));

            if (MedidaSubBusto <= 0)
                addNotification(new Notification("MedidaSubBusto", "não pode ser nula, negativa ou vazia"));

            if (MedidaCintura <= 0)
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
