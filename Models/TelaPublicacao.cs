namespace findPet.Models
{
    public class TelaPublicacaoModel
    {
        public string Nome { get; set; } = string.Empty;
        public string Raca { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Porte { get; set; } = string.Empty;
        public string LocalDesaparecimento { get; set; } = string.Empty;
        public DateTime DataDesaparecimento { get; set; }
        public string Chip { get; set; } = string.Empty;
        public string Legenda { get; set; } = string.Empty;
        public IFormFile Imagem { get; set; }
        public string ImageFileName { get; set; }
    }

    public class TelaPublicacaoFeed
    {
        public string Nome { get; set; } = string.Empty;
        public string Raca { get; set; } = string.Empty;
        public string Cor { get; set; } = string.Empty;
        public string Porte { get; set; } = string.Empty;
        public string LocalDesaparecimento { get; set; } = string.Empty;
        public DateTime DataDesaparecimento { get; set; }
        public string Chip { get; set; } = string.Empty;
        public string Legenda { get; set; } = string.Empty;
        public string ImageFileName { get; set; }
    }


}