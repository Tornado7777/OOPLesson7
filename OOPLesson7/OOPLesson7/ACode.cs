using System.Collections.Generic;


namespace OOPLesson7
{
    /*
     * Класс шифрует строку посредством сдвига каждого символа 
     * на одну «алфавитную» позицию выше. (В результате такого 
     * сдвига буква А становится буквой Б).
     */
    internal class ACode : ICoder
    {
        public string Decode(string text)
        {
            string result = "";
            text = text.ToUpper();
            var alphabet = Alphabet();
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                int indexChar = alphabet.FindIndex(c => c == ch);
                if (indexChar > 0 && indexChar <= alphabet.Count-1) result += alphabet[indexChar - 1];
                if (indexChar == 0) result += alphabet[alphabet.Count-1];
            }
            return result;
        }

        public string Encode(string text)
        {
            string result = "";
            text = text.ToUpper();
            var alphabet = Alphabet();
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];            
                int indexChar = alphabet.FindIndex(c => c == ch);
                if(indexChar >= 0 && indexChar <alphabet.Count-1) result +=alphabet[indexChar+1];
                if (indexChar == alphabet.Count-1) result += alphabet[0];
            }
            return result;
        }
        private List<char> Alphabet()
        {
            List<char> alphabet = new List<char>();
            for (int i = 1040; i< 1072; i++)
            {
                alphabet.Add((char) i);
                //добавляем Ё
                if (i == 1045)
                    alphabet.Add((char)1025);
            }
            return alphabet;
        }
    }
}
