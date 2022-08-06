using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FreeCouse.Shared.Dtos
{
    public class Response<T>
    {
        private static T data;

        public T Data { get; private set; }

        [JsonIgnore]
        public int StatusCode { get; private set; }

        [JsonIgnore]
        public bool IsSuccessful { get; private set; }

        public List<string> Errors { get; set; }

        //Static Factory Method
        public static Response<T>Success(T data, int statusCode)
        {
            return new Response<T> { Data = data, StatusCode = statusCode, IsSuccessful = true };
        }

        public static Response<T>Success(int statusCode)
        {
            return new Response<T> { Data = default(T), StatusCode = statusCode, IsSuccessful = true };
        }

        public static Response<T>Fail(List<string> errors, int statusCode)
        {
            return new Response<T>
            {
                Errors = errors, 
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }
        public static Response<T>Fail(string error,int statuscode)
        {
            return new Response<T> { Errors = new List<string>() {error},StatusCode=statuscode,IsSuccessful=false };
        }
    }     
        
}
