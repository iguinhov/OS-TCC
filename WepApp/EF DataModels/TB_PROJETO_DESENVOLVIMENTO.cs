////------------------------------------------------------------------------------
//// <auto-generated>
////     This code was generated from a template.
////
////     Manual changes to this file may cause unexpected behavior in your application.
////     Manual changes to this file will be overwritten if the code is regenerated.
//// </auto-generated>
////------------------------------------------------------------------------------

//namespace WepApp.EF DataModels
//{
//    using System;
//    using System.Collections.Generic;
    
//    public partial class TB_PROJETO_DESENVOLVIMENTO
//    {
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
//        public TB_PROJETO_DESENVOLVIMENTO()
//        {
//            this.TB_PROJETO_DESENVOLVEDORES = new HashSet<TB_PROJETO_DESENVOLVEDORES>();
//            this.TB_PROJETO_ITENS = new HashSet<TB_PROJETO_ITENS>();
//            this.TB_ITENS_FINALIZADOS = new HashSet<TB_ITENS_FINALIZADOS>();
//            this.TB_PROJETOS_FINALIZADOS = new HashSet<TB_PROJETOS_FINALIZADOS>();
//        }
    
//        public int ID_NM_SOLICITACAO { get; set; }
//        public Nullable<int> ID_PROJETO { get; set; }
//        public string NM_VERSAO_ATUAL { get; set; }
//        public Nullable<System.DateTime> DT_CADASTRO { get; set; }
//        public Nullable<bool> FL_ENCERRADO { get; set; }
//        public Nullable<System.DateTime> DT_FINALIZADO { get; set; }
//        public string NM_VERSAO_FINAL { get; set; }
//        public Nullable<bool> FL_COMMIT_SOLUTION { get; set; }
//        public Nullable<bool> FL_VS_EM_PROD { get; set; }
//        public Nullable<System.DateTime> DT_PUBLICACAO { get; set; }
    
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
//        public virtual ICollection<TB_PROJETO_DESENVOLVEDORES> TB_PROJETO_DESENVOLVEDORES { get; set; }
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
//        public virtual ICollection<TB_PROJETO_ITENS> TB_PROJETO_ITENS { get; set; }
//        public virtual TB_PROJETOS_SISTEMAS TB_PROJETOS_SISTEMAS { get; set; }
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
//        public virtual ICollection<TB_ITENS_FINALIZADOS> TB_ITENS_FINALIZADOS { get; set; }
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
//        public virtual ICollection<TB_PROJETOS_FINALIZADOS> TB_PROJETOS_FINALIZADOS { get; set; }
//    }
//}
