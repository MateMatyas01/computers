namespace ComputeShopApi.Models
{
    public class computers
    {
        [key]
        [MaxLenght(36)]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(37)")]
        public string? Brand { get; set; }

        [Column(TypeName = "varchar(30)")]
        public string? Type { get; set; }

        [Column(TypeName = "float")]
        public double Display { get; set; }



    }
}
