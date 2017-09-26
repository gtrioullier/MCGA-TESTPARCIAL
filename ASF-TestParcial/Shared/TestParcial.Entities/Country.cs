using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;

namespace TestParcial.Entities
{
    [Serializable]
    [DataContract]
    public partial class Country 
    {
        [DataMember]
        [Browsable(false)]
        public int Id { get; set; }


        [DataMember]
        public string Name { get; set; }
    }
}
