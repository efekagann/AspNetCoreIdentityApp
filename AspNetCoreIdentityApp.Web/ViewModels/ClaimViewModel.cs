namespace AspNetCoreIdentityApp.Web.ViewModels
{
    public class ClaimViewModel
    {
        //kimin dağıttığını öğrenmek için
        public string Issuer { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
