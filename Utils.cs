using System.Text.RegularExpressions;

namespace MultipleChoise.Utils
{
    public class ManageUltimate
    {
        public static string NomalizationString(string sto)
        {
            if (string.IsNullOrEmpty(sto)) return "";
            string st = sto.Trim();
            st = Regex.Replace(st, @"\s+", " ");
            st = Regex.Replace(st, @"([.,;?])(\S)", "$1 $2");
            st = Regex.Replace(st, @"(?<=\.\s)\p{Ll}", m => m.Value.ToUpper());
            return st;
        }
    }
}
