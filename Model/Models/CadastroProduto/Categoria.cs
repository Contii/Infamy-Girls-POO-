using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.CadastroProduto
{
    public class Categoria
    {
        #region Constants
        const int MAX_NOTIFICATIONS = 10;
        #endregion

        #region Private fields
        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount = 0;
        #endregion

        #region Properties
        public Guid? CategoriaID { get; set; }
        public string Nome { get; set; }

        public int NotificationsCount { get { return _notificationsCount; } }
        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        public bool IsValid { get { return _notificationsCount == 0; } }
        public override bool Equals(object obj)
        {
            if (!(obj is Categoria)) return false;
            if ((obj as Categoria).CategoriaID.Equals(CategoriaID)) return true;
            return false;
        }
        public override int GetHashCode()
        {
            return 93 * (CategoriaID == null ? 1 : CategoriaID.GetHashCode());
        }
        #endregion

        #region Constructors
        public Categoria(string nome)
        {
            Nome = nome;
        }
        public Categoria(string nome, Guid? categoriaID = null) : this(nome)
        {
            CategoriaID = (categoriaID == null) ? Guid.NewGuid() : categoriaID;
        }
        #endregion

        #region Methods
        public void AtualizarNome(string nome)
        {
            Nome = nome;
        }
        #endregion

        #region Validations Methods
        private void ApplyValidations()
        {

            if (Nome == null || Nome.Trim().Length == 0)
                addNotification(new Notification("Nome", "não pode ser nulo ou vazio"));

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
