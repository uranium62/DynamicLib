namespace DynamicLib.Parser
{
    using System;

    public class DynamicSignature : IEquatable<DynamicSignature>
    {
        public readonly DynamicProperty[] Properties;

        public readonly int HashCode;

        public DynamicSignature(DynamicProperty[] properties)
        {
            Properties = properties;

            HashCode = 0;
            foreach (DynamicProperty p in properties)
            {
                HashCode ^= p.Name.GetHashCode() ^ p.Type.GetHashCode();
            }
        }

        public override int GetHashCode()
        {
            return HashCode;
        }

        public override bool Equals(object obj)
        {
            if (obj is DynamicSignature)
            {
                return Equals((DynamicSignature) obj);
            }

            return false;
        }

        public bool Equals(DynamicSignature other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }

            if (Properties.Length != other.Properties.Length)
            {
                return false;
            }
            for (int i = 0; i < Properties.Length; i++)
            {
                if (Properties[i].Name != other.Properties[i].Name || Properties[i].Type != other.Properties[i].Type)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
