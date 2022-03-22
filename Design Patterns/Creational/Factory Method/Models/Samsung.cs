using Factory_Method.Contracts;
using System.Text;

namespace Factory_Method.Models
{
    /// <summary>
    /// Implementation of ISmartphone interface.
    /// </summary>
    public class Samsung : ISmartphone
    {
        public string DeviceInformation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("OS: Android");
            stringBuilder.AppendLine("Origin: South Korea");
            stringBuilder.AppendLine("-------------");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
