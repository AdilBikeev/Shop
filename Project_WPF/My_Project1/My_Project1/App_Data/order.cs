//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My_Project1.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int Id { get; set; }
        public string name_subject { get; set; }
        public int ID_subject { get; set; }
        public int price { get; set; }
        public string run_time { get; set; }
    
        public virtual subject_order subject_order { get; set; }
    }
}
