using System;

namespace Splendor.Domain
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string notFoundObjectName) : base($"{notFoundObjectName} was not found") { }
    }
}
