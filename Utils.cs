using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cellular
{

    public static class Utils
    {
        public static string ValidatePhone(string phoneNumber)
        {
            string[] start = new string[] { "+7", "7", "8" };
            bool validStart = false;
            foreach (string s in start)
            {
                if (phoneNumber.StartsWith(s))
                {
                    validStart = true;
                    break;
                }
            }
            if (!validStart)
                throw new ValidatePhoneException("Номер должен начинаться с +7, 7 или 8");

            List<char> nums = new List<char>();
            foreach (char ch in phoneNumber)
            {
                if (IsNumber(ch))
                    nums.Add(ch);
            }
            if (nums.Count != 11)
                throw new ValidatePhoneException($"Длина номера должна составлять 11 символов, а не {nums.Count}");

            if (nums[0] == '7')
                nums[0] = '8';

            return $"{String.Join<char>("", nums)}";
        }

        public static bool IsNumber(char value)
        {
            return Char.IsDigit(value);
        }

        public static void Debug(object value)
        {
            System.Diagnostics.Debug.WriteLine(value);
        }
    }

    public class ValidatePhoneException : Exception
    {
        public ValidatePhoneException()
        {
        }

        public ValidatePhoneException(string message)
            : base(message)
        {
        }

        public ValidatePhoneException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public static class FormRunner
    {
        public static void RunForm(Form currentForm, Form newFowm)
        {
            currentForm.Hide();
            newFowm.Closed += (s, args) => currentForm.Close();
            newFowm.Show();
        }
    }

    public static class Msg
    {
        public static void ShowInfoMessage(string message, string caption = "Информация")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowErrorMessage(string message, string caption = "Ошибка")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarningMessage(string message, string caption = "Предупреждение")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowList(List<string> list, string caption = "Информация")
        {
            List<string> tempList = new List<string>();
            int i = 1;
            foreach (string item in list)
            {
                tempList.Add($"{i}) {item}");
                i++;
            }
            Msg.ShowInfoMessage(String.Join("\n", tempList), caption);
        }
    }

    public static class Dialog
    {
        public static DialogResult ConfirmDialog(string message, string caption = "Подтверждение")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }

    public class ComboBoxItem
    {
        public int Key { get; set; }
        public string Value { get; set; }
        public ComboBoxItem(int key, string value)
        {
            Key = key; 
            Value = value;
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
