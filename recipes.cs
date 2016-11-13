namespace foodie
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class recipes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDRecipes { get; set; }

        public string instructions { get; set; }

        public decimal? timeNeeded { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        [StringLength(35)]
        public string photo { get; set; }

        public int? IDfrom { get; set; }

        public virtual regions2 regions2 { get; set; }
    }
}
