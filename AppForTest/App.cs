using System;

namespace AppForTest
{
    public class App
    {
        //<summary>
        //return integer number of roman number
        //return 0 if roman number incorrect
        //</summary>
        public int RomanToInt(string s)
        {
            int answer = 0;
            int index = 0;

            while (index < s.Length)
            {
                switch (s[index])
                {
                    case 'I':
                        if (index == s.Length - 1)
                        {
                            answer++;
                            index++;
                        }
                        else if (s[index + 1] == 'V')
                        {
                            answer += 4;
                            index += 2;
                        }
                        else if (s[index + 1] == 'X')
                        {
                            answer += 9;
                            index += 2;
                        }
                        else
                        {
                            answer++;
                            index++;
                        }
                        break;
                    case 'V':
                        answer += 5;
                        index++;
                        break;
                    case 'X':
                        if (index == s.Length - 1)
                        {
                            answer += 10;
                            index++;
                        }
                        else if (s[index + 1] == 'L')
                        {
                            answer += 40;
                            index += 2;
                        }
                        else if (s[index + 1] == 'C')
                        {
                            answer += 90;
                            index += 2;
                        }
                        else
                        {
                            answer += 10;
                            index++;
                        }
                        break;
                    case 'L':
                        answer += 50;
                        index++;
                        break;
                    case 'C':
                        if (index == s.Length - 1)
                        {
                            answer += 100;
                            index++;
                        }
                        else if (s[index + 1] == 'D')
                        {
                            answer += 400;
                            index += 2;
                        }
                        else if (s[index + 1] == 'M')
                        {
                            answer += 900;
                            index += 2;
                        }
                        else
                        {
                            answer += 100;
                            index++;
                        }
                        break;
                    case 'D':
                        answer += 500;
                        index++;
                        break;
                    case 'M':
                        answer += 1000;
                        index++;
                        break;
                    default:
                        return 0;
                }
            }

            return answer;
        }


        public static void Main(string[] args)
        {

        }
    }
}