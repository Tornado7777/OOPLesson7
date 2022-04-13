using System.Collections.Generic;


namespace OOPLesson7
{
    /*
     * Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите 
     * на i-й позиции, на букву того же регистра, расположенную в алфавите на 
     * i-й позиции с конца алфавита. (Например, буква В заменяется на букву Э. 
     * Написать программу, демонстрирующую функционирование классов).
     */
    internal class BCode : ICoder
    {
        public string Decode(string text) => Encode(text);
        public string Encode(string text)
        {
            string result = "";
            text = text.ToUpper();
            var alphabet = Alphabet();
            int alphabetCount = alphabet.Count;
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                int indexChar = alphabet.FindIndex(c => c == ch);
                if (indexChar >= 0) result += alphabet[alphabetCount -1- indexChar ];
            }
            return result;
        }
        private List<char> Alphabet()
        {
            List<char> alphabet = new List<char>();
            for (int i = 1040; i < 1072; i++)
            {
                alphabet.Add((char)i);
                //добавляем Ё
                if (i == 1045)
                    alphabet.Add((char)1025);
            }
            return alphabet;
        }
    }
}
