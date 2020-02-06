using System;

namespace EntityGraphQL.Compiler
{
    public class EntityGraphQLCompilerException : System.Exception
    {
        public EntityGraphQLCompilerException(string message, Exception innerException = null) : base(message, innerException)
        {
        }
    }

    public class EntityGraphQLAccessException : System.Exception
    {
        public EntityGraphQLAccessException(string message) : base(message)
        {
        }
    }
}
