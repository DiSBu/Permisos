using System;

namespace Permisos.Domain.Exceptions
{
    public class InvalidPermisionException : Exception
    {
        public InvalidPermisionException(string permision, Exception ex)
            : base($"Permision \"{permision}\" is invalid.", ex)
        {
        }
    }
}
