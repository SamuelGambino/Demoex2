//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demoex2.AppDataFile
{
    using System;
    using System.Collections.Generic;
    
    public partial class Agent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agent()
        {
            this.History_Sales1 = new HashSet<History_Sales>();
        }
    
        public int ID { get; set; }
        public int ID_Type_Agent { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Nullable<double> Phone { get; set; }
        public string Image { get; set; }
        public string Adress { get; set; }
        public Nullable<int> Priority { get; set; }
        public string Boss { get; set; }
        public Nullable<double> INN { get; set; }
        public Nullable<double> KPP { get; set; }
        public Nullable<int> ID_History_Sales { get; set; }
    
        public virtual Agent_Type Agent_Type { get; set; }
        public virtual History_Sales History_Sales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<History_Sales> History_Sales1 { get; set; }
        public int Count { get; set; }

    }
}
