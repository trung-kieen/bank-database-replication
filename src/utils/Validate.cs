using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;

/*
 * Perform validation user input and display error
 */
namespace BankReplication.utils
{
    class Validate
    {

        
        /*
         * Any validateForm function will throw an exception it user input is violation constaint
         * If catch => Display error for user and return true (not valid input) 
         */
        public static Boolean InvalidField(System.Windows.Forms.ComboBox comboBox, String fieldName, Action<String> validatePerform)
        {
            try
            {
                var gender = comboBox.Text.ToString();
                validatePerform(gender);
            }
            catch (Exception ex)
            {
                Msg.Warm("Trường lỗi: " + fieldName + "\nLỗi: " + ex.Message, "Dữ liệu được nhập không hợp lệ");
                return true;
            }
            return false;
        }

        /*
         * Any validateForm function will throw an exception it user input is violation constaint
         * If catch => Display error for user and return true (not valid input) 
         */
        public static  Boolean InvalidField(DevExpress.XtraEditors.TextEdit field, String fieldName, Action<String> validatePerform)
        {
            try
            {
                validatePerform(field.Text);
            }
            catch (Exception ex)
            {
                Msg.Warm("Trường lỗi: " + fieldName + "\nLỗi: " + ex.Message, "Dữ liệu được nhập không hợp lệ");
                field.Focus();

                return true;
            }
            return false;
        }

        public static bool InvalidCash(DevExpress.XtraEditors.TextEdit txtSoTien)
        {
            if (InvalidField(txtSoTien, "Số dư", validateTransferMoney)) return true;
            return false;
        }
        /*
         * All validate method will not return any result if have error it will throw exception
         * The exception message will use in display error
         */

        public static void validateMANV(String ma)
        {
            notNull(ma);
            maxLength(ma, 10);
            validateUnicodeChar(ma);

        }

        public static void validateSoTK(String sotk)
        {
            notNull(sotk);
            exactLength(sotk, 9);
            validateDigit(sotk);
        }
        public static void validateSoTien(String sotk)
        {
            notNull(sotk);
            PositiveDouble(sotk);
            ValidMoney(sotk);
        }
        public static void validateTransferMoney(String sotk)
        {
            notNull(sotk);
            PositiveDouble(sotk);
            ValidMoney(sotk);
            NonZeroMoney(sotk);
        }
        public static void validateLoginName(String login)
        {
            notNull(login);
            minLength(login, 2);
        }
        public static void validatePassword(String pass)
        {
            notNull(pass);
            minLength(pass, 2);
        }


        public static void validateHo(String ho)
        {
            notNull(ho);
            minLength(ho, 2);
            stringRange(ho, 50);
            validateNcharNotDigit(ho);
            validateTitleCase(ho);
        }
        public static void validateTen(String ten)
        {
            notNull(ten);
//            minLength(ten, 2);
            stringRange(ten, 10);
            validateNcharNotDigit(parser(ten));
            validateTitleCase(ten);
        }


        public static void validateDiaChi(String address)
        {
            notNull(address);
            stringRange(address, 100);
            validateStreet(parser(address));
        }


        /// <summary>
        /// TODO: validate unique
        /// </summary>
        /// <param name="persionId"></param>
        public static void validateCMND(String persionId)
        {
            notNull(persionId);
            if (parser(persionId).Length != 10) throw new Exception("Chuỗi phải gồm 10 ký tự không tính khoảng trắng");
            validateDigit(persionId);
        }

        public static void validateMACN(String ma)
        {
            notNull(ma);
//            if (parser(ma).Length != 10) throw new Exception("Chuỗi phải gồm 10 ký tự không tính khoảng trắng");

        }


        public static void validatePhai(String phai)
        {
            notNull(phai);
            String [] dsPhai = {"NAM", "NU", "NỮ"};

            if (!dsPhai.Any(s => s.Equals(phai.Trim().ToUpper()))) throw new Exception("Giới tính không hợp lệ " );

        }

        public static void validateSDT(String sdt)
        {
            notNull(sdt);
            validatePhoneNum(parser(sdt));
            if (parser(sdt).Length > 15) throw new Exception("Không được quá 15 ký tự");
        }

        // =======================> Helper function <=======================

        private static void stringRange(String s, int  size )
        {
            maxLength(s, size);
            if (parser(s).Length == 0) throw new Exception("Chuỗi không được trống");
        }

        /// <summary>
        /// Check if string is contain only unicode character and space
        /// If catch digit an exception will throw
        /// </summary>
        /// <param name="s"></param>
        private static void validateNcharNotDigit (String s)
        {
            if (!Regex.IsMatch(s, @"^[a-zA-Z\sàáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ]*$")) throw new Exception("Chuỗi chỉ được chứa ký tự chữ cái trong bảng chữa cái unicode hoặc dấu cách");
               
        }


        public static void validateTitleCase(String text)
        {

            if (!IsTitleCase(text)) throw new Exception("Chuỗi là tên riêng nên phải viết in hoa chữ cái đầu mỗi chữ cái");
        }

        private static void validateUnicodeChar(String s)
        {
            if (!Regex.IsMatch(parser(s), @"^[a-zA-Z0-9\sàáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ]*$")) throw new Exception("Chuỗi chỉ được chứa ký tự trong bảng chữa cái, số hoặc dấu cách");
               
        }
        private static void validateStreet(String s)
        {
            if (!Regex.IsMatch(parser(s), @"^[\/\#\-a-zA-Z0-9\sàáãạảăắằẳẵặâấầẩẫậèéẹẻẽêềếểễệđìíĩỉịòóõọỏôốồổỗộơớờởỡợùúũụủưứừửữựỳỵỷỹýÀÁÃẠẢĂẮẰẲẴẶÂẤẦẨẪẬÈÉẸẺẼÊỀẾỂỄỆĐÌÍĨỈỊÒÓÕỌỎÔỐỒỔỖỘƠỚỜỞỠỢÙÚŨỤỦƯỨỪỬỮỰỲỴỶỸÝ]*$")) throw new Exception("Chuỗi chỉ được chứa ký tự trong bảng chữa cái, số hoặc dấu cách và các ký tự '#', '/', '-'");
               
        }

        private static void validateDigit(String s)
        {

            if (!Regex.IsMatch(parser(s), @"^[0-9]*$")) throw new Exception("Chuỗi chỉ được chứa các ký tự là số");
        }
        private static void validatePhoneNum(String s)
        {

            if (!Regex.IsMatch(parser(s), @"^+?[0-9]*$")) throw new Exception("Chuỗi chỉ được chứa các ký tự là số, đây không phải là số điện thoại hợp lệ");
        }
        private static void minLength(String s, int length)
        {
            if (parser(s).Length < length) throw new Exception("Chuỗi không được có độ dài nhỏ hơn " + length + " ký tự");
        }

        private static void maxLength(String s, int length)
        {
            if (parser(s).Length > length) throw new Exception("Chuỗi không được có độ dài lớn hơn " + length + " ký tự");
        }
        private static void exactLength(String s, int length)
        {
            if (parser(s).Length != length) throw new Exception("Chuỗi phải có độ dài chính xác là " + length + " ký tự");
        }
        private static void notNull(String s)
        {
            if (parser(s).Length== 0 ) throw new Exception("Không được để trống");
        }
        public static String parser(String s) {
            return s.ToString().Trim();
        }
        public static Boolean IsTitleCase(String s)
        {
                if (string.IsNullOrEmpty(s))
                    return false;
                return s == CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s);

        }
        public static void PositiveDouble(String s)
        {
            if (Double.Parse(s) < 0) throw new Exception("Giá trị không được âm");

        }
        public static void ValidMoney(String s)
        {
            float num;
            bool isValid = float.TryParse(s,
            NumberStyles.Currency,
            CultureInfo.GetCultureInfo("en-US"), // cached
            out num);
            if (!isValid) throw new Exception("Giá trị không hợp lệ với kiểu dữ liệu tiền tệ");
            if( System.Data.SqlTypes.SqlMoney.Parse(s)> System.Data.SqlTypes.SqlMoney.MaxValue)
            throw new Exception("Giá trị vượt quá giá trị tối đa có thể lưu trữ");
        }
        public static void NonZeroMoney(String s)
        {
            if (Decimal.Parse(s) == 0) throw new Exception("Số tiền trong giao dịch không thể bằng 0");
        }
    }

}
