using smart_House_Project.Models.Enums.v1;

namespace smart_House_Project.Utilities
{
    public static class LegalReferenceNumberExtentions
    {
        public static GenderV1 ExtractGender(this string number)
        {
            if(string.IsNullOrEmpty(number) || !FieldValidation.IsValidSAIDNumber(number))
                return GenderV1.NotSet;

            var value = Convert.ToInt16(number.Substring(6, 1));

            if(value < 5)
                return GenderV1.Female;
            else
                return GenderV1.Male;
        }
        public static DateTime? ExtractDateOfBirth(this string number)
        {
            if(string.IsNullOrEmpty(number) || !FieldValidation.IsValidSAIDNumber(number))
                return null;

            var year = Convert.ToInt32(number.Substring(0, 2));
            var currentYear = DateTime.Now.Year % 100;

            var prefix = "19";

            if(year < currentYear)
            {
                prefix = "20";
            }
            return new DateTime(Convert.ToInt16(prefix + number.Substring(0, 2)), Convert.ToInt16(number.Substring(2, 2)), Convert.ToInt16(number.Substring(4, 2)));
        }

        public static bool ValidateID(string IDNumber)
        {
            try
            {
                if (IDNumber.Length == 13)
                {

                    string year = IDNumber.Substring(0, 2);
                    if (year.StartsWith("0"))
                    {
                        year = "20" + year;
                    }
                    else
                    {
                        year = "19" + year;
                    }
                    if(!IDNumber.Contains("xxxx"))
                    {
                        int month = Convert.ToInt16(IDNumber.Substring(2, 2));
                        int day = Convert.ToInt16(IDNumber.Substring(4, 2));
                        DateTime testDT = new DateTime(Convert.ToInt16(year), month, day);
                    }
                    _ = Convert.ToInt64(IDNumber.Replace("x", "0"));
                    return true;
                }
            }
            catch
            {
            };

            return false;
        }
    }
}
