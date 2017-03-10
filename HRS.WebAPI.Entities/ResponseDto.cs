namespace HRS.WebAPI.Entities
{
    public class ResponseDto<T>
    {
            public T Data { get; set; }
            public int RowsCount { get; set; }
            public int PageNumber { get; set; }       
    }
}
