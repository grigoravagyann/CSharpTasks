namespace Shop.Models.Responses.Product
{
    public class GetProductsListResponse
    {
        public List<GetProductResponse> Products { get; set; }
        public int TotalCount { get; set; }
    }
}
