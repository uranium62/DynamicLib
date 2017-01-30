namespace DynamicLib.Parser
{
    using System;
    using System.Linq.Expressions;

    public class DynamicParser
    {
        public DynamicParser(ParameterExpression[] parameters, string exp, object[] vals)
        {
            if (exp == null)
            {
                throw new ArgumentNullException("exp");
            }
        }
    }
}
