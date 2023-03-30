namespace Green.CT.Asyncify.Contracts.Requests;

public class AsyncRequestDto
{
    public AsyncRequestDto(Guid trackId,
        AsyncRequestStatus status,
        object? result)
    {
        TrackId = trackId;
        Status = status;
        Result = result;
    }
    public Guid TrackId { get; }
    public AsyncRequestStatus Status { get; }
    public object? Result { get; }
}