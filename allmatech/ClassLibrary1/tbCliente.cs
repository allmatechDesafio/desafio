namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbCliente")]
    public partial class tbCliente
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string nome { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string email { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string cpf { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string carromarca { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string carromodelo { get; set; }
    }
}
