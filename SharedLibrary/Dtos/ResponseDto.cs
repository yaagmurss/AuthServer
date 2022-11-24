using System.Text.Json.Serialization;

namespace SharedLibrary.Dtos
{
    public class ResponseDto<T> where T : class //Bu response T tipinde bir data tutacak
    {
        public T Data { get; private set; } 
        public int StatusCode { get; private set; }

        [JsonIgnore]
        public bool IsSuccessfull { get; private set; } 
        public ErrorDto Error { get; private set; } 

        public static ResponseDto<T> Success(T data ,int statusCode)
        {
            return new ResponseDto<T> { Data = data, StatusCode = statusCode , IsSuccessfull = true};
        }

        public static ResponseDto<T> Success(int StatusCode)
        {
            return new ResponseDto<T> { Data=default, StatusCode = StatusCode, IsSuccessfull = true };
        }

        public static ResponseDto<T> Fail(ErrorDto errorDto, int statusCode)
        {
            return new ResponseDto<T> { Error = errorDto, StatusCode = statusCode, IsSuccessfull = false };
        }

        public static ResponseDto<T> Fail(string errorMessage, int statusCode, bool isShow)
        {
            var errorDto = new ErrorDto(errorMessage, isShow);
            return new ResponseDto<T> { Error = errorDto, StatusCode = statusCode , IsSuccessfull = false };
        }
    }
}
