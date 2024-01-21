
namespace Invoice.Api;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        RecognizeDestinationPrefixes("ToReturn");
        //modify the mapping 
        //CreateMap();
        // CreateMap<InvoiceTabInput, InvoiceTab>();
        // CreateMap<InvoiceTab, InvoiceTabToReturn>();
        // CreateMap<CustomerInput, Customer>();
        // CreateMap<Customer, CustomerToReturn>();
    }
}
