using Factory_Method.Contracts;
using System.Text;

namespace Factory_Method.Models
{
    /// <summary>
    /// Implementation of ISmartphone interface
    /// </summary>
    public class IPhone : ISmartphone
    {
        public string DeviceInformation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("OS: iOS");
            stringBuilder.AppendLine("Origin: United States");
            stringBuilder.AppendLine("-------------");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
