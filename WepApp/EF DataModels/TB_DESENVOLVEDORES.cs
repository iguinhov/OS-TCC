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
    
//    public partial class TB_DESENVOLVEDORES
//    {
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
//        public TB_DESENVOLVEDORES()
//        {
//            this.TB_PROJETO_DESENVOLVEDORES = new HashSet<TB_PROJETO_DESENVOLVEDORES>();
//            this.TB_PROJETO_ITENS = new HashSet<TB_PROJETO_ITENS>();
//            this.TB_ITENS_FINALIZADOS = new HashSet<TB_ITENS_FINALIZADOS>();
//        }
    
//        public int ID_DEV { get; set; }
//        public Nullable<int> ID_USUARIO { get; set; }
//        public string NOME_DESENVOLVEDOR { get; set; }
    
//        public virtual TB_USUARIOS TB_USUARIOS { get; set; }
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
//        public virtual ICollection<TB_PROJETO_DESENVOLVEDORES> TB_PROJETO_DESENVOLVEDORES { get; set; }
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
//        public virtual ICollection<TB_PROJETO_ITENS> TB_PROJETO_ITENS { get; set; }
//        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
//        public virtual ICollection<TB_ITENS_FINALIZADOS> TB_ITENS_FINALIZADOS { get; set; }
//    }
//}
