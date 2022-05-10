using Common;
using System;
using System.Collections.Generic;

namespace Domain.Models.CadastroProduto
{
    public abstract class Produto
    {
        #region Constants
        const int MAX_NOTIFICATIONS = 10;
        #endregion

        #region Private fields
        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount = 0;
        #endregion

        #region Properties
        public Guid? ProdutoID { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Guid CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }

        public int NotificationsCount { get { return _notificationsCount; } }
        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        public bool IsValid { get { return _notificationsCount == 0; } }
        public override bool Equals(object obj)
        {
            if (!(obj is Produto)) return false;
            if ((obj as Produto).ProdutoID.Equals(ProdutoID)) return true;
            return false;
        }
        public override int GetHashCode()
        {
            return 93 * (ProdutoID == null ? 1 : ProdutoID.GetHashCode());
        }
        #endregion

        #region Constructors
        public Produto(string nome, decimal valor, Guid categoriaID, string tamanho, string cor)
        {
            Nome = nome;
            Valor = valor;
            CategoriaID = categoriaID;
            Tamanho = tamanho;
            Cor = cor;
        }
        public Produto(string nome, decimal valor, Guid categoriaID, string tamanho, string cor, Guid? produtoID = null) : this(nome, valor, categoriaID, tamanho, cor)
        {
            ProdutoID = (produtoID == null) ? Guid.NewGuid() : produtoID;
        }
        #endregion

        #region Methods
        public void AtualizarNome(string nome)
        {
            Nome = nome;
        }
        public void AtualizarValor(decimal valor)
        {
            Valor = valor;
        }
        public void AtualizarTamanho(string tamanho)
        {
            Tamanho = tamanho;
        }
        public void AtualizarCor(string cor)
        {
            Cor = cor;
        }
        #endregion

        #region Validations Methods
        private void ApplyValidations()
        {

            if (Nome == null || Nome.Trim().Length == 0)
                addNotification(new Notification("Nome", "não pode ser nulo ou vazio"));

            if (Valor <= 0)
                addNotification(new Notification("ValorUnitario", "não pode ser nulo, negativo ou vazio"));

            if (Tamanho == null || Tamanho.Trim().Length == 0)
                addNotification(new Notification("Tamanho", "não pode ser nulo ou vazio"));

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
