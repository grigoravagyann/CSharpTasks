namespace Shop.Models.Responses.User
{
    public class GetUsersListResponse
    {
        public List<GetUserResponse> Users { get; set; }
        public int TotalCount { get; set; }
    }
}
