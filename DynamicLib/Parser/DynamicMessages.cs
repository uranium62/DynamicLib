namespace DynamicLib.Parser
{
    internal static class DynamicMessages
    {
        /// <summary>
        /// The duplicate identifier
        /// </summary>
        public const string DuplicateIdentifier = "The identifier '{0}' was defined more than once";
        /// <summary>
        /// The expression type mismatch
        /// </summary>
        public const string ExpressionTypeMismatch = "Expression of type '{0}' expected";
        /// <summary>
        /// The expression expected
        /// </summary>
        public const string ExpressionExpected = "Expression expected";
        /// <summary>
        /// The invalid character literal
        /// </summary>
        public const string InvalidCharacterLiteral = "Character literal must contain exactly one character";
        /// <summary>
        /// The invalid integer literal
        /// </summary>
        public const string InvalidIntegerLiteral = "Invalid integer literal '{0}'";
        /// <summary>
        /// The invalid real literal
        /// </summary>
        public const string InvalidRealLiteral = "Invalid real literal '{0}'";
        /// <summary>
        /// The unknown identifier
        /// </summary>
        public const string UnknownIdentifier = "Unknown identifier '{0}'";
        /// <summary>
        /// The no it in scope
        /// </summary>
        public const string NoItInScope = "No 'it' is in scope";
        /// <summary>
        /// The iif requires three arguments
        /// </summary>
        public const string IifRequiresThreeArgs = "The 'iif' function requires three arguments";
        /// <summary>
        /// The first expr must be bool
        /// </summary>
        public const string FirstExprMustBeBool = "The first expression must be of type 'Boolean'";
        /// <summary>
        /// The both types convert to other
        /// </summary>
        public const string BothTypesConvertToOther = "Both of the types '{0}' and '{1}' convert to the other";
        /// <summary>
        /// The neither type converts to other
        /// </summary>
        public const string NeitherTypeConvertsToOther = "Neither of the types '{0}' and '{1}' converts to the other";
        /// <summary>
        /// The missing as clause
        /// </summary>
        public const string MissingAsClause = "Expression is missing an 'as' clause";
        /// <summary>
        /// The arguments incompatible with lambda
        /// </summary>
        public const string ArgsIncompatibleWithLambda = "Argument list incompatible with lambda expression";
        /// <summary>
        /// The type has no nullable form
        /// </summary>
        public const string TypeHasNoNullableForm = "Type '{0}' has no nullable form";
        /// <summary>
        /// The no matching constructor
        /// </summary>
        public const string NoMatchingConstructor = "No matching constructor in type '{0}'";
        /// <summary>
        /// The ambiguous constructor invocation
        /// </summary>
        public const string AmbiguousConstructorInvocation = "Ambiguous invocation of '{0}' constructor";
        /// <summary>
        /// The cannot convert value
        /// </summary>
        public const string CannotConvertValue = "A value of type '{0}' cannot be converted to type '{1}'";
        /// <summary>
        /// The no applicable method
        /// </summary>
        public const string NoApplicableMethod = "No applicable method '{0}' exists in type '{1}'";
        /// <summary>
        /// The methods are inaccessible
        /// </summary>
        public const string MethodsAreInaccessible = "Methods on type '{0}' are not accessible";
        /// <summary>
        /// The method is void
        /// </summary>
        public const string MethodIsVoid = "Method '{0}' in type '{1}' does not return a value";
        /// <summary>
        /// The ambiguous method invocation
        /// </summary>
        public const string AmbiguousMethodInvocation = "Ambiguous invocation of method '{0}' in type '{1}'";
        /// <summary>
        /// The unknown property or field
        /// </summary>
        public const string UnknownPropertyOrField = "No property or field '{0}' exists in type '{1}'";
        /// <summary>
        /// The no applicable aggregate
        /// </summary>
        public const string NoApplicableAggregate = "No applicable aggregate method '{0}' exists";
        /// <summary>
        /// The cannot index multi dim array
        /// </summary>
        public const string CannotIndexMultiDimArray = "Indexing of multi-dimensional arrays is not supported";
        /// <summary>
        /// The invalid index
        /// </summary>
        public const string InvalidIndex = "Array index must be an integer expression";
        /// <summary>
        /// The no applicable indexer
        /// </summary>
        public const string NoApplicableIndexer = "No applicable indexer exists in type '{0}'";
        /// <summary>
        /// The ambiguous indexer invocation
        /// </summary>
        public const string AmbiguousIndexerInvocation = "Ambiguous invocation of indexer in type '{0}'";
        /// <summary>
        /// The incompatible operand
        /// </summary>
        public const string IncompatibleOperand = "Operator '{0}' incompatible with operand type '{1}'";
        /// <summary>
        /// The incompatible operands
        /// </summary>
        public const string IncompatibleOperands = "Operator '{0}' incompatible with operand types '{1}' and '{2}'";
        /// <summary>
        /// The unterminated string literal
        /// </summary>
        public const string UnterminatedStringLiteral = "Unterminated string literal";
        /// <summary>
        /// The invalid character
        /// </summary>
        public const string InvalidCharacter = "Syntax error '{0}'";
        /// <summary>
        /// The digit expected
        /// </summary>
        public const string DigitExpected = "Digit expected";
        /// <summary>
        /// The syntax error
        /// </summary>
        public const string SyntaxError = "Syntax error";
        /// <summary>
        /// The token expected
        /// </summary>
        public const string TokenExpected = "{0} expected";
        /// <summary>
        /// The parse exception format
        /// </summary>
        public const string ParseExceptionFormat = "{0} (at index {1})";
        /// <summary>
        /// The colon expected
        /// </summary>
        public const string ColonExpected = "':' expected";
        /// <summary>
        /// The open paren expected
        /// </summary>
        public const string OpenParenExpected = "'(' expected";
        /// <summary>
        /// The close paren or operator expected
        /// </summary>
        public const string CloseParenOrOperatorExpected = "')' or operator expected";
        /// <summary>
        /// The close paren or comma expected
        /// </summary>
        public const string CloseParenOrCommaExpected = "')' or ',' expected";
        /// <summary>
        /// The dot or open paren expected
        /// </summary>
        public const string DotOrOpenParenExpected = "'.' or '(' expected";
        /// <summary>
        /// The open bracket expected
        /// </summary>
        public const string OpenBracketExpected = "'[' expected";
        /// <summary>
        /// The close bracket or comma expected
        /// </summary>
        public const string CloseBracketOrCommaExpected = "']' or ',' expected";
        /// <summary>
        /// The identifier expected
        /// </summary>
        public const string IdentifierExpected = "Identifier expected";
    }
}
