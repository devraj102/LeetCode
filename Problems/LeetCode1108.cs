using System.Text;
namespace Problems
{
    public class LeetCode1108
    {

        public string DefangIPaddr(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                return address;
            }
            StringBuilder sb = new StringBuilder();
            foreach (char c in address)
            {
                if (c == '.')
                {
                    sb.Append("[.]");
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        public string DefangIPaddrWithInBuildFunction(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                return address;
            }
            return address.Replace(".", "[.]");
        }
    }
}