using Common;
using Domain.Models.CadastroProduto;
using System;
using System.Collections.Generic;

namespace Domain.Models.CadastroCliente
{
    public class Cliente
    {
        #region Constants
        const int MAX_NOTIFICATIONS = 10;
        #endregion

        #region Private fields
        private Notification[] _notifications = new Notification[MAX_NOTIFICATIONS];
        private int _notificationsCount = 0;
        #endregion

        #region Properties
        public Guid? ClienteID { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string DataNascimento { get; private set; }
        //public string DataNascimentoShotString { get { return DataNascimento.ToShortDateString(); } }
        public Guid EnderecoID { get; set; }
        //public Endereco Endereco { get; set; }
        public Guid MedidaID { get; set; }
        //public Medida Medida { get; set; }

        public int NotificationsCount { get { return _notificationsCount; } }
        public IList<Notification> Notifications { get { return Array.AsReadOnly(_notifications); } }
        public bool IsValid { get { return _notificationsCount == 0; } }
        public override int GetHashCode()
        {
            return 93 * (ClienteID == null ? 1 : ClienteID.GetHashCode());
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Cliente)) return false;
            if ((obj as Cliente).ClienteID.Equals(ClienteID)) return true;
            return false;
        }
        #endregion

        #region Constructors
        public Cliente(string nome, string cpf, string rg, string dataNascimento, Guid enderecoID, Guid medidaID)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            EnderecoID = enderecoID;
            MedidaID = medidaID;
        }
        public Cliente(string nome, string cpf, string rg, string dataNascimento, Guid enderecoID, Guid medidaID,
                             Guid? clienteID) : this(nome, cpf, rg, dataNascimento, enderecoID, medidaID)
        {

            ClienteID = clienteID;
        }
        #endregion

        #region Methods
        public void AtualizarCliente(string nome, string cpf, string rg, string dataNascimento,
                            Guid enderecoID, Guid medidaID, Guid? clienteID = null)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            EnderecoID = enderecoID;
            MedidaID = medidaID;
            ClienteID = clienteID;
        }
        //public bool serveOProduto(Produto produto)
        //{
        //    if (produto is PecaInferior)
        //    {
        //        if (Medida.MedidaCintura >= (produto as PecaInferior).MedidaCinturaMin && Medida.MedidaCintura <= (produto as PecaInferior).MedidaCinturaMax)
        //        {
        //            return true;
        //        }
        //    }
        //    if (produto is PecaSuperior)
        //    {
        //        if ((Medida.MedidaBusto >= (produto as PecaSuperior).MedidaBustoMin && Medida.MedidaBusto <= (produto as PecaSuperior).MedidaBustoMax) &&
        //            (Medida.MedidaSubBusto >= (produto as PecaSuperior).MedidaSubBustoMin && Medida.MedidaSubBusto <= (produto as PecaSuperior).MedidaSubBustoMax))
        //        {
        //            return true;
        //        }
        //    }
        //    if (produto is PecaSuperiorInferior)
        //    {
        //        if ((Medida.MedidaBusto >= (produto as PecaSuperiorInferior).MedidaBustoMin && Medida.MedidaBusto <= (produto as PecaSuperiorInferior).MedidaBustoMax) &&
        //            (Medida.MedidaSubBusto >= (produto as PecaSuperiorInferior).MedidaSubBustoMin && Medida.MedidaSubBusto <= (produto as PecaSuperiorInferior).MedidaSubBustoMax) &&
        //            (Medida.MedidaCintura >= (produto as PecaSuperiorInferior).MedidaCinturaMin && Medida.MedidaCintura <= (produto as PecaSuperiorInferior).MedidaCinturaMax))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        #endregion

        #region Validations Methods
        private void ApplyValidations(){

            if (Nome == null || Nome.Trim().Length == 0)
                addNotification(new Notification("NOME", "não pode ser nulo ou vazio"));

            if (Rg == null || Rg.Trim().Length == 0)
                addNotification(new Notification("RG", "não pode ser nulo ou vazio"));

            if (Cpf == null || Cpf.Trim().Length == 0)
                addNotification(new Notification("CPF", "não pode ser nulo ou vazio"));

            if (_notificationsCount > 0)
                throw new Exception(" Erros na declaração da classe");
        }

        private void addNotification(Notification notification){

            if (_notificationsCount == MAX_NOTIFICATIONS)
                throw new Exception("Limite excedido para as notificações");

            _notifications[_notificationsCount] = notification;

        }
        #endregion
    }
}
