namespace DenounceBeasts.API.Models.Entities
{
    public class MunicipalityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? PostalCode { get; set; }
        public bool IsActive { get; set; } = true;
    }

}
