//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parking
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cars
    {
        public int id { get; set; }
        public string carNumber { get; set; }
        public System.DateTime timeStart { get; set; }
        public Nullable<System.DateTime> timeEnd { get; set; }
        public Nullable<bool> isPaid { get; set; }
    }
}
