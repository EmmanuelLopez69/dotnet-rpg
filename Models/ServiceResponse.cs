using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.rpg.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }

        public bool Succes { get; set; } = true;
        public String Message { get; set; } = string.Empty;
    }
}